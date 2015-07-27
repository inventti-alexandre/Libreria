
CREATE PROCEDURE [dbo].[usp_TraerFacCliCaja]
	@Id uniqueidentifier
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT dbo.Ventas.SucursalAltaId as FacSuc, dbo.Ventas.Id as FacId, 
			dbo.Ventas.LCN, dbo.Ventas.FechaComprobante as Fecha, dbo.Ventas.Concepto as Cpto, 0 as NcTotal,
			dbo.Ventas.ImporteNeto as nTotal, dbo.Ventas.ImporteSena as nSena, dbo.Ventas.TotalPagado as nTotPag, 
			dbo.CajasMovimientos.SucursalAltaId as CajaSuc, dbo.CajasMovimientos.CajaId, dbo.Clientes.Denominacion
FROM  dbo.Ventas INNER JOIN
          dbo.Clientes ON dbo.Ventas.ClienteId = dbo.Clientes.Id INNER JOIN
          dbo.CajasMovimientos ON dbo.Ventas.Id = dbo.CajasMovimientos.ComprobanteId 
WHERE dbo.Ventas.Id = @Id 

