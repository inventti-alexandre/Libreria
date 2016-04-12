CREATE PROCEDURE [dbo].[Reporte_InformeCajaOriginal] 
	@SucursalId int,
	@FechaInicio datetime,
	@FechaFin datetime,
	@OperadorId uniqueidentifier = null
AS
BEGIN
	
	DECLARE @Temp TABLE 
	(
		Tipo varchar(50),
		Titulo varchar(100),
		NroComprobante varchar(20),
		Fecha datetime,
		Concepto varchar(50),
		ApellidoYNombre varchar(100),
		Operador varchar(50),
		Senia money,
		Recargo money,
		Factura money,
		Total money,
		Efectivo money,
		Tarjeta money,
		Cheque money,
		Deposito money
	)

	-----------------------------------------------------------
	------------  FACTURAS VENTAS - CONTADO  ------------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Ingresos',
			'Ventas al Contado',
			V.LCN,
			CM.FechaAlta,
			'FACT.VTA.CTADO.',
			C.Denominacion,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN Ventas V
			ON CM.ComprobanteId = V.Id
		LEFT JOIN Clientes C
			ON V.ClienteId = C.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
	WHERE CM.TipoMovimientoCajaId = 1 --FV.Cta.Ctado
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND V.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)
	
	-----------------------------------------------------------
	-------  FACTURAS VENTAS - CUENTA CORRIENTE ---------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Ingresos',
			'Factura Venta - Cuenta Cte.',
			V.LCN,
			CM.FechaAlta,
			'FACT.VTA.CTA.CTE.',
			C.Denominacion,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN Ventas V
			ON CM.ComprobanteId = V.Id
		LEFT JOIN Clientes C
			ON V.ClienteId = C.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
	WHERE CM.TipoMovimientoCajaId = 2 --FV.Cta.Cte
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND V.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)
	
	-----------------------------------------------------------
	------------------  COBRANZAS -----------------------------
	-----------------------------------------------------------	
	INSERT INTO @Temp
	SELECT 'Ingresos',
			'Cobranzas',
			R.Numero,
			CM.FechaAlta,
			'Recibos Cobranza',
			(SELECT TOP 1 CL.Denominacion
		FROM RecibosDetalle RD
			LEFT JOIN ClientesCuentasCorriente CCC
				ON RD.ClienteCuentaCorrienteId = CCC.Id 
			LEFT JOIN Clientes CL
				ON CCC.ClienteId = CL.Id
		WHERE RD.ReciboId = R.Id
		),
		O.Usuario,
		ISNULL(CM.Senia, 0),
		ISNULL(CM.Recargo, 0),
		ISNULL(CM.ImpFac, 0),
		ISNULL(CM.Importe, 0),
		ISNULL(CM.Efectivo, 0),
		ISNULL(CM.Tarjeta, 0),
		ISNULL(CM.Cheque, 0),
		ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN Recibos R
			ON CM.ComprobanteId = R.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
	WHERE CM.TipoMovimientoCajaId = 3 --Cobranza
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND R.SucursalCompId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)
			
					

	-----------------------------------------------------------
	------------------------  SEÑAS ---------------------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Ingresos',
			'Señas de Clientes',
			CMF.LCN,
			CM.FechaAlta,
			CMF.Concepto,
			C.Denominacion,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN ClientesMontosFavor CMF
			ON CM.ComprobanteId = CMF.Id
		LEFT JOIN Clientes C
			ON CMF.ClienteId = C.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
	WHERE CM.TipoMovimientoCajaId = 4 --Señas
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND CMF.SucursalAltaId = @SucursalId	
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)	


	-----------------------------------------------------------
	------------------- ANULACION SEÑAS A PROVEEDORES ---------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Ingresos',
			'Anulación Señas a Proveedores',
			'-',
			PS.FechaAnulacion,
			'Anulación Seña',
			P.Denominacion,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN ProveedoresSenias PS
			ON CM.ComprobanteId = PS.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
		LEFT JOIN Proveedores P
			ON PS.ProveedorId = P.Id
	WHERE CM.TipoMovimientoCajaId = 35 --PROVEEDORES SENIAS
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND CM.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)


	-----------------------------------------------------------
	-----------------  PAGOS A PROVEEDORES --------------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Egresos',
			'Pagos a Proveedores',
			C.NumeroComprobante,
			CM.FechaAlta,
			C.Concepto,
			P.Denominacion,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN Compras C
			ON CM.ComprobanteId = C.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
		LEFT JOIN Proveedores P
			ON C.ProveedorId = P.Id
	WHERE CM.TipoMovimientoCajaId = 9 --PAGO A PROVEEDORES
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND CM.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)
	
	
	-----------------------------------------------------------
	---------------------  DEPOSITOS EFECTIVO -----------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Egresos',
			'Depósitos en Efectivo',
			MF.NumeroComprobante,
			CM.FechaAlta,
			'Depósito Efectivo',
			MF.DescripcionMovimiento,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN MovimientosFondo MF
			ON CM.ComprobanteId = MF.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
	WHERE CM.TipoMovimientoCajaId = 17 --Movimientos Bcanarios
		AND MF.TipoMovimientoFondoId = 2
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND MF.SucursalId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)
		
	-----------------------------------------------------------
	---------------------  PAGOS GASTOS -----------------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Egresos',
			'Pag. Gastos - ' + TG.Nombre,
			OP.LCN,
			CM.FechaAlta,
			OP.Concepto,
			PR.Denominacion,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN OrdenesPago OP
			ON CM.ComprobanteId = OP.Id
		LEFT JOIN TiposGastos TG
			ON OP.TipoGastoId = TG.Id
		LEFT JOIN Proveedores PR
			ON OP.ProveedorId = PR.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
	WHERE CM.TipoMovimientoCajaId = 21 --Pago Gastos
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND OP.SucursalId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)
			
			
		

	
	-----------------------------------------------------------
	--------------  DEPOSITO CON CAJA ANTERIOR-----------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Egresos',
			'Depósitos con Caja Anterior',
			C.NumeroComprobante,
			CM.FechaAlta,
			'Depósitos con Caja Anterior',
			C.Concepto,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN Compras C
			ON CM.ComprobanteId = C.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
	WHERE CM.TipoMovimientoCajaId = 31 --DEPOSITO CON CAJA ANTERIOR
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND CM.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)


	-----------------------------------------------------------
	------------------- SEÑAS A PROVEEDORES-----------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Egresos',
			'Señas a Proveedores',
			'-',
			CM.FechaAlta,
			'Seña',
			P.Denominacion,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN ProveedoresSenias PS
			ON CM.ComprobanteId = PS.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
		LEFT JOIN Proveedores P
			ON PS.ProveedorId = P.Id
	WHERE CM.TipoMovimientoCajaId = 32 --PROVEEDORES SENIAS
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND CM.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)
	
	-----------------------------------------------------------
	------------ ANULACION FACTURAS VENTAS - CONTADO  ------------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Egresos',
			'Anulacion Ventas al Contado',
			V.LCN,
			CM.FechaAlta,
			'FACT.VTA.CTADO.',
			C.Denominacion,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN Ventas V
			ON CM.ComprobanteId = V.Id
		LEFT JOIN Clientes C
			ON V.ClienteId = C.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
	WHERE CM.TipoMovimientoCajaId = 27 -- Anulacion FV.Cta.Ctado
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND V.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)
	
	-----------------------------------------------------------
	------------ ANULACION FACTURAS VENTAS - CTA CTE  ------------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Egresos',
			'Anulacion Ventas Cta Cte',
			V.LCN,
			CM.FechaAlta,
			'FACT.VTA.CTACTE.',
			C.Denominacion,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN Ventas V
			ON CM.ComprobanteId = V.Id
		LEFT JOIN Clientes C
			ON V.ClienteId = C.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
	WHERE CM.TipoMovimientoCajaId = 26 -- Anulacion FV.Cta.Cte
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND V.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)
	
	-----------------------------------------------------------
	------------ Egreso por Devolución  ------------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Egresos',
			'Egreso por Devolución',
			V.LCN,
			CM.FechaAlta,
			'FACT.VTA',
			C.Denominacion,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN Ventas V
			ON CM.ComprobanteId = V.Id
		LEFT JOIN Clientes C
			ON V.ClienteId = C.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
	WHERE CM.TipoMovimientoCajaId = 12 -- Nota de credito
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND V.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)

		-----------------------------------------------------------
	------------ Egreso - Anulacion Seña  ------------------
	-----------------------------------------------------------
	INSERT INTO @Temp
	SELECT 'Egresos',
			'Anulacion Señas',
			'-',
			CM.FechaAlta,
			'Anul. Seña',
			C.Denominacion,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0)
	FROM CajasMovimientos CM
		LEFT JOIN ClientesMontosFavor CF
			ON CM.ComprobanteId = CF.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
		LEFT JOIN Clientes C
			ON CF.ClienteId = C.Id
	WHERE CM.TipoMovimientoCajaId = 16 --Anulacion seña clietne
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND CM.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)
	
	
	DECLARE @Final TABLE 
	(
		Tipo varchar(50),
		Titulo varchar(100),
		FormaPago varchar(100),
		NroComprobante varchar(20),
		Fecha datetime,
		Concepto varchar(50),
		ApellidoYNombre varchar(100),
		Operador varchar(50),
		Senia money,
		Recargo money,
		Factura money,
		Total money
	)
	
	INSERT INTO @Final
	SELECT Tipo,
			Titulo,
			'Sin Anticipo',
			NroComprobante,
			Fecha,
			Concepto,
			ApellidoYNombre,
			Operador,
			Senia,
			Recargo,
			Factura,
			Efectivo
	FROM @Temp
	WHERE Efectivo = 0 and Tarjeta = 0 and Cheque = 0 and Deposito = 0

	INSERT INTO @Final
	SELECT Tipo,
			Titulo,
			'Efectivo',
			NroComprobante,
			Fecha,
			Concepto,
			ApellidoYNombre,
			Operador,
			Senia,
			Recargo,
			Factura,
			Efectivo
	FROM @Temp
	WHERE Efectivo != 0
	
	INSERT INTO @Final
	SELECT Tipo,
			Titulo,
			'Tarjeta',
			NroComprobante,
			Fecha,
			Concepto,
			ApellidoYNombre,
			Operador,
			Senia,
			Recargo,
			Factura,
			Tarjeta
	FROM @Temp
	WHERE Tarjeta != 0
	
	INSERT INTO @Final
	SELECT Tipo,
			Titulo,
			'Cheque',
			NroComprobante,
			Fecha,
			Concepto,
			ApellidoYNombre,
			Operador,
			Senia,
			Recargo,
			Factura,
			Cheque
	FROM @Temp
	WHERE Cheque != 0
	
	INSERT INTO @Final
	SELECT Tipo,
			Titulo,
			'Depósito',
			NroComprobante,
			Fecha,
			Concepto,
			ApellidoYNombre,
			Operador,
			Senia,
			Recargo,
			Factura,
			Deposito
	FROM @Temp
	WHERE Deposito != 0
	
	SELECT * 
	FROM @Final
	ORDER BY Tipo, Titulo, FormaPago, Fecha, NroComprobante
END