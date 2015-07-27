CREATE PROCEDURE [dbo].[SP_GenerarReciboByNumero]
	@numeroRecibo char
AS
	select * from Recibos where Numero = @numeroRecibo