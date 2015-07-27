CREATE VIEW dbo.InformeStockMinimo
AS
SELECT     TOP (100) PERCENT dbo.TitulosStock.StkPr, dbo.TitulosStock.StkCn, dbo.Titulos.PrecioVentaTitulo AS PrcVta1, dbo.Proveedores.Denominacion, 
                      dbo.TitulosStock.StkPr + dbo.TitulosStock.StkCn AS Stk, dbo.Titulos.StkMin, dbo.Titulos.FUltVta, dbo.Sucursales.Nombre AS cSuc, 
                      dbo.Titulos.NombreTitulo AS titulo, dbo.Sucursales.Id AS SucursalId, dbo.Titulos.Cod, dbo.Autores.Nombre AS Autor
FROM         dbo.Sucursales INNER JOIN
                      dbo.TitulosStock ON dbo.Sucursales.Id = dbo.TitulosStock.SucursalId RIGHT OUTER JOIN
                      dbo.Proveedores RIGHT OUTER JOIN
                      dbo.Autores RIGHT OUTER JOIN
                      dbo.Titulos ON dbo.Autores.Id = dbo.Titulos.AutorId ON dbo.Proveedores.Id = dbo.Titulos.ProveedorId ON 
                      dbo.TitulosStock.TituloId = dbo.Titulos.Id
WHERE     (dbo.TitulosStock.StkPr + dbo.TitulosStock.StkCn > dbo.Titulos.StkMin)
ORDER BY dbo.Proveedores.Denominacion, titulo

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[37] 2[4] 3) )"
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
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Sucursales"
            Begin Extent = 
               Top = 138
               Left = 456
               Bottom = 253
               Right = 651
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TitulosStock"
            Begin Extent = 
               Top = 2
               Left = 685
               Bottom = 117
               Right = 880
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Proveedores"
            Begin Extent = 
               Top = 21
               Left = 20
               Bottom = 136
               Right = 215
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Autores"
            Begin Extent = 
               Top = 156
               Left = 186
               Bottom = 271
               Right = 381
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Titulos"
            Begin Extent = 
               Top = 0
               Left = 407
               Bottom = 115
               Right = 602
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2085
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'InformeStockMinimo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'= 11
         Column = 3885
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 2205
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'InformeStockMinimo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'InformeStockMinimo';

