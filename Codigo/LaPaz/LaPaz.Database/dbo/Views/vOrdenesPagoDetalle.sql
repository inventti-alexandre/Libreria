CREATE VIEW dbo.vOrdenesPagoDetalle
AS
SELECT     dbo.OrdenesPagoDetalle.Id, dbo.OrdenesPagoDetalle.OrdenPagoId, dbo.OrdenesPagoDetalle.NumeroLinea, dbo.OrdenesPagoDetalle.FechaPago, 
                      dbo.OrdenesPagoDetalle.Descuento, dbo.OrdenesPagoDetalle.ImportePagado, dbo.OrdenesPagoDetalle.Efectivo, dbo.OrdenesPagoDetalle.Cheques, 
                      dbo.OrdenesPagoDetalle.Deposito, dbo.OrdenesPagoDetalle.DepositoEfectivo, dbo.OrdenesPagoDetalle.FechaAnulacion, 
                      dbo.OrdenesPagoDetalle.SucursalAltaId, dbo.OrdenesPagoDetalle.FechaAlta, dbo.OrdenesPagoDetalle.OperadorAltaId, 
                      dbo.OrdenesPagoDetalle.FechaModificacion, dbo.OrdenesPagoDetalle.OperadorModificacionId, dbo.OrdenesPagoDetalle.SucursalModificacionId, 
                      dbo.OrdenesPago.SucursalId, dbo.OrdenesPago.OperadorAltaId AS OperadorId, dbo.Operadores.Usuario
FROM         dbo.Operadores RIGHT OUTER JOIN
                      dbo.OrdenesPagoDetalle ON dbo.Operadores.Id = dbo.OrdenesPagoDetalle.OperadorAltaId LEFT OUTER JOIN
                      dbo.OrdenesPago ON dbo.OrdenesPagoDetalle.OrdenPagoId = dbo.OrdenesPago.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[32] 4[4] 2[46] 3) )"
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
               Top = 6
               Left = 271
               Bottom = 121
               Right = 466
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "OrdenesPagoDetalle"
            Begin Extent = 
               Top = 15
               Left = 499
               Bottom = 130
               Right = 694
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "OrdenesPago"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
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
      Begin ColumnWidths = 21
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
  ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vOrdenesPagoDetalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'       Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vOrdenesPagoDetalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vOrdenesPagoDetalle';

