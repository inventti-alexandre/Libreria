CREATE VIEW dbo.vTitulos
AS
SELECT     dbo.Titulos.NombreTitulo AS Titulo, dbo.Autores.Nombre AS Autor, dbo.Titulos.PrecioVentaTitulo AS PrcVta1, dbo.Editoriales.Nombre AS cEdi, 
                      dbo.Titulos.UbicacionId AS nUbi, dbo.Titulos.PesoTitulo AS dePeso, dbo.Titulos.PrecioCompraTitulo AS PrcComp, dbo.TitulosPartes.Nombre AS rParte, 
                      dbo.TitulosModoStock.Nombre AS ModoStock, dbo.Titulos.CodigoBarra AS CodBarra, dbo.Titulos.FechaAlta AS FAlta, 
                      dbo.Operadores.Usuario AS OpeGr, dbo.Proveedores.Cuenta, dbo.Proveedores.Denominacion AS Proveedor, dbo.Titulos.Id, dbo.Titulos.Cod, 
                      dbo.Titulos.ISBN, dbo.Titulos.NombreTitulo, dbo.Titulos.ProveedorId, dbo.Titulos.AutorId, dbo.Titulos.EditorialId, dbo.Titulos.TemaId, 
                      dbo.Titulos.SubtemaId, dbo.Titulos.PrecioVentaTitulo, dbo.Titulos.PrecioCompraTitulo, dbo.Titulos.CodigoBarra, dbo.Titulos.ISBNg, 
                      dbo.Titulos.FechaAltaTitulo, dbo.Titulos.TipoArticuloId, dbo.Titulos.ModoStockId, dbo.Titulos.TipoTituloId, dbo.Titulos.UnidadesId, 
                      dbo.Titulos.TomosTitulosId, dbo.Titulos.EstadoTituloId, dbo.Titulos.AdicionalId, dbo.Titulos.PesoTitulo, dbo.Titulos.PaisId, dbo.Titulos.FechaEdicion, 
                      dbo.Titulos.IdiomaId, dbo.Titulos.PartesId, dbo.Titulos.Paginas, dbo.Titulos.Encuad, dbo.Titulos.Comentario, dbo.Titulos.StkMin, dbo.Titulos.FUltVta, 
                      dbo.Titulos.Fingreso, dbo.Titulos.nControl, dbo.Titulos.UbicacionId, dbo.Titulos.TituloUnicoId, dbo.Titulos.PresentacionId, dbo.Titulos.FechaAlta, 
                      dbo.Titulos.SucursalAltaId, dbo.Titulos.OperadorAltaId, dbo.Titulos.FechaModificacion, dbo.Titulos.SucursalModificacionId, 
                      dbo.Titulos.OperadorModificacionId
FROM         dbo.Titulos LEFT OUTER JOIN
                      dbo.Operadores ON dbo.Titulos.OperadorModificacionId = dbo.Operadores.Id AND dbo.Titulos.OperadorAltaId = dbo.Operadores.Id LEFT OUTER JOIN
                      dbo.Proveedores ON dbo.Titulos.ProveedorId = dbo.Proveedores.Id LEFT OUTER JOIN
                      dbo.TitulosModoStock ON dbo.Titulos.ModoStockId = dbo.TitulosModoStock.Id LEFT OUTER JOIN
                      dbo.TitulosPartes ON dbo.Titulos.PartesId = dbo.TitulosPartes.Id LEFT OUTER JOIN
                      dbo.Editoriales ON dbo.Titulos.EditorialId = dbo.Editoriales.Id LEFT OUTER JOIN
                      dbo.Autores ON dbo.Titulos.AutorId = dbo.Autores.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[27] 2[13] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[42] 4[46] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4[34] 2[36] 3) )"
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
      ActivePaneConfig = 3
   End
   Begin DiagramPane = 
      PaneHidden = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Titulos"
            Begin Extent = 
               Top = 23
               Left = 383
               Bottom = 325
               Right = 577
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Operadores"
            Begin Extent = 
               Top = 244
               Left = 689
               Bottom = 352
               Right = 883
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Proveedores"
            Begin Extent = 
               Top = 16
               Left = 694
               Bottom = 124
               Right = 888
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TitulosModoStock"
            Begin Extent = 
               Top = 128
               Left = 694
               Bottom = 236
               Right = 888
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TitulosPartes"
            Begin Extent = 
               Top = 235
               Left = 23
               Bottom = 343
               Right = 217
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Editoriales"
            Begin Extent = 
               Top = 128
               Left = 26
               Bottom = 236
               Right = 220
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Autores"
            Begin Extent = 
               Top = 17
               Left = 28
               Bottom = 125
               Right = 222
  ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTitulos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'          End
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
      Begin ColumnWidths = 19
         Width = 284
         Width = 1920
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
         Column = 2565
         Alias = 1425
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTitulos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTitulos';

