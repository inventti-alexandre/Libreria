CREATE PROCEDURE [dbo].[Titulos_Listado]
 @ColumnaParaOrdenar VARCHAR(250),
 @CodigoProveedor INT = NULL,
 @CodigoLibroCompleto VARCHAR(17),
 @ISBN VARCHAR(15),
 @CodigoBarra VARCHAR (50),
 @TituloNombre VARCHAR(50),
 @ProveedorId UNIQUEIDENTIFIER,
 @TemaId INT,
 @AutorNombre VARCHAR(50),
 @EditorialId INT,
 @ConStock BIT,
 @SucursalId INT,
 @OchoDeMarzo BIT, 
 @Activos BIT,
 @PageIndex INT,
 @PageSize INT
AS

BEGIN

WITH Paging(Id, Cod, ISBN, CodigoBarra, NombreTitulo, ProveedorId, ProveedorDenominacion,
  TemaNombre, AutorNombre,EditorialNombre, FechaModificacion, PrecioVentaTitulo, PrecioCompraTitulo,
        TituloStockStkPr, TituloStockStkCn, TituloStockStkPrViejo, TituloStockStkCnViejo,
        OperadorModificacionUsuario, UsuarioUltimoPrecio,Activo,EstaConsignado, Fila) AS
(
    SELECT
  T.Id, 
  T.Cod,
  T.ISBN,
  T.CodigoBarra,
  T.NombreTitulo,
  T.ProveedorId,
  P.Denominacion,
  TE.Nombre,
  A.Nombre,
  E.Nombre,
  T.FechaModificacion,
  T.PrecioVentaTitulo,
        T.PrecioCompraTitulo,
        STK.Propio,
        STK.Consignado,
  STKVJO.Propio,
        STKVJO.Consignado,
        O.Usuario,
  OUP.Usuario,
  T.Activo,
  ISNULL(CONS.EstaConsignado,CAST(0 AS BIT)),
  ROW_NUMBER() OVER (ORDER BY         
     (CASE UPPER(@ColumnaParaOrdenar)
      -- ORDEN ASC
      WHEN 'COD ASC' THEN T.Cod
      WHEN 'ISBN ASC' THEN T.ISBN
      WHEN 'NOMBRETITULO ASC' THEN T.NombreTitulo
      WHEN 'PROVEEDOR.DENOMINACION ASC' THEN P.Denominacion
      WHEN 'TEMA.NOMBRE ASC' THEN TE.Nombre
      WHEN 'AUTOR.NOMBRE ASC' THEN A.Nombre
      WHEN 'EDITORIAL.NOMBRE ASC' THEN E.Nombre
      WHEN 'PRECIOVENTATITULO ASC' THEN RIGHT('00000000000000000000' +  CONVERT(VARCHAR(10),T.PrecioVentaTitulo),20) 
      WHEN 'PRECIOCOMPRATITULO ASC' THEN RIGHT('00000000000000000000' +  CONVERT(VARCHAR(10),T.PrecioCompraTitulo),20)  
      WHEN 'TITULOSTOCKSTKPR ASC' THEN RIGHT('0000000000' +  CONVERT(VARCHAR(10),STK.Propio),10)
      WHEN 'TITULOSTOCKSTKCN ASC' THEN RIGHT('0000000000' +  CONVERT(VARCHAR(10),STK.Consignado),10)
      WHEN 'TITULOSTOCKSTKPRVIEJO ASC' THEN RIGHT('0000000000' +  CONVERT(VARCHAR(10),STKVJO.Propio),10)
      WHEN 'TITULOSTOCKSTKCNVIEJO ASC' THEN RIGHT('0000000000' +  CONVERT(VARCHAR(10),STKVJO.Consignado),10)
     END) ASC,
     (CASE @ColumnaParaOrdenar
      -- ORDEN DESC
      WHEN 'COD DESC' THEN T.Cod
      WHEN 'ISBN DESC' THEN T.ISBN
      WHEN 'NOMBRETITULO DESC' THEN T.NombreTitulo
      WHEN 'PROVEEDOR.DENOMINACION DESC' THEN P.Denominacion
      WHEN 'TEMA.NOMBRE DESC' THEN TE.Nombre
      WHEN 'AUTOR.NOMBRE DESC' THEN E.Nombre
      WHEN 'EDITORIAL.NOMBRE DESC' THEN A.Nombre
      WHEN 'PRECIOVENTATITULO DESC' THEN RIGHT('00000000000000000000' +  CONVERT(VARCHAR(10),T.PrecioVentaTitulo),20) 
      WHEN 'PRECIOCOMPRATITULO DESC' THEN RIGHT('00000000000000000000' +  CONVERT(VARCHAR(10),T.PrecioCompraTitulo),20)  
      WHEN 'TITULOSTOCKSTKPR DESC' THEN RIGHT('0000000000' +  CONVERT(VARCHAR(10),STK.Propio),10)
      WHEN 'TITULOSTOCKSTKCN DESC' THEN RIGHT('0000000000' +  CONVERT(VARCHAR(10),STK.Consignado),10)
      WHEN 'TITULOSTOCKSTKPRVIEJO DESC' THEN RIGHT('0000000000' +  CONVERT(VARCHAR(10),STKVJO.Propio),10)
      WHEN 'TITULOSTOCKSTKCNVIEJO DESC' THEN RIGHT('0000000000' +  CONVERT(VARCHAR(10),STKVJO.Consignado),10)
     END) DESC) 
  FROM dbo.Titulos T
   INNER JOIN Proveedores P 
    ON T.ProveedorId = P.Id
   LEFT JOIN Temas TE
    ON T.TemaId = TE.Id
   LEFT JOIN Autores A
    ON T.AutorId = A.Id
   LEFT JOIN Editoriales E
    ON T.EditorialId = E.Id
   LEFT JOIN Operadores O
    ON T.OperadorModificacionId = O.Id
   LEFT JOIN Operadores OUP
    ON T.OperadorUltimoPrecioId = OUP.Id

   OUTER APPLY (SELECT Consignado = SUM(TSK.StkCn),Propio = SUM(TSK.StkPr) 
       FROM TitulosStock TSK 
       WHERE TSK.TituloId = T.Id AND (@SucursalId IS NULL OR @SucursalId = TSK.SucursalId)) STK

   OUTER APPLY (SELECT Consignado = SUM(TSK.StkCn),Propio = SUM(TSK.StkPr) 
       FROM [LapazMigracion].[dbo].TitulosStock TSK 
       WHERE TSK.TituloId = T.Id AND (@SucursalId IS NULL OR @SucursalId = TSK.SucursalId)) STKVJO
	
	--TE MUESTRA LOS CONSIGNADOS DE VERDE EN LA GRILLA.
   OUTER APPLY (SELECT TOP 1 EstaConsignado = CAST(1 as bit) 
       FROM [dbo].RemitosVentaDetalle RVD 
       WHERE RVD.TituloId = T.Id AND (@SucursalId IS NULL OR @SucursalId = RVD.SucursalAltaId) 
       AND ((ISNULL(RVD.CntCn, 0) + ISNULL(RVD.CntPr, 0)) > (ISNULL(RVD.CntVendida, 0) + ISNULL(RVD.CntDevuelta, 0)))) CONS

  WHERE
   (@CodigoLibroCompleto IS NULL OR @CodigoLibroCompleto = '' OR T.Cod = @CodigoLibroCompleto)
   AND (@CodigoProveedor IS NULL OR P.Cuenta = @CodigoProveedor)
   AND (@ISBN IS NULL OR @ISBN = '' OR T.ISBN  LIKE  @ISBN +'%')
   AND (@TituloNombre IS NULL OR @TituloNombre = '' OR T.NombreTitulo LIKE @TituloNombre +'%')
   AND (@CodigoBarra IS NULL OR @CodigoBarra = '' OR T.CodigoBarra LIKE  @CodigoBarra +'%')
   AND (@ProveedorId IS NULL OR T.ProveedorId = @ProveedorId)
   AND (@TemaId IS NULL OR T.TemaId = @TemaId)
   AND (@AutorNombre IS NULL OR @AutorNombre = '' OR A.Nombre LIKE @AutorNombre +'%')
   AND (@EditorialId IS NULL OR T.EditorialId = @EditorialId)
   AND (@Activos IS NULL OR T.Activo = @Activos)
   AND ((@ConStock IS NULL AND @OchoDeMarzo IS NULL)
      OR (@ConStock = 1 AND @OchoDeMarzo = 1 AND (STK.Consignado > 0 OR STK.Propio > 0 OR STKVJO.Consignado > 0 OR STKVJO.Propio > 0))
      OR (@ConStock = 1 AND @OchoDeMarzo = 0 AND (STK.Consignado > 0 OR STK.Propio > 0 OR STKVJO.Consignado = 0 OR STKVJO.Propio = 0))
      OR (@ConStock = 1 AND @OchoDeMarzo IS NULL AND (STK.Consignado > 0 OR STK.Propio > 0))
      OR (@ConStock = 0 AND @OchoDeMarzo IS NULL AND (STK.Consignado = 0 OR STK.Propio = 0 OR STK.Consignado IS NULL OR STK.Propio IS NULL))
      OR (@ConStock = 0 AND @OchoDeMarzo = 1 AND (STK.Consignado = 0 OR STK.Propio = 0 OR STKVJO.Consignado > 0 OR STKVJO.Propio > 0))
      OR (@ConStock IS NULL AND @OchoDeMarzo = 1 AND (STKVJO.Consignado > 0 OR STKVJO.Propio > 0)) 
      OR (@ConStock = 0 AND @OchoDeMarzo = 0 AND (STK.Consignado = 0 OR STK.Propio = 0 OR STKVJO.Consignado = 0 OR STKVJO.Propio = 0 OR STK.Consignado IS NULL OR STK.Propio IS NULL)) 
      OR (@ConStock IS NULL AND @OchoDeMarzo = 0 AND (STKVJO.Consignado = 0 OR STKVJO.Propio = 0))) 

)

SELECT  Id, Cod, ISBN, CodigoBarra, NombreTitulo, ProveedorId, ProveedorDenominacion,
  TemaNombre, AutorNombre,EditorialNombre, FechaModificacion, PrecioVentaTitulo, PrecioCompraTitulo,
        TituloStockStkPr, TituloStockStkCn, TituloStockStkPrViejo, TituloStockStkCnViejo,
        OperadorModificacionUsuario, UsuarioUltimoPrecio,Activo,EstaConsignado, Fila , (select COUNT(p.Id) from Paging p) as TotalResults  
FROM Paging
where Fila >= ((@PageIndex - 1) * @PageSize) + 1
   AND Fila < (@PageIndex * @PageSize)
   OPTION(RECOMPILE)
END
