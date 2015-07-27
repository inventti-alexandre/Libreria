CREATE PROCEDURE [usp_RepXVtasClientes]
	@WhereCondition nvarchar(500),
	@OrderByExpression nvarchar(250) = NULL
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED

DECLARE @SQL nvarchar(3250)

/*Borro la tabla temporal*/
DELETE FROM REP_VTAS_CTES

/*Creo la consulta para agregar registros a la tabla temporal*/
SET @SQL =	'INSERT INTO REP_VTAS_CTES
		SELECT cl.CodSuc, cl.Cuenta,  Min(cl.cuit) As CodTipo, Min(cl.Denominacion) As Desc1 , Min(cl.Domicilio) As Desc2, 
		Min(l.Cod) As Cod ,Min(l.Titulo) As Titulo, Min(l.Autor) As Autor,  Sum(fd.CntPr) As vp, Sum(fd.CntCn) As vc 			
		FROM (((  s00FacVtaDet fd  LEFT JOIN s00FacVtaCab fc ON (fd.FacSuc=fc.FacSuc And fd.FacId=fc.FacId )) 
               	LEFT JOIN s00Libros l ON (fd.Codigo=l.Cod ))  LEFT JOIN s00Clientes  cl ON (cl.CodSuc=fc.CliSuc And cl.Cuenta=fc.CliCuenta)) 
               	WHERE ' + @WhereCondition + ' GROUP BY cl.CodSuc, cl.Cuenta, l.Cod  HAVING min(cl.denominacion) >"" '		


/*Ejecuto consulta para agregar registros a la tabla temporal*/
EXEC sp_executesql @SQL

/*Creo la consulta para seleccionar registros a la tabla temporal*/
SELECT * FROM REP_VTAS_CTES ORDER BY Desc1, Titulo
