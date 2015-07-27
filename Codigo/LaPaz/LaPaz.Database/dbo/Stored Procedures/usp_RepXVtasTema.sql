CREATE PROCEDURE [usp_RepXVtasTema]
	@WhereCondition nvarchar(500),
	@OrderByExpression nvarchar(250) = NULL
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED

DECLARE @SQL nvarchar(3250)

/*Borro la tabla temporal*/
DELETE FROM REP_VTAS_TEMA

/*Creo la consulta para agregar registros a la tabla temporal*/
SET @SQL = 'INSERT INTO REP_VTAS_TEMA
	           SELECT l.nTema As CodTipo, Min(t.cDescrip) As Desc1 , "." As Desc2,  l.Cod ,Min(l.Titulo) As Titulo, Min(l.Autor) As Autor, 
                        Sum(fd.CntPr) As vp, Sum(fd.CntCn) As vc 	        
	           FROM (((  s00FacVtaDet fd LEFT JOIN s00FacVtaCab fc 
	           ON (fd.FacSuc=fc.FacSuc And fd.FacId=fc.FacId )) LEFT JOIN s00Libros l  ON (fd.Codigo=l.Cod )) 
                        LEFT JOIN s00Tablas t  ON (t.knCodGen=4 And l.nTema=t.knCodInd  )) WHERE ' + @WhereCondition +
                        'GROUP BY l.nTema, l.Cod ' 

/*Ejecuto consulta para agregar registros a la tabla temporal*/
EXEC sp_executesql @SQL

/*Creo la consulta para seleccionar registros a la tabla temporal*/
SELECT * FROM REP_VTAS_TEMA ORDER BY Desc1, Titulo
