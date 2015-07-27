CREATE VIEW dbo.vClientesFacturacion
AS
SELECT     dbo.Clientes.Denominacion AS cCli, dbo.Clientes.Telefono, dbo.Clientes.Domicilio, dbo.TiposDocumentosIdentidad.Abreviatura AS rTipoDoc, 
                      dbo.Clientes.Cuit, dbo.CondicionesIVA.Abreviatura AS rPosiIva, dbo.Localidades.Nombre AS cLoca, dbo.Clientes.EstadoClienteId, 
                      dbo.Clientes.Id AS ClienteId, dbo.Clientes.Cuenta
FROM         dbo.Clientes LEFT OUTER JOIN
                      dbo.Localidades ON dbo.Clientes.LocalidadId = dbo.Localidades.Id LEFT OUTER JOIN
                      dbo.CondicionesIVA ON dbo.Clientes.CondicionIvaId = dbo.CondicionesIVA.Id LEFT OUTER JOIN
                      dbo.TiposDocumentosIdentidad ON dbo.Clientes.TipoDocumentoId = dbo.TiposDocumentosIdentidad.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[12] 3) )"
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
         Begin Table = "Clientes"
            Begin Extent = 
               Top = 3
               Left = 453
               Bottom = 269
               Right = 647
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Localidades"
            Begin Extent = 
               Top = 124
               Left = 105
               Bottom = 303
               Right = 299
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CondicionesIVA"
            Begin Extent = 
               Top = 4
               Left = 102
               Bottom = 112
               Right = 296
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TiposDocumentosIdentidad"
            Begin Extent = 
               Top = 44
               Left = 730
               Bottom = 214
               Right = 924
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
      Begin ColumnWidths = 10
         Width = 284
         Width = 2010
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
         Or = 1350', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientesFacturacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientesFacturacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vClientesFacturacion';

