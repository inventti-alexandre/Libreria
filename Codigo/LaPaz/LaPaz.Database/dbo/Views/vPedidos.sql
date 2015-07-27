CREATE VIEW dbo.vPedidos
AS
SELECT     dbo.Pedidos.Id, dbo.Pedidos.SucursalId, dbo.Pedidos.ClienteId, dbo.Pedidos.TituloId, dbo.Pedidos.Cantidad, dbo.Pedidos.PrioridadesId, 
                      dbo.Pedidos.EstadoPedido, dbo.Pedidos.FechaPedido, dbo.Pedidos.FechaPedidoProveedor, dbo.Pedidos.OperadorId, dbo.Pedidos.FechaAviso, 
                      dbo.Pedidos.FechaVenta, dbo.Pedidos.VentaDetalleId, dbo.Pedidos.FechaAlta, dbo.Pedidos.SucursalAltaId, dbo.Pedidos.OperadorAltaId, 
                      dbo.Pedidos.FechaModificacion, dbo.Pedidos.SucursalModificacionId, dbo.Pedidos.OperadorModificacionId, 
                      dbo.Clientes.Denominacion AS CliDenominacion, dbo.Titulos.NombreTitulo AS TituloNombre, dbo.Proveedores.Cuenta AS ProveedorCuenta, 
                      dbo.Proveedores.Denominacion, dbo.PedidosDetalle.EstadoEnvio, dbo.PedidosDetalle.FechaEnviado, dbo.Proveedores.EmailPedido, 
                      dbo.Clientes.Domicilio AS CliDomicilio, dbo.Clientes.Telefono AS CliTelefono, dbo.Editoriales.Nombre AS EditorialNombre, 
                      dbo.Autores.Nombre AS AutorNombre, dbo.Titulos.ISBN, dbo.Titulos.Cod, dbo.Operadores.Usuario, dbo.Titulos.PrecioVentaTitulo
FROM         dbo.Clientes RIGHT OUTER JOIN
                      dbo.Operadores RIGHT OUTER JOIN
                      dbo.Pedidos ON dbo.Operadores.Id = dbo.Pedidos.OperadorId ON dbo.Clientes.Id = dbo.Pedidos.ClienteId LEFT OUTER JOIN
                      dbo.Editoriales RIGHT OUTER JOIN
                      dbo.Autores RIGHT OUTER JOIN
                      dbo.Titulos ON dbo.Autores.Id = dbo.Titulos.AutorId ON dbo.Editoriales.Id = dbo.Titulos.EditorialId ON 
                      dbo.Pedidos.TituloId = dbo.Titulos.Id LEFT OUTER JOIN
                      dbo.PedidosDetalle LEFT OUTER JOIN
                      dbo.Proveedores ON dbo.PedidosDetalle.ProveedorId = dbo.Proveedores.Id ON dbo.Pedidos.Id = dbo.PedidosDetalle.PedidoId

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[61] 4[4] 2[16] 3) )"
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
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Clientes"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 0
         End
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
         Begin Table = "Pedidos"
            Begin Extent = 
               Top = 6
               Left = 504
               Bottom = 121
               Right = 699
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Editoriales"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 241
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Autores"
            Begin Extent = 
               Top = 126
               Left = 271
               Bottom = 241
               Right = 466
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Titulos"
            Begin Extent = 
               Top = 126
               Left = 504
               Bottom = 314
               Right = 699
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "PedidosDetalle"
            Begin Extent = 
               Top = 246
               Left = 38
               Bottom = 361
               Right = 233
            End
            Displ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vPedidos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'ayFlags = 280
            TopColumn = 8
         End
         Begin Table = "Proveedores"
            Begin Extent = 
               Top = 246
               Left = 271
               Bottom = 361
               Right = 466
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
      Begin ColumnWidths = 35
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vPedidos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vPedidos';

