CREATE VIEW dbo.vProveedoresBultos
AS
SELECT     dbo.Proveedores.Denominacion, dbo.Transportes.Nombre AS cTransporte, dbo.ProveedoresBultos.Id, dbo.ProveedoresBultos.ProveedorId, 
                      dbo.ProveedoresBultos.Fecha, dbo.ProveedoresBultos.TransporteId, dbo.ProveedoresBultos.Cantidad AS cnt, 
                      dbo.ProveedoresBultos.Estado AS nEstado, dbo.ProveedoresBultos.Peso, dbo.ProveedoresBultos.OperadorAltaId, 
                      dbo.ProveedoresBultos.SucursalAltaId, dbo.ProveedoresBultos.FechaAlta, dbo.ProveedoresBultos.FechaModificacion, 
                      dbo.ProveedoresBultos.OperadorModificacionId, dbo.ProveedoresBultos.SucursalModificacionId, dbo.Proveedores.Cuenta, 
                      dbo.Operadores.Usuario AS OpeGr
FROM         dbo.ProveedoresBultos INNER JOIN
                      dbo.Operadores ON dbo.ProveedoresBultos.OperadorAltaId = dbo.Operadores.Id LEFT OUTER JOIN
                      dbo.Transportes ON dbo.ProveedoresBultos.TransporteId = dbo.Transportes.Id LEFT OUTER JOIN
                      dbo.Proveedores ON dbo.ProveedoresBultos.ProveedorId = dbo.Proveedores.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "ProveedoresBultos"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Transportes"
            Begin Extent = 
               Top = 6
               Left = 271
               Bottom = 121
               Right = 466
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Proveedores"
            Begin Extent = 
               Top = 6
               Left = 504
               Bottom = 121
               Right = 699
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Operadores"
            Begin Extent = 
               Top = 6
               Left = 737
               Bottom = 114
               Right = 931
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
      Begin ColumnWidths = 9
         Width = 284
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
         Or = 1350
         Or = 1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vProveedoresBultos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vProveedoresBultos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vProveedoresBultos';

