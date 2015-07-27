CREATE PROCEDURE [usp_RepXVtasProveedor]
	@WhereCondition nvarchar(500),
	@OrderByExpression nvarchar(250) = NULL
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED

DECLARE @SQL nvarchar(3250)

/*Borro la tabla temporal*/
DELETE FROM REP_VTAS_PROV

/*Creo la consulta para agregar registros a la tabla temporal*/
SET @SQL = 'INSERT INTO REP_VTAS_PROV
	         SELECT     TOP 100 PERCENT l.nProv AS CodTipo, MIN(p.Denominacion) AS Desc1, 
                      MIN(p.Domicilio) AS Desc2, l.Cod, MIN(l.Titulo) AS Titulo, MIN(l.Autor) AS Autor, 
                      SUM(fd.CntPr) AS vp, SUM(fd.CntCn) AS vc
	         FROM dbo.s00Prov p RIGHT OUTER JOIN
                      dbo.s00Libros l ON p.Cuenta = l.nProv RIGHT OUTER JOIN
                      dbo.s00FacVtaDet fd ON l.Cod = fd.codigo RIGHT OUTER JOIN
                      dbo.s00FacVtaCab fc ON fd.FacSuc = fc.FacSuc AND fd.FacId = fc.FacId
	         WHERE ' + @WhereCondition + 
	          ' GROUP BY l.nProv, l.Cod' 

/*Ejecuto consulta para agregar registros a la tabla temporal*/
EXEC sp_executesql @SQL

/*Creo la consulta para seleccionar registros a la tabla temporal*/
SELECT * FROM REP_VTAS_PROV ORDER BY Desc1, Titulo
