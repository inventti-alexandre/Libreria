CREATE VIEW dbo.vClientesCuentasCorriente
AS
SELECT     TOP (100) PERCENT dbo.ClientesCuentasCorriente.Cuota AS nCuota, dbo.ClientesCuentasCorriente.Fecha, 
                      dbo.ClientesCuentasCorriente.FechaVencimiento AS fvto, dbo.ClientesCuentasCorriente.Importe AS Importe, 
                      dbo.ClientesCuentasCorriente.Pagado AS Imppag, dbo.ClientesCuentasCorriente.FechaGeneracion AS fegr, dbo.Ventas.LCN AS flcn, 
                      dbo.Sucursales.Nombre AS Sucgr, dbo.Operadores.Usuario AS opegr, dbo.Clientes.Denominacion AS Denominacion, dbo.Clientes.Id AS ClienteId, 
                      dbo.ClientesCuentasCorriente.VentaId, dbo.ClientesCuentasCorriente.Id
FROM         dbo.Operadores INNER JOIN
                      dbo.Ventas ON dbo.Operadores.Id = dbo.Ventas.OperadorAltaId INNER JOIN
                      dbo.Sucursales ON dbo.Ventas.SucursalAltaId = dbo.Sucursales.Id RIGHT OUTER JOIN
                      dbo.ClientesCuentasCorriente ON dbo.Ventas.Id = dbo.ClientesCuentasCorriente.VentaId LEFT OUTER JOIN
                      dbo.Clientes ON dbo.ClientesCuentasCorriente.ClienteId = dbo.Clientes.Id
ORDER BY dbo.ClientesCuentasCorriente.VentaId, nCuota

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[45] 4[26] 2[17] 3) )"
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
         Begin Table = "Operadores"
            Begin Extent = 
               Top = 218
               Left = 844
               Bottom = 333
               Right = 1039
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Ventas"
            Begin Extent = 
               Top = 95
               Left = 454
               Bottom = 210
               Right = 649
            End
            DisplayFlags = 280
            TopColumn = 17
         End
         Begin Table = "Sucursales"
            Begin Extent = 
               Top = 57
               Left = 807
               Bottom = 172
               Right = 1002
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ClientesCuentasCorriente"
            Begin Extent = 
               Top = 13
               Left = 223
               Bottom = 224
               Right = 413
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Clientes"
            Begin Extent = 
               Top = 0
               Left = 0
               Bottom = 205
               Right = 174
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
      Begin ColumnWidths = 20
         Width = 284
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
         Width = 1500
         Wid', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientesCuentasCorriente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'th = 1500
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
         Alias = 2880
         Table = 2880
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientesCuentasCorriente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientesCuentasCorriente';

