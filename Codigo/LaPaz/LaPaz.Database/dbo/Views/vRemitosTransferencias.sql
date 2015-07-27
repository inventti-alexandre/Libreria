CREATE VIEW dbo.vRemitosTransferencias
AS
SELECT DISTINCT 
                      TOP (100) PERCENT dbo.Transferencias.Id, dbo.Transferencias.SucursalId, dbo.Transferencias.Numero, dbo.Transferencias.LCN, 
                      dbo.Transferencias.CodSucDest, dbo.Transferencias.Fecha, dbo.Transferencias.Concepto, dbo.Transferencias.Obs, dbo.Transferencias.FAnula, 
                      dbo.Transferencias.FRecibe, dbo.Transferencias.FechaAlta, dbo.Transferencias.SucursalAltaId, dbo.Transferencias.OperadorAltaId, 
                      dbo.Transferencias.FechaModificacion, dbo.Transferencias.SucursalModificacionId, dbo.Transferencias.OperadorModificacionId, 
                      SUBSTRING(dbo.Transferencias.LCN, 2, 4) + ' - ' + SUBSTRING(dbo.Transferencias.LCN, 6, 8) AS cLcn, dbo.Sucursales.NombreCorto AS cSuc1, 
                      Sucursales_1.NombreCorto AS cSuc2
FROM         dbo.Sucursales INNER JOIN
                      dbo.Transferencias ON dbo.Sucursales.Id = dbo.Transferencias.SucursalId INNER JOIN
                      dbo.Sucursales AS Sucursales_1 ON dbo.Transferencias.CodSucDest = Sucursales_1.Id INNER JOIN
                      dbo.TransferenciasDetalle ON dbo.Transferencias.Id = dbo.TransferenciasDetalle.TransferenciaId
ORDER BY dbo.Transferencias.Fecha DESC

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
         Begin Table = "Transferencias"
            Begin Extent = 
               Top = 52
               Left = 579
               Bottom = 315
               Right = 773
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sucursales_1"
            Begin Extent = 
               Top = 166
               Left = 257
               Bottom = 274
               Right = 451
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sucursales"
            Begin Extent = 
               Top = 27
               Left = 249
               Bottom = 135
               Right = 443
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TransferenciasDetalle"
            Begin Extent = 
               Top = 54
               Left = 891
               Bottom = 277
               Right = 1085
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
      ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vRemitosTransferencias';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'   Alias = 900
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vRemitosTransferencias';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vRemitosTransferencias';

