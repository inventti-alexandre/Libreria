

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_SeleccionarTitulosStock]
	-- Add the parameters for the stored procedure here
	@Id as Uniqueidentifier	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT     dbo.TitulosStock.SucursalId AS CodSuc, dbo.TitulosStock.StkPr, dbo.TitulosStock.StkCn, dbo.TitulosStock.FechaAlta AS FeGr, 
                      dbo.TitulosStock.SucursalAltaId AS SucGr, dbo.TitulosStock.OperadorAltaId AS OpeGr, dbo.Sucursales.NombreCorto AS cCorto,
                          (SELECT     Stock
                            FROM          dbo.TitulosStockAuditado
                            WHERE      (TituloId = dbo.TitulosStock.TituloId) AND (SucursalId = dbo.TitulosStock.SucursalId)) AS CntAud, dbo.TitulosStock.TituloId
     FROM         dbo.Sucursales RIGHT OUTER JOIN
                      dbo.TitulosStock ON dbo.Sucursales.Id = dbo.TitulosStock.SucursalId
    WHERE dbo.TitulosStock.TituloId = @Id
END


