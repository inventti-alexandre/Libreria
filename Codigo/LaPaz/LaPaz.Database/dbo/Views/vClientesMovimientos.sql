
CREATE VIEW [dbo].[vClientesMovimientos]
AS
SELECT     TOP (100) PERCENT dbo.ClientesMovimiento.IdCliente AS ClienteId, dbo.ClientesMovimiento.IdTipoComprobante AS CompTipo, 
                      dbo.ClientesMovimiento.IdComprobante AS CompId, dbo.ClientesMovimiento.Concepto, dbo.ClientesMovimiento.Debe AS nDebe, 
                      dbo.ClientesMovimiento.Haber AS nHaber, (CASE dbo.ClientesMovimiento.IdTipoComprobante WHEN 4 THEN
                          (SELECT     FechaNotaVenta
                            FROM          dbo.NotasDeVenta
                            WHERE      dbo.NotasDeVenta.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 7 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 22 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 3 THEN
                          (SELECT     FechaPago
                            FROM          dbo.Recibos
                            WHERE      dbo.Recibos.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 11 THEN
                          (SELECT     FechaPago
                            FROM          dbo.Recibos
                            WHERE      dbo.Recibos.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 21 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.ClientesMontosFavor
                            WHERE      dbo.ClientesMontosFavor.Id = dbo.ClientesMovimiento.IdComprobante) END) AS Fecha, 
                      (CASE dbo.ClientesMovimiento.IdTipoComprobante WHEN 4 THEN
                          (SELECT     FechaNotaVenta
                            FROM          dbo.NotasDeVenta
                            WHERE      dbo.NotasDeVenta.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 3 THEN
                          (SELECT     FechaPago
                            FROM          dbo.Recibos
                            WHERE      dbo.Recibos.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 11 THEN
                          (SELECT     FechaPago
                            FROM          dbo.Recibos
                            WHERE      dbo.Recibos.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 7 THEN
                          (SELECT     FechaVencimiento
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 22 THEN
                          (SELECT     FechaVencimiento
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 21 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.ClientesMontosFavor
                            WHERE      dbo.ClientesMontosFavor.Id = dbo.ClientesMovimiento.IdComprobante) END) AS FVto, 
                      (CASE dbo.ClientesMovimiento.IdTipoComprobante WHEN 4 THEN
                          (SELECT     Concepto
                            FROM          dbo.NotasDeVenta
                            WHERE      dbo.NotasDeVenta.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 3 THEN
                          (SELECT     'Recibo Cobranza' AS Concepto
                            FROM          dbo.Recibos
                            WHERE      dbo.Recibos.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 11 THEN
                          (SELECT     'Recibo Cobranza' AS Concepto
                            FROM          dbo.Recibos
                            WHERE      dbo.Recibos.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 7 THEN
                          (SELECT     Concepto
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 22 THEN
                          (SELECT     Concepto
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 21 THEN
                          (SELECT     Concepto
                            FROM          dbo.ClientesMontosFavor
                            WHERE      dbo.ClientesMontosFavor.Id = dbo.ClientesMovimiento.IdComprobante) END) AS cDescComprob, 
                      (CASE dbo.ClientesMovimiento.IdTipoComprobante WHEN 4 THEN
                          (SELECT     LCN
                            FROM          dbo.NotasDeVenta
                            WHERE      dbo.NotasDeVenta.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 3 THEN
                          (SELECT     NUMERO
                            FROM          dbo.Recibos
                            WHERE      dbo.Recibos.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 11 THEN
                          (SELECT     NUMERO
                            FROM          dbo.Recibos
                            WHERE      dbo.Recibos.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 7 THEN
                          (SELECT     LCN
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 22 THEN
                          (SELECT     LCN
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 21 THEN
                          (SELECT     LCN
                            FROM          dbo.ClientesMontosFavor
                            WHERE      dbo.ClientesMontosFavor.Id = dbo.ClientesMovimiento.IdComprobante) END) AS LCN, 
                      (CASE dbo.ClientesMovimiento.IdTipoComprobante WHEN 4 THEN
                          (SELECT     SucursalAltaId
                            FROM          dbo.NotasDeVenta
                            WHERE      dbo.NotasDeVenta.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 3 THEN
                          (SELECT     SucursalAltaId
                            FROM          dbo.Recibos
                            WHERE      dbo.Recibos.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 11 THEN
                          (SELECT     SucursalAltaId
                            FROM          dbo.Recibos
                            WHERE      dbo.Recibos.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 7 THEN
                          (SELECT     SucursalAltaId
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 22 THEN
                          (SELECT     SucursalAltaId
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.ClientesMovimiento.IdComprobante) WHEN 21 THEN
                          (SELECT     SucursalAltaId
                            FROM          dbo.ClientesMontosFavor
                            WHERE      dbo.ClientesMontosFavor.Id = dbo.ClientesMovimiento.IdComprobante) END) AS CompSuc, 
                      dbo.ClientesMovimiento.Observaciones AS cComent, dbo.ClientesMovimiento.SucursalAltaId, dbo.Sucursales.NombreCorto AS SucursalAlta
FROM         dbo.ClientesMovimiento INNER JOIN
                      dbo.Sucursales ON dbo.ClientesMovimiento.SucursalAltaId = dbo.Sucursales.Id
--order by dbo.ClientesMovimiento.FechaGeneracion desc	

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[36] 2[4] 3) )"
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
         Configuration = "(H (4[32] 2[38] 3) )"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2[66] 3) )"
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
      ActivePaneConfig = 3
   End
   Begin DiagramPane = 
      PaneHidden = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ClientesMovimiento"
            Begin Extent = 
               Top = 11
               Left = 191
               Bottom = 324
               Right = 389
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sucursales"
            Begin Extent = 
               Top = 6
               Left = 427
               Bottom = 114
               Right = 621
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
      Begin ColumnWidths = 15
         Width = 284
         Width = 3195
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2325
         Width = 2715
         Width = 1740
         Width = 1500
         Width = 1875
         Width = 1725
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientesMovimientos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientesMovimientos';

