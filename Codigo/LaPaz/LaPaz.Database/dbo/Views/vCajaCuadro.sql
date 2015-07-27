CREATE VIEW dbo.vCajaCuadro
AS
SELECT     dbo.Cajas.Id AS CajaId, dbo.Cajas.SucursalId AS CajaSuc, dbo.TiposMovimientosCajas.TipoMovimiento AS nTipo, 
                      dbo.CajasMovimientos.TipoMovimientoCajaId, dbo.CajasMovimientos.TipoComprobante AS CompTipo, dbo.CajasMovimientos.ComprobanteId, 
                      (CASE dbo.CajasMovimientos.TipoComprobante WHEN 2 THEN
                          (SELECT     LCN
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 4 THEN
                          (SELECT     LCN
                            FROM          dbo.NotasDeVenta
                            WHERE      dbo.NotasDeVenta.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 6 THEN
                          (SELECT     LCN
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 7 THEN
                          (SELECT     LCN
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 3 THEN
                          (SELECT     NUMERO AS LCN
                            FROM          dbo.Recibos
                            WHERE      dbo.Recibos.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 10 THEN
                          (SELECT     LCN
                            FROM          dbo.OrdenesPago
                            WHERE      dbo.OrdenesPago.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 10 THEN
                          (SELECT     LCN
                            FROM          dbo.RemitosCompra
                            WHERE      dbo.RemitosCompra.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 21 THEN
                          (SELECT     LCN
                            FROM          dbo.ClientesMontosFavor
                            WHERE      dbo.ClientesMontosFavor.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 32 THEN
                          (SELECT     NumeroComprobante
                            FROM          dbo.MovimientosFondo
                            WHERE      dbo.MovimientosFondo.Id = dbo.CajasMovimientos.ComprobanteId) ELSE 'FALTA CODIGO' END) AS CompLCN, 
                      (CASE dbo.CajasMovimientos.TipoComprobante WHEN 2 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 4 THEN
                          (SELECT     FechaNotaVenta
                            FROM          dbo.NotasDeVenta
                            WHERE      dbo.NotasDeVenta.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 6 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 7 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 3 THEN
                          (SELECT     FechaPago
                            FROM          dbo.Recibos
                            WHERE      dbo.Recibos.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 10 THEN
                          (SELECT     Fecha
                            FROM          dbo.OrdenesPago
                            WHERE      dbo.OrdenesPago.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 10 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.RemitosCompra
                            WHERE      dbo.RemitosCompra.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 21 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.ClientesMontosFavor
                            WHERE      dbo.ClientesMontosFavor.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 32 THEN
                          (SELECT     FechaComprobante
                            FROM          dbo.MovimientosFondo
                            WHERE      dbo.MovimientosFondo.Id = dbo.CajasMovimientos.ComprobanteId) ELSE 'FALTA CODIGO' END) AS CompFecha, 
                      (CASE dbo.CajasMovimientos.TipoComprobante WHEN 2 THEN
                          (SELECT     Concepto
                            FROM          dbo.Compras
                            WHERE      dbo.Compras.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 4 THEN
                          (SELECT     Concepto
                            FROM          dbo.NotasDeVenta
                            WHERE      dbo.NotasDeVenta.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 6 THEN
                          (SELECT     Concepto
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 7 THEN
                          (SELECT     Concepto
                            FROM          dbo.Ventas
                            WHERE      dbo.Ventas.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 3 THEN
                          (SELECT     'Recibos Cobranza' AS Concepto
                            FROM          dbo.Recibos
                            WHERE      dbo.Recibos.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 10 THEN
                          (SELECT     Concepto
                            FROM          dbo.OrdenesPago
                            WHERE      dbo.OrdenesPago.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 10 THEN
                          (SELECT     Concepto
                            FROM          dbo.RemitosCompra
                            WHERE      dbo.RemitosCompra.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 21 THEN
                          (SELECT     Concepto
                            FROM          dbo.ClientesMontosFavor
                            WHERE      dbo.ClientesMontosFavor.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 32 THEN
                          (SELECT     Concepto
                            FROM          dbo.MovimientosFondo
                            WHERE      dbo.MovimientosFondo.Id = dbo.CajasMovimientos.ComprobanteId) ELSE 'FALTA CODIGO' END) AS cDescrip, 
                      (CASE dbo.CajasMovimientos.TipoComprobante WHEN 2 THEN
                          (SELECT     dbo.Proveedores.Denominacion AS ApyNom
                            FROM          dbo.Compras INNER JOIN
                                                   dbo.Proveedores ON dbo.Compras.ProveedorId = dbo.Proveedores.Id AND dbo.Compras.Id = dbo.CajasMovimientos.ComprobanteId) 
                      WHEN 4 THEN
                          (SELECT     dbo.Clientes.Denominacion AS ApyNom
                            FROM          dbo.NotasDeVenta INNER JOIN
                                                   dbo.Clientes ON dbo.NotasDeVenta.ClienteId = dbo.Clientes.Id AND dbo.NotasDeVenta.Id = dbo.CajasMovimientos.ComprobanteId) 
                      WHEN 6 THEN
                          (SELECT     dbo.Clientes.Denominacion AS ApeyNom
                            FROM          dbo.Ventas INNER JOIN
                                                   dbo.Clientes ON dbo.Ventas.ClienteId = dbo.Clientes.Id AND dbo.Ventas.Id = dbo.CajasMovimientos.ComprobanteId) 
                      WHEN 7 THEN
                          (SELECT     dbo.Clientes.Denominacion AS ApyNom
                            FROM          dbo.Ventas INNER JOIN
                                                   dbo.Clientes ON dbo.Ventas.ClienteId = dbo.Clientes.Id AND dbo.Ventas.Id = dbo.CajasMovimientos.ComprobanteId) 
                      WHEN 3 THEN
                          (SELECT     TOP 1 dbo.Clientes.Denominacion AS ApyNom
                            FROM          dbo.RecibosDetalle INNER JOIN
                                                   dbo.ClientesCuentasCorriente ON dbo.RecibosDetalle.ClienteCuentaCorrienteId = dbo.ClientesCuentasCorriente.Id INNER JOIN
                                                   dbo.Clientes ON dbo.ClientesCuentasCorriente.ClienteId = dbo.Clientes.Id AND 
                                                   dbo.RecibosDetalle.ReciboId = dbo.CajasMovimientos.ComprobanteId) WHEN 10 THEN
                          (SELECT     dbo.Proveedores.Denominacion AS ApyNom
                            FROM          dbo.OrdenesPago INNER JOIN
                                                   dbo.Proveedores ON dbo.OrdenesPago.ProveedorId = dbo.Proveedores.Id AND 
                                                   dbo.OrdenesPago.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 21 THEN
                          (SELECT     dbo.Clientes.Denominacion AS ApyNom
                            FROM          dbo.ClientesMontosFavor INNER JOIN
                                                   dbo.Clientes ON dbo.ClientesMontosFavor.ClienteId = dbo.Clientes.Id AND 
                                                   dbo.ClientesMontosFavor.Id = dbo.CajasMovimientos.ComprobanteId) WHEN 32 THEN
                          (SELECT     dbo.MovimientosFondo.DescripcionMovimiento AS ApyNom
                            FROM          dbo.MovimientosFondo
                            WHERE      dbo.MovimientosFondo.Id = dbo.CajasMovimientos.ComprobanteId) ELSE 'FALTA CODIGO' END) AS ApyNom, 
                      dbo.CajasMovimientos.Senia, dbo.CajasMovimientos.Recargo, dbo.CajasMovimientos.Importe, dbo.CajasMovimientos.ImpFac, 
                      dbo.CajasMovimientos.Efectivo AS fpEfc, dbo.CajasMovimientos.Tarjeta AS fpTrj, dbo.CajasMovimientos.Cheque AS fpChq, 
                      dbo.CajasMovimientos.Bono AS fpnBono, dbo.CajasMovimientos.fpcBono, dbo.CajasMovimientos.Deposito AS fpDep, 
                      dbo.CajasMovimientos.FechaAlta AS FeGr, dbo.CajasMovimientos.SucursalAltaId AS SucGr, dbo.TiposMovimientosCajas.Abreviatura AS cCorta, 
                      dbo.Sucursales.Nombre AS cSuc, dbo.CajasMovimientos.FacturaReservadas, dbo.Operadores.Usuario AS OpeGr, 
                      dbo.Personal.Nombre AS NombreUsuario, dbo.Cajas.OperadorAltaId, dbo.TiposMovimientosCajas.CodTipoAnt AS CodTipo
FROM         dbo.Cajas INNER JOIN
                      dbo.CajasMovimientos ON dbo.Cajas.Id = dbo.CajasMovimientos.CajaId INNER JOIN
                      dbo.TiposMovimientosCajas ON dbo.CajasMovimientos.TipoMovimientoCajaId = dbo.TiposMovimientosCajas.Id LEFT OUTER JOIN
                      dbo.Operadores ON dbo.Cajas.OperadorId = dbo.Operadores.Id LEFT OUTER JOIN
                      dbo.Personal ON dbo.Operadores.PersonalId = dbo.Personal.Id LEFT OUTER JOIN
                      dbo.Sucursales ON dbo.Cajas.SucursalId = dbo.Sucursales.Id

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
         Configuration = "(H (1[48] 2[46] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4[54] 2[15] 3) )"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2[78] 3) )"
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
         Configuration = "(H (1[87] 2) )"
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
         Configuration = "(V (2) )"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Cajas"
            Begin Extent = 
               Top = 11
               Left = 399
               Bottom = 175
               Right = 593
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CajasMovimientos"
            Begin Extent = 
               Top = 18
               Left = 115
               Bottom = 471
               Right = 309
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TiposMovimientosCajas"
            Begin Extent = 
               Top = 307
               Left = 390
               Bottom = 461
               Right = 645
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Operadores"
            Begin Extent = 
               Top = 186
               Left = 396
               Bottom = 300
               Right = 590
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Personal"
            Begin Extent = 
               Top = 188
               Left = 741
               Bottom = 474
               Right = 935
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Sucursales"
            Begin Extent = 
               Top = 2
               Left = 696
               Bottom = 110
               Right = 890
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
      Begin ColumnWidths = 30
         Width = 284
         Width = 1500', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vCajaCuadro';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1995
         Width = 2100
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
      PaneHidden = 
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
         Filter = 4650
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vCajaCuadro';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vCajaCuadro';

