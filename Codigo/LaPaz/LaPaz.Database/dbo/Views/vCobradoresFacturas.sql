CREATE VIEW dbo.vCobradoresFacturas
AS
SELECT     dbo.CobradoresFacturas.Id, dbo.CobradoresFacturas.CobradorId AS nCobrador, dbo.CobradoresFacturas.VentaId, dbo.CobradoresFacturas.FechaAlta, 
                      dbo.CobradoresFacturas.OperadorAltaId, dbo.CobradoresFacturas.SucursalAltaId, dbo.CobradoresFacturas.FechaModificacion, 
                      dbo.CobradoresFacturas.OperadorModificacionId, dbo.CobradoresFacturas.SucursalModificacionId, dbo.Clientes.Denominacion AS CliDenominacion, 
                      dbo.Cobradores.Nombre AS Cobrador, dbo.CobradoresFacturas.FechaAsignacion, dbo.CobradoresFacturas.OperadorAsignoId, 
                      dbo.CobradoresFacturas.FechaRetiro AS FRetiro, dbo.CobradoresFacturas.OperadorRetiroId, dbo.Ventas.LCN AS FacLcn, 
                      dbo.Ventas.ImporteNeto AS FacnTotal, dbo.Ventas.FechaComprobante AS FacFecha, dbo.Ventas.SucursalAltaId AS FacSuc, 
                      dbo.Ventas.NumeroComprobante AS FacId
FROM         dbo.Cobradores RIGHT OUTER JOIN
                      dbo.Clientes RIGHT OUTER JOIN
                      dbo.Ventas RIGHT OUTER JOIN
                      dbo.CobradoresFacturas ON dbo.Ventas.Id = dbo.CobradoresFacturas.VentaId ON dbo.Clientes.Id = dbo.Ventas.ClienteId ON 
                      dbo.Cobradores.Id = dbo.CobradoresFacturas.CobradorId

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
         Begin Table = "Cobradores"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 114
               Right = 232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Clientes"
            Begin Extent = 
               Top = 6
               Left = 270
               Bottom = 114
               Right = 464
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ventas"
            Begin Extent = 
               Top = 6
               Left = 502
               Bottom = 114
               Right = 696
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CobradoresFacturas"
            Begin Extent = 
               Top = 6
               Left = 734
               Bottom = 114
               Right = 928
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
         Or = 1350
         Or = 1350', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vCobradoresFacturas';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vCobradoresFacturas';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vCobradoresFacturas';

