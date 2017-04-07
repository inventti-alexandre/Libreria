CREATE PROCEDURE [dbo].[SP_ClienteMontoFavorByLCN]
	@lcn nvarchar(13)
AS
	select top 1 cmf.FechaComprobante,Cmf.LCN, (cmf.Importe - cmf.ImpOcupado) as Importe, c.Denominacion, c.Domicilio, c.Cuit, tc.Descripcion
		FROM ClientesMontosFavor cmf
		INNER JOIN Clientes c
		ON c.id = cmf.ClienteId
		INNER JOIN TiposComprobantes tc
		on tc.id = cmf.TipoComprobanteId
		where cmf.LCN = @lcn
		order by cmf.FechaAlta desc
RETURN 0
