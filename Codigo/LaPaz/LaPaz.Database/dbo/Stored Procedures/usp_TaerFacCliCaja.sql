CREATE PROCEDURE [usp_TaerFacCliCaja] 
	@WhereCondition nvarchar(500),
	@OrderByExpression nvarchar(250) = NULL

AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED


DECLARE @SQL nvarchar(3250)

SET @SQL = '
SELECT DISTINCT f.FacSuc, f.FacId, f.Lcn, f.Fecha, f.Cpto, f.NcTotal,f.nTotal,f.nSena,f.nTotPag, cj.CajaSuc, cj.CajaId, cl.Denominacion
		      FROM (( s00FacVtaCab f  LEFT JOIN s00Clientes cl ON (f.CliSuc=cl.CodSuc And f.CliCuenta=cl.Cuenta ))  LEFT JOIN s00Caja cj 
		      ON (cj.CompTipo=f.nComp And cj.CompSuc=f.FacSuc And cj.CompId=f.FacId))' 
		      + @WhereCondition

IF @OrderByExpression IS NOT NULL AND LEN(@OrderByExpression) > 0
BEGIN
	SET @SQL = @SQL + '	ORDER BY ' + @OrderByExpression
END

EXEC sp_executesql @SQL
