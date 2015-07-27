CREATE VIEW dbo.vNumeradores
AS
SELECT     dbo.TiposComprobantes.Nombre AS TiposComprobante, dbo.Sucursales.Nombre AS cSuc, dbo.TiposComprobantes.Abreviatura AS cTipoMov, 
                      dbo.Numeradores.Id, dbo.Numeradores.SucursalId, dbo.Numeradores.TipoNumeradorId, dbo.Numeradores.LCN, dbo.Numeradores.UltimoNumero, 
                      dbo.Numeradores.Copias, dbo.Numeradores.ImpresoraPath, dbo.Numeradores.ImpresoraPath2, dbo.Numeradores.ImpresoraPuerto, 
                      dbo.Numeradores.ImpresoraPuerto2, dbo.Numeradores.Lpt1Computadora, dbo.Numeradores.Lpt2Computadora, dbo.Numeradores.Lpt3Computadora, 
                      dbo.Numeradores.Lpt4Computadora, dbo.Numeradores.PcGr, dbo.Numeradores.FechaAlta, dbo.Numeradores.SucursalAltaId, 
                      dbo.Numeradores.OperadorAltaId, dbo.Numeradores.FechaModificacion, dbo.Numeradores.SucursalModificacionId, 
                      dbo.Numeradores.OperadorModificacionId, SUBSTRING(dbo.Numeradores.LCN, 1, 1) AS letra, SUBSTRING(dbo.Numeradores.LCN, 2, 4) AS codigo, 
                      SUBSTRING(dbo.Numeradores.LCN, 6, 8) AS Numero, dbo.Operadores.Usuario AS OpeGr
FROM         dbo.Numeradores LEFT OUTER JOIN
                      dbo.Operadores ON dbo.Numeradores.OperadorModificacionId = dbo.Operadores.Id LEFT OUTER JOIN
                      dbo.TiposComprobantes ON dbo.Numeradores.TipoNumeradorId = dbo.TiposComprobantes.Id LEFT OUTER JOIN
                      dbo.Sucursales ON dbo.Numeradores.SucursalId = dbo.Sucursales.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[18] 4[36] 2[22] 3) )"
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
         Begin Table = "Sucursales"
            Begin Extent = 
               Top = 62
               Left = 282
               Bottom = 177
               Right = 477
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TiposComprobantes"
            Begin Extent = 
               Top = 6
               Left = 504
               Bottom = 121
               Right = 699
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Numeradores"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 240
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 9
         End
         Begin Table = "Operadores"
            Begin Extent = 
               Top = 137
               Left = 652
               Bottom = 277
               Right = 847
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 28
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2250
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
    ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vNumeradores';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'     Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1905
         Alias = 2910
         Table = 2505
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vNumeradores';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vNumeradores';

