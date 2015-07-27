CREATE VIEW [dbo].[vProveedores]
AS
SELECT     dbo.Provincias.Nombre AS ProvinciaNombre, dbo.Localidades.Nombre AS LocalidadNombre, dbo.Proveedores.Id, dbo.Proveedores.Cuenta, 
                      dbo.Proveedores.Denominacion, dbo.Proveedores.Domicilio, dbo.Proveedores.Telefono, dbo.Proveedores.Celular, dbo.Proveedores.Fax, 
                      dbo.Proveedores.Contacto, dbo.Proveedores.Cuit, dbo.Proveedores.TipoDocumento, dbo.Proveedores.ProvinciaId, dbo.Proveedores.LocalidadId, 
                      dbo.Proveedores.CondicionCompraId, dbo.Proveedores.PorcentajeDescuento, dbo.Proveedores.Password, dbo.Proveedores.ProveerdorBcoId, 
                      dbo.Proveedores.CBU, dbo.Proveedores.GrupoProveedorId, dbo.Proveedores.PaginaWeb, dbo.Proveedores.EmailPedido, dbo.Proveedores.Estado, 
                      dbo.Proveedores.Comentarios, dbo.Proveedores.SucursalAltaId, dbo.Proveedores.FechaAlta, dbo.Proveedores.OperadorAltaId, 
                      dbo.Proveedores.FechaModificacion, dbo.Proveedores.OperadorModificacionId, dbo.Proveedores.SucursalModificacionId, 
                      dbo.ProveedoresBanco.CtaCte, dbo.ProveedoresBanco.CajaAhorro, dbo.ProveedoresBanco.BancoId, dbo.Proveedores.Gto
FROM         dbo.Proveedores LEFT OUTER JOIN
                      dbo.ProveedoresBanco ON dbo.Proveedores.Id = dbo.ProveedoresBanco.ProveedorId LEFT OUTER JOIN
                      dbo.Localidades ON dbo.Proveedores.LocalidadId = dbo.Localidades.Id LEFT OUTER JOIN
                      dbo.Provincias ON dbo.Proveedores.ProvinciaId = dbo.Provincias.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[37] 4[4] 2[24] 3) )"
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
         Top = -47
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Proveedores"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 235
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 18
         End
         Begin Table = "ProveedoresBanco"
            Begin Extent = 
               Top = 91
               Left = 594
               Bottom = 311
               Right = 784
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Localidades"
            Begin Extent = 
               Top = 149
               Left = 334
               Bottom = 264
               Right = 529
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Provincias"
            Begin Extent = 
               Top = 6
               Left = 504
               Bottom = 121
               Right = 699
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
      Begin ColumnWidths = 34
         Width = 284
         Width = 1500
         Width = 1500
         Width = 3645
         Width = 1500
         Width = 3660
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
  ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vProveedores';


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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 4065
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vProveedores';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vProveedores';

