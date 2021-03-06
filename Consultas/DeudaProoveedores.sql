/****** Compras  ******/
SELECT SUM (isnull(ImporteNeto,0))
  FROM [LCorrientes].[dbo].[Compras]
  where TipoComprobanteId=2
  and FechaAlta >= '2016-01-01'
  and FechaAlta < '2017-01-01'
  --order by FechaAlta desc

/****** Cuotas de cuenta corrientes  ******/
  SELECT SUM(isnull(Importe,0))
  FROM [LCorrientes].[dbo].[ProveedoresCuentasCorriente]
   where FechaAlta >= '2016-01-01'
  and FechaAlta < '2017-01-01'
  --order by FechaAlta desc

 /****** Anticipos de las compras  ******/
  SELECT  SUM(isnull(cm.Senia,0))
  FROM [LCorrientes].[dbo].[Compras] c
  inner join CajasMovimientos cm
  on cm.ComprobanteId = c.Id
  where TipoComprobanteId=2
  and c.FechaAlta >= '2016-01-01'
  and c.FechaAlta < '2017-01-01'
  --order by c.FechaAlta desc

/****** Pagos de las Cuentas corrientes  ******/
  SELECT SUM (isnull(ppd.MontoPagado,0))
  FROM [LCorrientes].[dbo].[ProveedoresCuentasCorriente] pcc
  inner join ProveedoresPagosDetalle ppd
  on ppd.ProveedorCuentaCorrienteId = pcc.Id
   where ppd.FechaAlta >= '2016-01-01'
  and ppd.FechaAlta < '2017-01-01'
  and pcc.FechaAlta >= '2016-01-01'
  and pcc.FechaAlta < '2017-01-01'
  --order by ppd.FechaAlta desc

 /****** Proveedores maonto a favor  ******/
SELECT *
 FROM [LCorrientes].[dbo].[ProveedoresMontosFavor]
 where FechaAlta >= '2016-01-01'
  and FechaAlta < '2017-01-01'
  and Importe <> ImporteOcupado
  order by FechaAlta desc