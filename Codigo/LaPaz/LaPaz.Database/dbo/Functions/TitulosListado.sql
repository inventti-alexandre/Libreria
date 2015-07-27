CREATE FUNCTION [dbo].[TitulosListado]
(
	@ColumnaParaOrdenar VARCHAR(250),
	@Cod VARCHAR(17),
	@ISBN VARCHAR(15),
	@CodigoBarra VARCHAR (50),
	@TituloNombre VARCHAR(50),
	@ProveedorId UNIQUEIDENTIFIER,
	@TemaId INT,
	@AutorId INT,
	@ConStock BIT,
	@SucursalId INT
)
RETURNS TABLE
AS
RETURN

	(SELECT
		Id = T.Id, 
		Cod = T.Cod,
		ISBN = T.ISBN,
		CodigoBarra = T.CodigoBarra,
		NombreTitulo = T.NombreTitulo,
		ProveedorId = T.ProveedorId,
		ProveedorDenominacion = P.Denominacion,
		TemaNombre = TE.Nombre,
		AutorNombre = A.Nombre,
		FechaModificacion = T.FechaModificacion,
		PrecioVentaTitulo  = T.PrecioVentaTitulo,
        PrecioCompraTitulo = T.PrecioCompraTitulo,
        TituloStockStkPr = STK.Propio,
        TituloStockStkCn = STK.Consignado,
		TituloStockStkPrViejo = STKVJO.Propio,
        TituloStockStkCnViejo = STKVJO.Consignado,
        OperadorModificacionUsuario = O.Usuario,
		Fila = ROW_NUMBER() OVER (ORDER BY         
					(CASE UPPER(@ColumnaParaOrdenar)
						-- ORDEN ASC
						WHEN 'COD ASC' THEN T.Cod
						WHEN 'ISBN ASC' THEN T.ISBN
						WHEN 'NOMBRE.TITULO ASC' THEN T.NombreTitulo
						WHEN 'PROVEEDOR.DENOMINACION ASC' THEN P.Denominacion
						WHEN 'TEMA.NOMBRE ASC' THEN TE.Nombre
						WHEN 'AUTOR.NOMBRE ASC' THEN A.Nombre
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
						WHEN 'NOMBRE.TITULO DESC' THEN T.NombreTitulo
						WHEN 'PROVEEDOR.DENOMINACION DESC' THEN P.Denominacion
						WHEN 'TEMA.NOMBRE DESC' THEN TE.Nombre
						WHEN 'AUTOR.NOMBRE DESC' THEN A.Nombre
						WHEN 'PRECIOVENTATITULO DESC' THEN RIGHT('00000000000000000000' +  CONVERT(VARCHAR(10),T.PrecioVentaTitulo),20) 
						WHEN 'PRECIOCOMPRATITULO DESC' THEN RIGHT('00000000000000000000' +  CONVERT(VARCHAR(10),T.PrecioCompraTitulo),20)  
						WHEN 'TITULOSTOCKSTKPR DESC' THEN RIGHT('0000000000' +  CONVERT(VARCHAR(10),STK.Propio),10)
						WHEN 'TITULOSTOCKSTKCN DESC' THEN RIGHT('0000000000' +  CONVERT(VARCHAR(10),STK.Consignado),10)
						WHEN 'TITULOSTOCKSTKPRVIEJO DESC' THEN RIGHT('0000000000' +  CONVERT(VARCHAR(10),STKVJO.Propio),10)
						WHEN 'TITULOSTOCKSTKCNVIEJO DESC' THEN RIGHT('0000000000' +  CONVERT(VARCHAR(10),STKVJO.Consignado),10)
					END) DESC)	
		FROM dbo.Titulos T
			LEFT JOIN Proveedores P 
				ON T.ProveedorId = P.Id
			LEFT JOIN Temas TE
				ON T.TemaId = TE.Id
			LEFT JOIN Autores A
				ON T.AutorId = A.Id
			LEFT JOIN Operadores O
				ON T.OperadorModificacionId = O.Id
			CROSS APPLY (SELECT Consignado = SUM(TSK.StkCn),Propio = SUM(TSK.StkPr) 
						 FROM TitulosStock TSK 
						 WHERE TSK.TituloId = T.Id AND (@SucursalId IS NULL OR @SucursalId = TSK.SucursalId)) STK
			CROSS APPLY (SELECT Consignado = SUM(TSK.StkCn),Propio = SUM(TSK.StkPr) 
						 FROM [LapazMigracion].[dbo].TitulosStock TSK 
						 WHERE TSK.TituloId = T.Id AND (@SucursalId IS NULL OR @SucursalId = TSK.SucursalId)) STKVJO
		WHERE
			(@Cod IS NULL OR @Cod = '' OR T.Cod LIKE '%'+ @Cod +'%')
			AND (@ISBN IS NULL OR @ISBN = '' OR T.ISBN  LIKE '%'+ @ISBN +'%')
			AND (@TituloNombre IS NULL OR @TituloNombre = '' OR T.NombreTitulo LIKE '%'+ @TituloNombre +'%')
			AND (@CodigoBarra IS NULL OR @CodigoBarra = '' OR T.CodigoBarra LIKE '%'+ @CodigoBarra +'%')
			AND (@ProveedorId IS NULL OR T.ProveedorId = @ProveedorId)
			AND (@TemaId IS NULL OR T.TemaId = @TemaId)
			AND (@AutorId IS NULL OR T.AutorId = @AutorId)
			AND (@ConStock IS NULL OR (@ConStock = 1 AND (STK.Consignado > 0 OR STK.Propio > 0) 
								   OR (@ConStock = 0 AND  STK.Consignado = 0 AND STK.Propio = 0)))
)