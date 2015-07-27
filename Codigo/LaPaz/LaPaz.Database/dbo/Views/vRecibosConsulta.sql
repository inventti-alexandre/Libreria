CREATE VIEW dbo.vRecibosConsulta
AS
SELECT     dbo.Recibos.Id, dbo.Recibos.SucursalCompId, dbo.Recibos.Tipo, dbo.Recibos.PuntoVenta, dbo.Recibos.Numero, dbo.Recibos.FechaAnulacion, 
                      dbo.Recibos.FechaPago, dbo.Recibos.Total, dbo.Recibos.OperadorAuId, dbo.Recibos.OperadorAltaId, dbo.Recibos.FechaAlta, 
                      dbo.Recibos.SucursalAltaId, dbo.RecibosDetalle.Id AS DetalleId, dbo.RecibosDetalle.ReciboId, dbo.RecibosDetalle.ClienteCuentaCorrienteId, 
                      dbo.RecibosDetalle.Importe, dbo.Ventas.LCN, dbo.ClientesCuentasCorriente.Importe AS ImpCuo, dbo.ClientesCuentasCorriente.Cuota, 
                      dbo.Operadores.Usuario AS OpeAu, dbo.Clientes.SucursalId AS CliSuc, dbo.Clientes.Cuenta AS CliCuenta, dbo.Clientes.Denominacion, 
                      dbo.ClientesCuentasCorriente.ClienteId
FROM         dbo.Recibos INNER JOIN
                      dbo.RecibosDetalle ON dbo.Recibos.Id = dbo.RecibosDetalle.ReciboId INNER JOIN
                      dbo.ClientesCuentasCorriente ON dbo.RecibosDetalle.ClienteCuentaCorrienteId = dbo.ClientesCuentasCorriente.Id INNER JOIN
                      dbo.Ventas ON dbo.ClientesCuentasCorriente.VentaId = dbo.Ventas.Id INNER JOIN
                      dbo.Clientes ON dbo.Ventas.ClienteId = dbo.Clientes.Id LEFT OUTER JOIN
                      dbo.Operadores ON dbo.Recibos.OperadorAuId = dbo.Operadores.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[8] 3) )"
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
         Begin Table = "Recibos"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 292
               Right = 232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "RecibosDetalle"
            Begin Extent = 
               Top = 6
               Left = 270
               Bottom = 229
               Right = 473
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ClientesCuentasCorriente"
            Begin Extent = 
               Top = 6
               Left = 511
               Bottom = 310
               Right = 705
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ventas"
            Begin Extent = 
               Top = 10
               Left = 770
               Bottom = 303
               Right = 964
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Clientes"
            Begin Extent = 
               Top = 18
               Left = 1034
               Bottom = 298
               Right = 1228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Operadores"
            Begin Extent = 
               Top = 239
               Left = 265
               Bottom = 347
               Right = 459
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
      Begin ColumnWidths = 31
         Width = 284
         Width = 1500
  ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vRecibosConsulta';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'       Width = 1500
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vRecibosConsulta';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vRecibosConsulta';

