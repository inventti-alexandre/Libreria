

CREATE PROCEDURE [dbo].[usp_SeleccionarClientes]
	@Todo as nvarchar(1),
	@NroDocumento nvarchar(11),
	@Denominacion nvarchar(80),
	@Estado as Integer

AS

SET NOCOUNT OFF
--SET TRANSACTION ISOLATION LEVEL READ COMMITTED

/*Creo la consulta para seleccionar registros a la tabla temporal*/
SELECT *
 FROM  Clientes cl
WHERE (cl.Denominacion LIKE @Todo +  @Denominacion + '%')
	AND (cl.Cuit like  @NroDocumento + '%') AND (cl.EstadoClienteId=@Estado OR @Estado = -1)
 ORDER BY cl.Denominacion



