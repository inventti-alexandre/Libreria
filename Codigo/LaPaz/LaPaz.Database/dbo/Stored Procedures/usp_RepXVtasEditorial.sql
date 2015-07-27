CREATE PROCEDURE [usp_RepXVtasEditorial]
	@WhereCondition nvarchar(500),
	@OrderByExpression nvarchar(250) = NULL
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED

DECLARE @SQL nvarchar(3250)

/*Borro la tabla temporal*/
DELETE FROM REP_VTAS_EDIT

/*Creo la consulta para agregar registros a la tabla temporal*/
SET @SQL = 'INSERT INTO REP_VTAS_EDIT
	          SELECT li.nEditorial As CodTipo, Min(e.cDescrip) As Desc1 , Min(e.cDescrip) As Desc2,  li.Cod, Min(li.Titulo) As Titulo, Min(li.Autor) As Autor, 
	          Sum(fd.CntPr) As vp, Sum(fd.CntCn) As vc 
	          FROM (((  s00FacVtaDet fd  LEFT JOIN s00FacVtaCab fc 
	          ON (fd.FacSuc=fc.FacSuc And fd.FacId=fc.FacId ))  LEFT JOIN s00Libros  li  ON (fd.Codigo=li.Cod )) 
                        LEFT JOIN s00Tablas e  ON (e.knCodGen=3 And li.nEditorial=e.knCodInd  ))  WHERE ' + @WhereCondition +
                        ' GROUP BY li.nEditorial, li.Cod ' 

/*Ejecuto consulta para agregar registros a la tabla temporal*/
EXEC sp_executesql @SQL

/*Creo la consulta para seleccionar registros a la tabla temporal*/
SELECT * FROM REP_VTAS_EDIT ORDER BY Desc1, Titulo
