create PROCEDURE [dbo].[usp_SeleccionarAutores]
	@Todo as nvarchar(1),
	@Nombre nvarchar(50)

AS

SET NOCOUNT OFF


SELECT *
   FROM  Autores Au 

WHERE (Au.Nombre LIKE @Todo +  @Nombre + '%')
ORDER BY Au.Nombre
