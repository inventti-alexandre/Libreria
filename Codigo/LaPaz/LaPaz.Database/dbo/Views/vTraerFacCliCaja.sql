CREATE VIEW dbo.vTraerFacCliCaja
AS
SELECT     dbo.Ventas.SucursalAltaId AS FacSuc, dbo.Ventas.Id AS FacId, dbo.Ventas.LCN, dbo.Ventas.FechaComprobante AS Fecha, 
                      dbo.Ventas.Concepto AS Cpto, dbo.NotasDeVenta.ImporteNeto AS NcTotal, dbo.Ventas.ImporteNeto AS nTotal, dbo.Ventas.ImporteSena AS nSena, 
                      dbo.Ventas.TotalPagado AS nTotPag, dbo.CajasMovimientos.SucursalAltaId AS CajaSuc, dbo.CajasMovimientos.CajaId, dbo.Clientes.Denominacion, 
                      dbo.NotasDeVenta.Id AS NotadeVenta
FROM         dbo.Ventas INNER JOIN
                      dbo.Clientes ON dbo.Ventas.ClienteId = dbo.Clientes.Id INNER JOIN
                      dbo.CajasMovimientos ON dbo.Ventas.Id = dbo.CajasMovimientos.ComprobanteId LEFT OUTER JOIN
                      dbo.NotasDeVenta ON dbo.Ventas.Id = dbo.NotasDeVenta.ComprobanteId

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[45] 4[20] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[50] 4[25] 3) )"
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
         Begin Table = "Ventas"
            Begin Extent = 
               Top = 19
               Left = 312
               Bottom = 127
               Right = 506
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Clientes"
            Begin Extent = 
               Top = 10
               Left = 18
               Bottom = 118
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CajasMovimientos"
            Begin Extent = 
               Top = 5
               Left = 609
               Bottom = 113
               Right = 803
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NotasDeVenta"
            Begin Extent = 
               Top = 114
               Left = 544
               Bottom = 229
               Right = 739
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
      Begin ColumnWidths = 14
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
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1230
         Table = 2310
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTraerFacCliCaja';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTraerFacCliCaja';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTraerFacCliCaja';

