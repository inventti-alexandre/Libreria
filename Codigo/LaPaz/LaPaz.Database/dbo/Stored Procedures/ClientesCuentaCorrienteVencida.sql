
-- =============================================
-- Author:		<Aguilar,Silvia>
-- Create date: <02/07/2014,,>
-- Description:	<Para la generacion de informes de clientes deudores,,>
-- =============================================
CREATE PROCEDURE [dbo].[ClientesCuentaCorrienteVencida] @fechadesde date,  @fechahasta date
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT c.Denominacion as Cliente,c.Cuit as DNI,c.Telefono as Teléfono, c.Mail AS Mail
	,ccc.Fecha AS FechaCompra
	, ccc.FechaVencimiento AS FechaVencimiento
	,Sum(ccc.Importe-ccc.Pagado) as Deuda
FROM ClientesCuentasCorriente ccc
INNER JOIN Clientes c
	ON c.Id= ccc.ClienteId
WHERE Pagado < Importe AND ccc.SucursalAltaId = 2
AND FechaVencimiento between @fechadesde and @fechahasta
GROUP BY ccc.ClienteId, c.Denominacion, c.Cuit, c.Telefono, c.Mail, Fecha
	,ccc.FechaVencimiento
ORDER BY c.Denominacion, Deuda DESC
END

