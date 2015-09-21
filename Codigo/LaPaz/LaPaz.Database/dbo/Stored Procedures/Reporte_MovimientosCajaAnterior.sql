CREATE PROCEDURE [dbo].[Reporte_MovimientosCajaAnterior]
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
		Deposito money,
		Transferencia money
	)


	-----------------------------------------------------------
	--------------  DEPOSITO CON CAJA ANTERIOR-----------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Egresos',
			'Depósitos con Caja Anterior',
			OP.NumeroComprobante,-- C.NumeroComprobante,
			CM.FechaAlta,
			'Depósitos con Caja Anterior',
			P.Denominacion,-- C.Concepto,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0),
			ISNULL(CM.Transferencia, 0)
	FROM CajasMovimientos CM
		--LEFT JOIN Compras C
			--ON CM.ComprobanteId = C.Id
		LEFT JOIN OrdenesPago OP
			ON OP.Id=CM.ComprobanteId
		LEFT JOIN Proveedores P
			ON P.Id=OP.ProveedorId
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
	WHERE CM.TipoMovimientoCajaId = 31 --DEPOSITO CON CAJA ANTERIOR
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND CM.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)

	

	-----------------------------------------------------------------------
	----------------  SEÑA A PROVEEDORES CON CAJA ANTERIOR-----------------
	-----------------------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Egresos',
				'Seña a proveedores con Caja Anterior',
				'-',
				CM.FechaAlta,
				'Seña a Proveedor - transferencia',
				P.Denominacion,
				O.Usuario,
				ISNULL(CM.Senia, 0),
				ISNULL(CM.Recargo, 0),
				ISNULL(CM.ImpFac, 0),
				ISNULL(CM.Importe, 0),
				ISNULL(CM.Efectivo, 0),
				ISNULL(CM.Tarjeta, 0),
				ISNULL(CM.Cheque, 0),
				ISNULL(CM.Deposito, 0),
				ISNULL(CM.Transferencia, 0)
		FROM CajasMovimientos CM
			LEFT JOIN ProveedoresSenias PS
				ON CM.ComprobanteId = PS.Id
			LEFT JOIN Operadores O
				ON CM.OperadorAltaId = O.Id
			LEFT JOIN Proveedores P
				ON PS.ProveedorId = P.Id
		WHERE CM.TipoMovimientoCajaId = 33
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND CM.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)
	

	
	-----------------------------------------------------------------------
	----------------  PAGO A PROVEEDORES CON CAJA ANTERIOR-----------------
	-----------------------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Egresos',
			'Pagos a Proveedores con Caja Anterior',
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
			ISNULL(CM.Deposito, 0),
			ISNULL(CM.Transferencia, 0)
	FROM CajasMovimientos CM
		LEFT JOIN Compras C
			ON CM.ComprobanteId = C.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
		LEFT JOIN Proveedores P
			ON C.ProveedorId = P.Id
	WHERE CM.TipoMovimientoCajaId = 34 --PAGO A PROVEEDORES
		AND CM.FechaAlta >= @FechaInicio
		AND CM.FechaAlta < @FechaFin
		AND CM.SucursalAltaId = @SucursalId
		AND (@OperadorId IS NULL OR CM.OperadorAltaId = @OperadorId)


		-----------------------------------------------------------------------
	----------------  PAGO A PROVEEDORES CON CAJA ANTERIOR-----------------
	-----------------------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Egresos',
			'Pagos a Proveedores con Caja Anterior',
			'',
			CM.FechaAlta,
			'Pago Cuenta',
			P.Denominacion,
			O.Usuario,
			ISNULL(CM.Senia, 0),
			ISNULL(CM.Recargo, 0),
			ISNULL(CM.ImpFac, 0),
			ISNULL(CM.Importe, 0),
			ISNULL(CM.Efectivo, 0),
			ISNULL(CM.Tarjeta, 0),
			ISNULL(CM.Cheque, 0),
			ISNULL(CM.Deposito, 0),
			ISNULL(CM.Transferencia, 0)
	FROM CajasMovimientos CM
		LEFT JOIN ProveedoresPagos PP
			ON CM.ComprobanteId = PP.Id
		LEFT JOIN Operadores O
			ON CM.OperadorAltaId = O.Id
		LEFT JOIN Proveedores P
			ON PP.ProveedorId = P.Id
	WHERE CM.TipoMovimientoCajaId = 36 --PAGO CUENTA A PROVEEDORES
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
	
	INSERT INTO @Final
	SELECT Tipo,
			Titulo,
			'Transferencia',
			NroComprobante,
			Fecha,
			Concepto,
			ApellidoYNombre,
			Operador,
			Senia,
			Recargo,
			Factura,
			Transferencia
	FROM @Temp
	WHERE Transferencia != 0

	SELECT * 
	FROM @Final
	ORDER BY Tipo, Titulo, FormaPago, Fecha, NroComprobante
END