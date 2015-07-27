﻿CREATE VIEW dbo.vInformeStock
AS
SELECT     TOP (100) PERCENT dbo.Titulos.Cod, dbo.TitulosStock.StkPr, dbo.TitulosStock.StkCn, dbo.TitulosStock.FechaModificacion AS FeGr, 
                      dbo.Operadores.Usuario AS Opegr, dbo.Titulos.NombreTitulo AS Titulo, dbo.Autores.Nombre AS Autor, dbo.TitulosStockAuditado.Stock AS CntAud, 
                      dbo.Titulos.PrecioVentaTitulo AS PrcVta1, dbo.Sucursales.Nombre AS csuc, dbo.Proveedores.Denominacion, 
                      dbo.TitulosStock.StkPr + dbo.TitulosStock.StkCn AS Stk, dbo.Sucursales.Id AS SucursalId, dbo.TitulosStock.TituloId, dbo.Titulos.TemaId
FROM         dbo.TitulosStockAuditado RIGHT OUTER JOIN
                      dbo.TitulosStock ON dbo.TitulosStockAuditado.SucursalId = dbo.TitulosStock.SucursalId AND 
                      dbo.TitulosStockAuditado.TituloId = dbo.TitulosStock.TituloId RIGHT OUTER JOIN
                      dbo.Titulos ON dbo.TitulosStock.TituloId = dbo.Titulos.Id LEFT OUTER JOIN
                      dbo.Autores ON dbo.Titulos.AutorId = dbo.Autores.Id LEFT OUTER JOIN
                      dbo.Sucursales ON dbo.TitulosStock.SucursalId = dbo.Sucursales.Id LEFT OUTER JOIN
                      dbo.Operadores ON dbo.TitulosStock.OperadorModificacionId = dbo.Operadores.Id LEFT OUTER JOIN
                      dbo.Proveedores ON dbo.Titulos.ProveedorId = dbo.Proveedores.Id
WHERE     (dbo.TitulosStock.StkPr + dbo.TitulosStock.StkCn > 0)
ORDER BY dbo.Proveedores.Denominacion, Titulo, Autor

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[47] 4[25] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TitulosStockAuditado"
            Begin Extent = 
               Top = 0
               Left = 795
               Bottom = 115
               Right = 990
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "TitulosStock"
            Begin Extent = 
               Top = 37
               Left = 514
               Bottom = 152
               Right = 709
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Titulos"
            Begin Extent = 
               Top = 102
               Left = 293
               Bottom = 217
               Right = 488
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Autores"
            Begin Extent = 
               Top = 165
               Left = 28
               Bottom = 280
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sucursales"
            Begin Extent = 
               Top = 111
               Left = 833
               Bottom = 226
               Right = 1028
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Operadores"
            Begin Extent = 
               Top = 258
               Left = 816
               Bottom = 373
               Right = 1011
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Proveedores"
            Begin Extent = 
               Top = 13
               Left = 45
               Bottom = 128
               Right = 240
            End
 ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vInformeStock';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'           DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 2325
         Width = 1500
         Width = 1500
         Width = 2970
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3915
         Alias = 2880
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vInformeStock';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vInformeStock';

