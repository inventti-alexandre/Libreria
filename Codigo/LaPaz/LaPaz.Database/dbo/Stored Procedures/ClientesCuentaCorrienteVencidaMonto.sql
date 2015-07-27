
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ClientesCuentaCorrienteVencidaMonto] @montodesde real,  @montohasta real
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT c.Denominacion as Cliente,c.Cuit as DNI,c.Telefono as Teléfono, c.Mail AS Mail
	,Sum(ccc.Importe-ccc.Pagado) as Deuda
	FROM ClientesCuentasCorriente ccc
	INNER JOIN Clientes c
		ON c.Id= ccc.ClienteId
	WHERE Pagado < Importe AND ccc.SucursalAltaId = 2
	GROUP BY ccc.ClienteId, c.Denominacion, c.Cuit, c.Telefono, c.Mail
	having Sum(ccc.Importe-ccc.Pagado) between @montodesde and @montohasta
	ORDER BY c.Denominacion, Deuda DESC
END

