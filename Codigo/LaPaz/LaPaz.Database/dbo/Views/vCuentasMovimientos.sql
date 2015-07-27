CREATE VIEW dbo.vCuentasMovimientos
AS
SELECT     dbo.TiposMovimientoBancario.Nombre AS TipoMovimientoNombre, dbo.CuentasMovimientos.Id, dbo.CuentasMovimientos.CuentaId, 
                      dbo.CuentasMovimientos.TipoMovimientoId, dbo.CuentasMovimientos.FechaMovimiento, dbo.CuentasMovimientos.EstadoMovimientoCuentaId, 
                      dbo.CuentasMovimientos.TipoComprobanteId, dbo.CuentasMovimientos.ComprobanteId, dbo.CuentasMovimientos.MonedaId, 
                      dbo.CuentasMovimientos.CondicionVentaId, dbo.CuentasMovimientos.NroMovimiento, dbo.CuentasMovimientos.FechaCobro, 
                      dbo.CuentasMovimientos.Descripcion, dbo.CuentasMovimientos.Debito, dbo.CuentasMovimientos.Credito, 
                      dbo.CuentasMovimientos.ResumenConciliacion, dbo.CuentasMovimientos.FechaConciliacion, dbo.CuentasMovimientos.TipoCarga, 
                      dbo.CuentasMovimientos.CajaId, dbo.CuentasMovimientos.FechaAlta, dbo.CuentasMovimientos.OperadorAltaId, 
                      dbo.CuentasMovimientos.SucursalAltaId, dbo.CuentasMovimientos.FechaModificacion, dbo.CuentasMovimientos.OperadorModificacionId, 
                      dbo.CuentasMovimientos.SucursalModificacionId, dbo.BancosPropios.Cuenta
FROM         dbo.BancosPropios RIGHT OUTER JOIN
                      dbo.Cuentas ON dbo.BancosPropios.Id = dbo.Cuentas.BancoPropioId RIGHT OUTER JOIN
                      dbo.CuentasMovimientos LEFT OUTER JOIN
                      dbo.TiposMovimientoBancario ON dbo.CuentasMovimientos.TipoMovimientoId = dbo.TiposMovimientoBancario.Id ON 
                      dbo.Cuentas.Id = dbo.CuentasMovimientos.CuentaId

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[12] 2[30] 3) )"
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
         Begin Table = "CuentasMovimientos"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 251
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TiposMovimientoBancario"
            Begin Extent = 
               Top = 6
               Left = 289
               Bottom = 121
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BancosPropios"
            Begin Extent = 
               Top = 6
               Left = 522
               Bottom = 121
               Right = 717
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cuentas"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 241
               Right = 233
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
         Or = 1350', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vCuentasMovimientos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vCuentasMovimientos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vCuentasMovimientos';

