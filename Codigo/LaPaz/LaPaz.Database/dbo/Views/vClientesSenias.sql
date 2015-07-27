CREATE VIEW dbo.vClientesSenias
AS
SELECT     TOP (100) PERCENT dbo.Clientes.Denominacion AS cCli, dbo.Clientes.Telefono, dbo.Clientes.Domicilio, dbo.Localidades.Nombre AS rLoca, 
                      dbo.ClientesMontosFavor.Importe, dbo.ClientesMontosFavor.ImpOcupado AS ImpOcup, dbo.Clientes.Id AS ClienteId, 
                      dbo.ClientesMontosFavor.Id AS FavId, dbo.ClientesMontosFavor.VentaId, dbo.ClientesMontosFavor.FechaAlta, 
                      dbo.ClientesMontosFavor.Concepto AS cpto, dbo.Clientes.EstadoClienteId, dbo.ClientesMontosFavor.LCN, 
                      dbo.ClientesMontosFavor.FechaComprobante AS Fecha
FROM         dbo.Clientes INNER JOIN
                      dbo.ClientesMontosFavor ON dbo.Clientes.Id = dbo.ClientesMontosFavor.ClienteId INNER JOIN
                      dbo.Localidades ON dbo.Clientes.LocalidadId = dbo.Localidades.Id
ORDER BY dbo.Clientes.FechaAlta

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
         Begin Table = "Clientes"
            Begin Extent = 
               Top = 8
               Left = 328
               Bottom = 286
               Right = 522
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "ClientesMontosFavor"
            Begin Extent = 
               Top = 0
               Left = 587
               Bottom = 308
               Right = 781
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Localidades"
            Begin Extent = 
               Top = 102
               Left = 69
               Bottom = 210
               Right = 263
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
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 2430
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 3240
         Width = 3240
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
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientesSenias';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientesSenias';

