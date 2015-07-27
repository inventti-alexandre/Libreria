
create PROCEDURE [dbo].[usp_SeleccionarProveedores]
	@Todo as nvarchar(1),
	@Cuenta int,
	@Denominacion nvarchar(50)

AS

SET NOCOUNT OFF
--SET TRANSACTION ISOLATION LEVEL READ COMMITTED

/*Creo la consulta para seleccionar registros a la tabla temporal*/
SELECT *
   FROM  Proveedores pr 

WHERE (pr.Denominacion LIKE @Todo +  @Denominacion + '%')
	AND (pr.cuenta= @Cuenta OR @Cuenta = 0)
ORDER BY pr.Denominacion

