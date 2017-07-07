UPDATE  lote
SET
        lote.NroActual = feria.NroActual
FROM
        LCorrientes.dbo.LoteFactura lote
        INNER JOIN LCorrientesFeria.dbo.LoteFactura feria ON (lote.NroLote = feria.NroLote)
WHERE
        (lote.NroLote = '81987');