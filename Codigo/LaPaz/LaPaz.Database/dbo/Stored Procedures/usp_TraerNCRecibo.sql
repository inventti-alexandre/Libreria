CREATE PROCEDURE [usp_TraerNCRecibo]
	@WhereCondition nvarchar(500),
	@OrderByExpression nvarchar(250) = NULL
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED

DECLARE @SQL nvarchar(3250)

SET @SQL = 'SELECT DISTINCT fc.*,fd.* FROM ( s00FacVtaCab fc LEFT JOIN s00FacVtaDet fd ON (fc.FacSuc=fd.FacSuc And fc.FacId=fd.FacId)) ' 
	+ @WhereCondition

IF @OrderByExpression IS NOT NULL AND LEN(@OrderByExpression) > 0
BEGIN
	SET @SQL = @SQL + '
ORDER BY
	' + @OrderByExpression
END

EXEC sp_executesql @SQL
