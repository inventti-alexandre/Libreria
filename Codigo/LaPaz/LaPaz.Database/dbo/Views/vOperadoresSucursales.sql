﻿CREATE VIEW dbo.vOperadoresSucursales
AS
SELECT     dbo.OperadorSucursal.SucursalId, dbo.Sucursales.Nombre AS SucursalNombre, dbo.Personal.Nombre, dbo.Operadores.Id, dbo.Operadores.Usuario, 
                      dbo.Operadores.Clave, dbo.Operadores.VigenteDesde, dbo.Operadores.VigenteHasta, dbo.Operadores.PersonalId, dbo.Operadores.FechaAlta, 
                      dbo.Operadores.SucursalAltaId, dbo.Operadores.OperadorAltaId, dbo.Operadores.FechaModificacion, dbo.Operadores.OperadorModificacionId, 
                      dbo.Operadores.SucursalModificacionId
FROM         dbo.OperadorSucursal INNER JOIN
                      dbo.Operadores ON dbo.OperadorSucursal.OperadorId = dbo.Operadores.Id LEFT OUTER JOIN
                      dbo.Personal ON dbo.Operadores.PersonalId = dbo.Personal.Id LEFT OUTER JOIN
                      dbo.Sucursales ON dbo.OperadorSucursal.SucursalId = dbo.Sucursales.Id
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[27] 4[4] 2[39] 3) )"
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
         Begin Table = "Sucursales"
            Begin Extent = 
               Top = 59
               Left = 616
               Bottom = 174
               Right = 811
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "OperadorSucursal"
            Begin Extent = 
               Top = 95
               Left = 359
               Bottom = 210
               Right = 554
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Operadores"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 207
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Personal"
            Begin Extent = 
               Top = 174
               Left = 592
               Bottom = 289
               Right = 787
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
      Begin ColumnWidths = 10
         Width = 284
         Width = 3465
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
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or =', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vOperadoresSucursales';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vOperadoresSucursales';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vOperadoresSucursales';

