CREATE VIEW dbo.vOrdenPagoImpresion
AS
SELECT     dbo.OrdenesPago.Id AS OpId, dbo.OrdenesPago.SucursalId AS OpSuc, dbo.OrdenesPago.LCN AS OpLCN, dbo.OrdenesPago.Importe AS oImporte, 
                      dbo.OrdenesPago.ImportePagado AS oImpPag, dbo.Proveedores.Cuenta AS PrCuenta, dbo.OrdenesPago.SubTotal AS SubTot, 
                      dbo.OrdenesPago.Concepto, dbo.OrdenesPago.Recargo, dbo.Compras.SucursalAltaId AS FacSuc, dbo.Compras.Id AS FacId, dbo.Compras.LCN AS fLcn, 
                      dbo.Compras.FechaComprobante AS fFecha, dbo.ProveedoresCuentasCorriente.Cuota AS nCuota, 
                      dbo.ProveedoresCuentasCorriente.FechaVencimiento AS ccFVto, dbo.Proveedores.Denominacion AS cProv, dbo.Proveedores.Domicilio, 
                      dbo.Proveedores.Cuit, dbo.Localidades.Nombre AS cLoca, dbo.Localidades.CP, dbo.OrdenesPago.SucursalAltaId, 
                      dbo.OrdenesPagoComprobantes.Importe AS fImp, dbo.OrdenesPagoComprobantes.ImportePagado AS fImpPag, 
                      dbo.OrdenesPagoComprobantes.FechaAlta AS FPago
FROM         dbo.Localidades INNER JOIN
                      dbo.OrdenesPago INNER JOIN
                      dbo.Proveedores ON dbo.OrdenesPago.ProveedorId = dbo.Proveedores.Id ON dbo.Localidades.Id = dbo.Proveedores.LocalidadId LEFT OUTER JOIN
                      dbo.ProveedoresCuentasCorriente INNER JOIN
                      dbo.OrdenesPagoComprobantes ON dbo.ProveedoresCuentasCorriente.Id = dbo.OrdenesPagoComprobantes.ProveedorCuentaCorrienteId INNER JOIN
                      dbo.Compras ON dbo.ProveedoresCuentasCorriente.CompraId = dbo.Compras.Id ON 
                      dbo.OrdenesPago.Id = dbo.OrdenesPagoComprobantes.OrdenPagoId

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
         Configuration = "(H (1[55] 4[19] 3) )"
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
      ActivePaneConfig = 1
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Localidades"
            Begin Extent = 
               Top = 14
               Left = 784
               Bottom = 129
               Right = 979
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "OrdenesPago"
            Begin Extent = 
               Top = 0
               Left = 326
               Bottom = 190
               Right = 521
            End
            DisplayFlags = 280
            TopColumn = 11
         End
         Begin Table = "Proveedores"
            Begin Extent = 
               Top = 32
               Left = 551
               Bottom = 195
               Right = 746
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ProveedoresCuentasCorriente"
            Begin Extent = 
               Top = 196
               Left = 316
               Bottom = 366
               Right = 511
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "OrdenesPagoComprobantes"
            Begin Extent = 
               Top = 106
               Left = 10
               Bottom = 287
               Right = 231
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Compras"
            Begin Extent = 
               Top = 205
               Left = 571
               Bottom = 320
               Right = 766
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
      PaneHidden = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 25
  ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vOrdenPagoImpresion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'       Width = 284
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vOrdenPagoImpresion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vOrdenPagoImpresion';

