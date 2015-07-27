CREATE VIEW dbo.vTransferenciasImprimir
AS
SELECT     dbo.Transferencias.SucursalId AS CodSuc, dbo.Transferencias.Numero AS IdRem, dbo.Transferencias.LCN, dbo.Transferencias.CodSucDest, 
                      dbo.Transferencias.Fecha, dbo.Transferencias.Concepto, dbo.Transferencias.Obs, dbo.Transferencias.FAnula, dbo.Transferencias.FRecibe, 
                      dbo.Transferencias.FechaAlta AS FeGr, dbo.Transferencias.SucursalAltaId AS SucGr, dbo.Transferencias.OperadorAltaId AS OpeGr, 
                      dbo.Titulos.Cod AS Codigo, dbo.Titulos.NombreTitulo AS DescLibro, dbo.TransferenciasDetalle.CntPr, dbo.TransferenciasDetalle.CntCn, 
                      dbo.TransferenciasDetalle.CntVn, dbo.Autores.Nombre AS Autor, dbo.TransferenciasDetalle.PrcVta, dbo.TransferenciasDetalle.CntAud, 
                      dbo.TransferenciasDetalle.FechaAlta AS fecgr, dbo.TransferenciasDetalle.SucursalAltaId AS sugr, SUBSTRING(dbo.Transferencias.LCN, 2, 4) 
                      + '-' + SUBSTRING(dbo.Transferencias.LCN, 6, 8) AS cLcn, dbo.Transferencias.Id
FROM         dbo.Transferencias INNER JOIN
                      dbo.TransferenciasDetalle ON dbo.Transferencias.Id = dbo.TransferenciasDetalle.TransferenciaId LEFT OUTER JOIN
                      dbo.Titulos ON dbo.TransferenciasDetalle.TituloId = dbo.Titulos.Id LEFT OUTER JOIN
                      dbo.Autores ON dbo.Titulos.AutorId = dbo.Autores.Id

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "Transferencias"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 294
               Right = 232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TransferenciasDetalle"
            Begin Extent = 
               Top = 6
               Left = 270
               Bottom = 261
               Right = 464
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Titulos"
            Begin Extent = 
               Top = 7
               Left = 513
               Bottom = 316
               Right = 707
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Autores"
            Begin Extent = 
               Top = 6
               Left = 745
               Bottom = 114
               Right = 939
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
         Width = 2145
         Width = 2040
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
   Begin C', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTransferenciasImprimir';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'riteriaPane = 
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTransferenciasImprimir';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vTransferenciasImprimir';

