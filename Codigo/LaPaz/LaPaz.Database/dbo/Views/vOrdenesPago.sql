CREATE VIEW dbo.vOrdenesPago
AS
SELECT     dbo.OrdenesPago.Id, dbo.OrdenesPago.SucursalId, dbo.OrdenesPago.Fecha, dbo.OrdenesPago.LCN, dbo.OrdenesPago.TipoGastoId, 
                      dbo.OrdenesPago.ProveedorId, dbo.OrdenesPago.Concepto, dbo.OrdenesPago.RegistraIVACompra, dbo.OrdenesPago.SucursalGastoId, 
                      dbo.OrdenesPago.CentroCostoId, dbo.OrdenesPago.TipoComprobanteId, dbo.OrdenesPago.FechaImputacion, dbo.OrdenesPago.LetraComprobante, 
                      dbo.OrdenesPago.NumeroComprobante, dbo.OrdenesPago.SubTotal, dbo.OrdenesPago.Recargo, dbo.OrdenesPago.Importe, 
                      dbo.OrdenesPago.ImportePagado, dbo.OrdenesPago.FechaAnulacion, dbo.OrdenesPago.RemitoAnticipadoId, dbo.OrdenesPago.SucursalAltaId, 
                      dbo.OrdenesPago.FechaAlta, dbo.OrdenesPago.OperadorAltaId, dbo.OrdenesPago.FechaModificacion, dbo.OrdenesPago.OperadorModificacionId, 
                      dbo.OrdenesPago.SucursalModificacionId, dbo.Proveedores.Cuenta AS PrCuenta, dbo.Proveedores.Denominacion AS cBenef, 
                      dbo.Operadores.Usuario AS Operador, dbo.Proveedores.Cuit, dbo.OrdenesPagoDetalle.FechaPago, dbo.OrdenesPagoDetalle.Efectivo, 
                      dbo.OrdenesPagoDetalle.Cheques, dbo.OrdenesPagoDetalle.Deposito, dbo.OrdenesPagoDetalle.DepositoEfectivo, 
                      dbo.OrdenesPagoDetalle.Id AS OrdenPagoDetalleId, dbo.OrdenesPagoDetalle.NumeroLinea
FROM         dbo.OrdenesPago LEFT OUTER JOIN
                      dbo.OrdenesPagoDetalle ON dbo.OrdenesPago.Id = dbo.OrdenesPagoDetalle.OrdenPagoId LEFT OUTER JOIN
                      dbo.Operadores ON dbo.OrdenesPago.OperadorAltaId = dbo.Operadores.Id LEFT OUTER JOIN
                      dbo.Proveedores ON dbo.OrdenesPago.ProveedorId = dbo.Proveedores.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[21] 4[4] 2[40] 3) )"
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
         Begin Table = "OrdenesPago"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 210
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "OrdenesPagoDetalle"
            Begin Extent = 
               Top = 6
               Left = 271
               Bottom = 121
               Right = 466
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Operadores"
            Begin Extent = 
               Top = 6
               Left = 504
               Bottom = 121
               Right = 699
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Proveedores"
            Begin Extent = 
               Top = 148
               Left = 561
               Bottom = 263
               Right = 756
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
      Begin ColumnWidths = 38
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
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
    ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vOrdenesPago';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'     Width = 1500
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
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vOrdenesPago';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vOrdenesPago';

