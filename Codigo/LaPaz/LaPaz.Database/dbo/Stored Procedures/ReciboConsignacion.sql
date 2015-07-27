
CREATE PROCEDURE dbo.ReciboConsignacion
	@ConsignacionId UNIQUEIDENTIFIER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT 
		Codigo = T.Cod,
		Cantidad = (ISNULL(RVD.CntPr,0) + ISNULL(RVD.CntCn,0)),
		Descripcion = T.NombreTitulo,
		PrecioUnitario = RVD.PrecioVenta,
		Descuento = RVD.Descuento,
		Importe = (ISNULL(RVD.CntPr,0) + ISNULL(RVD.CntCn,0)) * RVD.PrecioVenta
	FROM RemitosVenta RV INNER JOIN RemitosVentaDetalle RVD
		ON RV.Id = RVD.RemitoVentaId INNER JOIN Titulos T
		ON RVD.TituloId = T.Id
	WHERE RV.Id = @ConsignacionId
   
END