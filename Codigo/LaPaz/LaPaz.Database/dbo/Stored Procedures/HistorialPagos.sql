CREATE PROCEDURE [dbo].[HistorialPagos] 
	-- Add the parameters for the stored procedure here
	@compraId uniqueidentifier = null,
	@proveedorId uniqueidentifier = null
	
	AS
BEGIN

	DECLARE @Movimientos TABLE
	(
	[Id] [uniqueidentifier] NOT NULL,
	[CajaId] [uniqueidentifier] NOT NULL,
	[TipoMovimientoCajaId] [int] NULL,
	[TipoComprobante] [int] NULL,
	[ComprobanteId] [uniqueidentifier] NULL,
	[Senia] [money] NULL,
	[Recargo] [money] NULL,
	[Importe] [money] NULL,
	[ImpFac] [money] NULL,
	[Efectivo] [money] NULL,
	[Tarjeta] [money] NULL,
	[Cheque] [money] NULL,
	[Bono] [money] NULL,
	[fpcBono] [nvarchar](20) NULL,
	[Deposito] [money] NULL,
	[CajaIdAnt] [nchar](20) NULL,
	[CompIdAnt] [nchar](20) NULL,
	[CompLcnAnt] [nchar](20) NULL,
	[FacturaReservadas] [int] NULL,
	[PcAlta] [nvarchar](20) NULL,
	[FechaAlta] [datetime] NULL,
	[OperadorAltaId] [uniqueidentifier] NULL,
	[SucursalAltaId] [int] NULL,
	[FechaModificacion] [datetime] NULL,
	[OperadorModificacionId] [uniqueidentifier] NULL,
	[SucursalModificacionId] [int] NULL,
	[Transferencia] [money] NULL,
	[TipoMovimientoCaja] [nvarchar](50) NULL,
	[ComprobanteTipo] [nvarchar](50) NULL
	)
	
	INSERT INTO @Movimientos
	SELECT cm.*, tmc.Nombre, TC.Nombre
	from CajasMovimientos cm
	INNER JOIN TiposMovimientosCajas tmc ON tmc.Id = cm.TipoMovimientoCajaId
	INNER JOIN TiposComprobantes tc ON TC.Id= cm.TipoComprobante
	where cm.ComprobanteId = @compraId

	INSERT INTO @Movimientos
	SELECT cm.*, tmc.Nombre, TC.Nombre
	FROM CajasMovimientos cm
	INNER JOIN ProveedoresPagos pp  ON pp.Id = cm.ComprobanteId
	INNER JOIN ProveedoresPagosDetalle ppd  ON ppd.ProveedorPagoId = pp.Id
	INNER JOIN ProveedoresCuentasCorriente pcc  ON pcc.Id = ppd.ProveedorCuentaCorrienteId
	INNER JOIN TiposMovimientosCajas tmc ON tmc.Id = cm.TipoMovimientoCajaId
	INNER JOIN TiposComprobantes tc ON TC.Id= cm.TipoComprobante
	WHERE (@compraId IS NULL OR @compraId = pcc.CompraId)
	AND  (@proveedorId IS NULL OR @proveedorId = PP.ProveedorId)

	SELECT * FROM @Movimientos
END

GO

