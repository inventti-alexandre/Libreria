CREATE PROCEDURE [dbo].[SP_ClienteMontoFavorByLCN]
	@lcn nvarchar(13)
AS
		select cmf.FechaComprobante,Cmf.LCN, cmf.Importe, c.Denominacion, c.Domicilio, c.Cuit
		FROM ClientesMontosFavor cmf
		INNER JOIN Clientes c
		ON c.id = cmf.ClienteId
		INNER JOIN TiposComprobantes tc
		on tc.id = cmf.TipoComprobanteId
		where cmf.LCN = @lcn
RETURN 0


		