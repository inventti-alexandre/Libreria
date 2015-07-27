
CREATE VIEW [dbo].[vOperadoresVentasSuperioresaMil]
AS
SELECT     TOP (100) PERCENT dbo.Operadores.Usuario AS kcCodOpe, dbo.Operadores.SucursalAltaId AS CodSuc, dbo.Operadores.Id
FROM         dbo.Operadores RIGHT OUTER JOIN
                      dbo.OperadoresFunciones ON dbo.Operadores.Id = dbo.OperadoresFunciones.OperadorId LEFT OUTER JOIN
                      dbo.Funciones ON dbo.OperadoresFunciones.FuncionId = dbo.Funciones.Id
WHERE     (dbo.OperadoresFunciones.Permitido = 1) AND (dbo.Funciones.kccodfunc = '01M400P12004')
ORDER BY kcCodOpe
