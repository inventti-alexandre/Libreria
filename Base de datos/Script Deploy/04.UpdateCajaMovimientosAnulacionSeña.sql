UPDATE CajasMovimientos 
SET TipoMovimientoCajaId = 35 
WHERE ComprobanteId IN (SELECT Id FROM ProveedoresSenias WHERE FechaAnulacion IS NOT NULL) AND TipoComprobante <> 37
GO