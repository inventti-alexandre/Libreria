CREATE VIEW dbo.vClientesFavor
AS
SELECT     dbo.Clientes.Denominacion AS CliDenominacion, dbo.Clientes.Cuit AS CliCuit, dbo.ClientesMontosFavor.Id, dbo.ClientesMontosFavor.VentaId, 
                      dbo.ClientesMontosFavor.ClienteId, dbo.ClientesMontosFavor.FechaComprobante AS Fecha, dbo.ClientesMontosFavor.TipoComprobanteId, 
                      dbo.ClientesMontosFavor.LCN, dbo.ClientesMontosFavor.Concepto, dbo.ClientesMontosFavor.Importe, dbo.ClientesMontosFavor.ImpOcupado, 
                      dbo.ClientesMontosFavor.FechaAnulacion, dbo.ClientesMontosFavor.OperadorAutoriza, dbo.ClientesMontosFavor.Observaciones, 
                      dbo.ClientesMontosFavor.FechaAlta, dbo.ClientesMontosFavor.SucursalAltaId, dbo.ClientesMontosFavor.OperadorAltaId, 
                      dbo.ClientesMontosFavor.FechaModificacion, dbo.ClientesMontosFavor.SucursalModificacionId, dbo.ClientesMontosFavor.OperadorModificacionId, 
                      dbo.Clientes.Cuenta AS CliCuenta, dbo.Clientes.SucursalId AS CliSuc, dbo.Operadores.Usuario AS OpeAu, 0 AS Cuota
FROM         dbo.ClientesMontosFavor LEFT OUTER JOIN
                      dbo.Operadores ON dbo.ClientesMontosFavor.OperadorAutoriza = dbo.Operadores.Id LEFT OUTER JOIN
                      dbo.Clientes ON dbo.ClientesMontosFavor.ClienteId = dbo.Clientes.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[29] 4[4] 2[27] 3) )"
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
         Begin Table = "ClientesMontosFavor"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 189
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 9
         End
         Begin Table = "Operadores"
            Begin Extent = 
               Top = 192
               Left = 38
               Bottom = 307
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Clientes"
            Begin Extent = 
               Top = 5
               Left = 436
               Bottom = 188
               Right = 631
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 25
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
  ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientesFavor';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'       GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientesFavor';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientesFavor';

