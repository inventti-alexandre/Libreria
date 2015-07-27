CREATE VIEW dbo.vTarjetasMovimientos
AS
SELECT     dbo.TarjetasMovimientos.Id, dbo.TarjetasMovimientos.CajaMovimientoId, dbo.TarjetasMovimientos.TarjetaId, dbo.TarjetasMovimientos.BancoId, 
                      dbo.TarjetasMovimientos.TarjetaLiquidacionId, dbo.TarjetasMovimientos.LoteCupon, dbo.TarjetasMovimientos.Fecha, 
                      dbo.TarjetasMovimientos.Importe, dbo.TarjetasMovimientos.Estado, dbo.TarjetasMovimientos.NroInt, dbo.TarjetasMovimientos.FechaAlta, 
                      dbo.TarjetasMovimientos.OperadorAltaId, dbo.TarjetasMovimientos.SucursalAltaId, dbo.TarjetasMovimientos.FechaModificacion, 
                      dbo.TarjetasMovimientos.OperadorModificacionId, dbo.TarjetasMovimientos.SucursalModificacionId, dbo.Tarjetas.Nombre AS cTrj, 
                      dbo.Bancos.Nombre AS cBcoCta, dbo.Cajas.SucursalId AS CajaSuc, dbo.Cajas.OperadorId
FROM         dbo.Cajas RIGHT OUTER JOIN
                      dbo.CajasMovimientos ON dbo.Cajas.Id = dbo.CajasMovimientos.CajaId RIGHT OUTER JOIN
                      dbo.TarjetasMovimientos ON dbo.CajasMovimientos.Id = dbo.TarjetasMovimientos.CajaMovimientoId LEFT OUTER JOIN
                      dbo.Bancos ON dbo.TarjetasMovimientos.BancoId = dbo.Bancos.Id LEFT OUTER JOIN
                      dbo.Tarjetas ON dbo.TarjetasMovimientos.TarjetaId = dbo.Tarjetas.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[47] 4[24] 2[11] 3) )"
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
         Begin Table = "Cajas"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CajasMovimientos"
            Begin Extent = 
               Top = 6
               Left = 271
               Bottom = 121
               Right = 466
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TarjetasMovimientos"
            Begin Extent = 
               Top = 6
               Left = 504
               Bottom = 121
               Right = 699
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Bancos"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 241
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tarjetas"
            Begin Extent = 
               Top = 126
               Left = 271
               Bottom = 241
               Right = 466
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
         Colu', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTarjetasMovimientos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'mn = 1440
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTarjetasMovimientos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTarjetasMovimientos';

