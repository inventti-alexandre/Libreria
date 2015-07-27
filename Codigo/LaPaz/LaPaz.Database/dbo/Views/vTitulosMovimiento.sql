CREATE VIEW dbo.vTitulosMovimiento
AS
SELECT     TOP (100) PERCENT dbo.TitulosMovimiento.Id, dbo.TitulosMovimiento.TituloId, dbo.TitulosMovimiento.ComprobanteId, 
                      dbo.TitulosMovimiento.SucursalComprobante, dbo.TitulosMovimiento.Fecha, dbo.TitulosMovimiento.CntAntPr, dbo.TitulosMovimiento.CntAntCn, 
                      dbo.TitulosMovimiento.CntAddPr, dbo.TitulosMovimiento.CntAddCn, dbo.TitulosMovimiento.CntMinPr, dbo.TitulosMovimiento.CntMinCn, 
                      dbo.TitulosMovimiento.PC AS PcGr, dbo.TitulosMovimiento.FechaAlta AS FeGr, dbo.TitulosMovimiento.SucursalAltaId AS SucGr, dbo.Titulos.Cod, 
                      dbo.Sucursales.NombreCorto AS cCorto, dbo.Operadores.Usuario AS OpeGr, dbo.TiposComprobantes.Nombre AS cDescComprob, 
                      dbo.TitulosMovimiento.CntAddPr - dbo.TitulosMovimiento.CntMinPr AS CntDifPr, 
                      dbo.TitulosMovimiento.CntAddCn - dbo.TitulosMovimiento.CntMinCn AS CntDifCn, dbo.TitulosMovimiento.TipoComprobanteId, 
                      (CASE dbo.TitulosMovimiento.TipoComprobanteId WHEN 2 THEN
                          (SELECT     LCN
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 8 THEN
                          (SELECT     LCN
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 16 THEN
                          (SELECT     LCN
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 17 THEN
                          (SELECT     LCN
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 19 THEN
                          (SELECT     LCN
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 20 THEN
                          (SELECT     LCN
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 4 THEN
                          (SELECT     LCN
                            FROM          dbo.NotasDeVenta
                            WHERE      dbo.NotasDeVenta.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 5 THEN
                          (SELECT     LCN
                            FROM          dbo.Transferencias
                            WHERE      dbo.Transferencias.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 35 THEN
                          (SELECT     LCN
                            FROM          dbo.Transferencias
                            WHERE      dbo.Transferencias.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 36 THEN
                          (SELECT     LCN
                            FROM          dbo.Transferencias
                            WHERE      dbo.Transferencias.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 6 THEN
                          (SELECT     LCN
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 7 THEN
                          (SELECT     LCN
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 11 THEN
                          (SELECT     LCN
                            FROM          dbo.RemitosVenta
                            WHERE      dbo.RemitosVenta.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 12 THEN
                          (SELECT     LCN
                            FROM          dbo.RemitosVenta
                            WHERE      dbo.RemitosVenta.Id = dbo.TitulosMovimiento.ComprobanteId) END) AS LCN, 
                      (CASE dbo.TitulosMovimiento.TipoComprobanteId WHEN 2 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 8 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 16 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 17 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 19 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 20 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 4 THEN
                          (SELECT     FechaNotaVenta
                            FROM          dbo.NotasDeVenta
                            WHERE      dbo.NotasDeVenta.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 5 THEN
                          (SELECT     Fecha
                            FROM          dbo.Transferencias
                            WHERE      dbo.Transferencias.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 35 THEN
                          (SELECT     Fecha
                            FROM          dbo.Transferencias
                            WHERE      dbo.Transferencias.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 36 THEN
                          (SELECT     Fecha
                            FROM          dbo.Transferencias
                            WHERE      dbo.Transferencias.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 6 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 7 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 11 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.RemitosVenta
                            WHERE      dbo.RemitosVenta.Id = dbo.TitulosMovimiento.ComprobanteId) WHEN 12 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.RemitosVenta
                            WHERE      dbo.RemitosVenta.Id = dbo.TitulosMovimiento.ComprobanteId) END) AS CompFecha
FROM         dbo.Operadores RIGHT OUTER JOIN
                      dbo.Sucursales RIGHT OUTER JOIN
                      dbo.TitulosMovimiento LEFT OUTER JOIN
                      dbo.TiposComprobantes ON dbo.TitulosMovimiento.TipoComprobanteId = dbo.TiposComprobantes.Id ON 
                      dbo.Sucursales.Id = dbo.TitulosMovimiento.SucursalComprobante ON dbo.Operadores.Id = dbo.TitulosMovimiento.OperadorAltaId LEFT OUTER JOIN
                      dbo.Titulos ON dbo.TitulosMovimiento.TituloId = dbo.Titulos.Id
ORDER BY FeGr DESC

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[18] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
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
      ActivePaneConfig = 5
   End
   Begin DiagramPane = 
      PaneHidden = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Operadores"
            Begin Extent = 
               Top = 149
               Left = 62
               Bottom = 257
               Right = 256
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sucursales"
            Begin Extent = 
               Top = 25
               Left = 48
               Bottom = 140
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TitulosMovimiento"
            Begin Extent = 
               Top = 42
               Left = 411
               Bottom = 338
               Right = 606
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TiposComprobantes"
            Begin Extent = 
               Top = 135
               Left = 669
               Bottom = 243
               Right = 863
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Titulos"
            Begin Extent = 
               Top = 3
               Left = 671
               Bottom = 118
               Right = 866
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
      Begin ColumnWidths = 24
         Width = 284
         Width = 1500
         Width = 3495
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTitulosMovimiento';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'= 1500
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
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 3090
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTitulosMovimiento';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTitulosMovimiento';

