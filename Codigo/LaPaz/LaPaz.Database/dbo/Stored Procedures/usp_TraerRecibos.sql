


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_TraerRecibos] 
	@ReciboId uniqueidentifier

AS

SET NOCOUNT ON

SELECT     dbo.Recibos.Id, dbo.Recibos.SucursalCompId, dbo.Recibos.Tipo, dbo.Recibos.PuntoVenta, dbo.Recibos.Numero, dbo.Recibos.FechaAnulacion, 
                      dbo.Recibos.FechaPago, dbo.Recibos.Total, dbo.Recibos.OperadorAuId, dbo.Recibos.OperadorAltaId, dbo.Recibos.FechaAlta, 
                      dbo.Recibos.SucursalAltaId, dbo.RecibosDetalle.Id AS DetalleId, dbo.RecibosDetalle.ReciboId, dbo.RecibosDetalle.ClienteCuentaCorrienteId, 
                      dbo.RecibosDetalle.Importe, dbo.Ventas.LCN, dbo.ClientesCuentasCorriente.Importe AS ImpCuo, dbo.ClientesCuentasCorriente.Cuota, 
                      dbo.Operadores.Usuario AS OpeAu, dbo.Clientes.SucursalId AS CliSuc, dbo.Clientes.Cuenta AS CliCuenta, dbo.Clientes.Denominacion, 
                      dbo.ClientesCuentasCorriente.ClienteId, dbo.Clientes.Domicilio, dbo.Clientes.Telefono, dbo.Localidades.Nombre AS Localidad, 
                      dbo.CajasMovimientos.Id AS CajaId
FROM         dbo.Localidades INNER JOIN
                      dbo.Clientes ON dbo.Localidades.Id = dbo.Clientes.LocalidadId INNER JOIN
                      dbo.Recibos INNER JOIN
                      dbo.RecibosDetalle ON dbo.Recibos.Id = dbo.RecibosDetalle.ReciboId INNER JOIN
                      dbo.ClientesCuentasCorriente ON dbo.RecibosDetalle.ClienteCuentaCorrienteId = dbo.ClientesCuentasCorriente.Id INNER JOIN
                      dbo.Ventas ON dbo.ClientesCuentasCorriente.VentaId = dbo.Ventas.Id ON dbo.Clientes.Id = dbo.ClientesCuentasCorriente.ClienteId LEFT OUTER JOIN
                      dbo.CajasMovimientos ON dbo.Recibos.Id = dbo.CajasMovimientos.ComprobanteId LEFT OUTER JOIN
                      dbo.Operadores ON dbo.Recibos.OperadorAuId = dbo.Operadores.Id
WHERE  dbo.Recibos.Id=@ReciboId


--LEFT OUTER JOIN
--ClientesCuentasCorriente ON Ventas.Id = ClientesCuentasCorriente.VentaId

---Notas de credito

