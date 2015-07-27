﻿CREATE VIEW dbo.vChequesTerceros
AS
SELECT     dbo.ChequesTerceros.Id, dbo.ChequesTerceros.CajaMovimientoId, dbo.ChequesTerceros.BancoId, dbo.ChequesTerceros.NroCheque, 
                      dbo.ChequesTerceros.Fecha, dbo.ChequesTerceros.FechaCobro, dbo.ChequesTerceros.Importe, dbo.ChequesTerceros.EstadoChequeId, 
                      dbo.ChequesTerceros.OrdenPagoDetalleId, dbo.ChequesTerceros.FechaAlta, dbo.ChequesTerceros.OperadorAltaId, 
                      dbo.ChequesTerceros.SucursalAltaId, dbo.ChequesTerceros.FechaModificacion, dbo.ChequesTerceros.OperadorModificacionId, 
                      dbo.ChequesTerceros.SucursalModificacionId, dbo.Bancos.Nombre AS BcoDesc, dbo.Cajas.SucursalId AS CajaSuc, dbo.Cajas.OperadorId, 
                      dbo.Operadores.Usuario AS CjOper, dbo.ChequesTerceros.sTipo, dbo.ChequesTerceros.sSuc, dbo.ChequesTerceros.sId, 
                      dbo.ChequesTerceros.sFecha, dbo.ChequesTerceros.sComprob
FROM         dbo.Operadores INNER JOIN
                      dbo.Cajas ON dbo.Operadores.Id = dbo.Cajas.OperadorId RIGHT OUTER JOIN
                      dbo.ChequesTerceros LEFT OUTER JOIN
                      dbo.CajasMovimientos ON dbo.ChequesTerceros.CajaMovimientoId = dbo.CajasMovimientos.Id LEFT OUTER JOIN
                      dbo.Bancos ON dbo.ChequesTerceros.BancoId = dbo.Bancos.Id ON dbo.Cajas.Id = dbo.CajasMovimientos.CajaId

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[28] 4[33] 2[10] 3) )"
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
         Begin Table = "Operadores"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 121
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cajas"
            Begin Extent = 
               Top = 6
               Left = 271
               Bottom = 121
               Right = 466
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Bancos"
            Begin Extent = 
               Top = 152
               Left = 666
               Bottom = 267
               Right = 861
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CajasMovimientos"
            Begin Extent = 
               Top = 114
               Left = 407
               Bottom = 229
               Right = 602
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ChequesTerceros"
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
      Begin ColumnWidths = 10
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Colum', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vChequesTerceros';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'n = 2595
         Alias = 900
         Table = 2445
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vChequesTerceros';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vChequesTerceros';

