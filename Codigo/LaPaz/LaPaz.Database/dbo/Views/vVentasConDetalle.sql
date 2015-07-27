CREATE VIEW [dbo].[vVentasConDetalle]
AS
SELECT     dbo.Ventas.ComprobanteId AS nComp, dbo.Ventas.TotalPagado AS nTotPag, dbo.Ventas.LCN, dbo.Ventas.FechaComprobante AS Fecha, 
                      dbo.Ventas.Concepto AS Cpto, dbo.Clientes.Denominacion, dbo.Ventas.ImporteNeto AS nTotal, dbo.Ventas.ImporteSena AS nSena, 0 AS NCTotal, 
                      dbo.Clientes.SucursalId AS CliSuc, dbo.Clientes.Cuenta AS CliCuenta, dbo.Titulos.Cod AS Codigo, dbo.Titulos.NombreTitulo AS DescLibro, 
                      dbo.Autores.Nombre AS Autor, dbo.VentasDetalle.CantidadPropia AS CntPr, dbo.VentasDetalle.CantidadConsig AS CntCn, 
                      dbo.VentasDetalle.Precio AS Prc, dbo.VentasDetalle.CantidadAuditada AS CntAud, dbo.Ventas.Id, dbo.VentasDetalle.Id AS VentaDetalleId, 
                      dbo.VentasDetalle.TituloId, dbo.Ventas.ClienteId
FROM         dbo.Ventas INNER JOIN
                      dbo.VentasDetalle ON dbo.Ventas.Id = dbo.VentasDetalle.VentaId INNER JOIN
                      dbo.Clientes ON dbo.Ventas.ClienteId = dbo.Clientes.Id INNER JOIN
                      dbo.Titulos ON dbo.VentasDetalle.TituloId = dbo.Titulos.Id INNER JOIN
                      dbo.Autores ON dbo.Titulos.AutorId = dbo.Autores.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[17] 3) )"
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
         Configuration = "(H (4[29] 2[21] 3) )"
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
               Top = 25
               Left = 297
               Bottom = 311
               Right = 491
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "VentasDetalle"
            Begin Extent = 
               Top = 30
               Left = 559
               Bottom = 313
               Right = 753
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Clientes"
            Begin Extent = 
               Top = 30
               Left = 50
               Bottom = 336
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Titulos"
            Begin Extent = 
               Top = 24
               Left = 840
               Bottom = 309
               Right = 1034
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Autores"
            Begin Extent = 
               Top = 6
               Left = 1072
               Bottom = 114
               Right = 1266
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
       ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vVentasConDetalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'  Width = 1500
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vVentasConDetalle';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vVentasConDetalle';

