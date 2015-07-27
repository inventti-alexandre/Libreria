
CREATE PROCEDURE [dbo].[usp_CtaCteClientes2] 
	@ClienteId uniqueidentifier

AS

SET NOCOUNT ON

SELECT   ClientesCuentasCorriente.Id AS VentaId, ClientesCuentasCorriente.Observaciones AS LCN, count(*) as Cant, Min(ClientesCuentasCorriente.Importe) as Importe, Min(ClientesCuentasCorriente.Cuota) as Desde, 
			Max(ClientesCuentasCorriente.Cuota) as Hasta, SUM(ClientesCuentasCorriente.Importe - ClientesCuentasCorriente.Pagado) as Tot, 
			Min(ClientesCuentasCorriente.FechaUltimoPago)as Fp, Min(ClientesCuentasCorriente.Fecha) as Fvta, Min(ClientesCuentasCorriente.FechaVencimiento)as Fvto,
			MIN(dbo.ClientesCuentasCorriente.FechaAlta)AS FeAlta, MIN(ClientesCuentasCorriente.SucursalAltaId) AS Sucursal, MIN(Sucursales.Nombre) as SucursalNombre
FROM  ClientesCuentasCorriente INNER JOIN Sucursales ON Sucursales.Id=ClientesCuentasCorriente.SucursalAltaId
WHERE ClientesCuentasCorriente.ClienteId = @ClienteId and  (ClientesCuentasCorriente.Importe - ClientesCuentasCorriente.Pagado) > 0 and
	  ClientesCuentasCorriente.VentaId = '00000000-0000-0000-0000-000000000000'
GROUP BY ClientesCuentasCorriente.Id, ClientesCuentasCorriente.Observaciones
