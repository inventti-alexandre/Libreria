-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Reporte_AutorTitulos_Listado]	
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
	@OchoDeMarzo BIT
AS
BEGIN

DECLARE @Temp TABLE (Id UNIQUEIDENTIFIER, Cod VARCHAR(50), ISBN VARCHAR(50), CodigoBarra VARCHAR(50),
		NombreTitulo VARCHAR(50),
		ProveedorId UNIQUEIDENTIFIER NULL,
		Denominacion VARCHAR(250),
		Nombre VARCHAR(50),
		AutorNombre VARCHAR(50),
		EditorialNombre VARCHAR(50),
		FechaModificacion SMALLDATETIME,
		PrecioVentaTitulo MONEY,
        PrecioCompraTitulo MONEY,
        STKPropio INT,
        STKConsignado INT,
		STKVJOPropio INT,
        STKVJOConsignado INT,
        OUsuario VARCHAR(50),
		OUPUsuario VARCHAR(50))

INSERT INTO @Temp
        ( Id ,
          Cod ,
          ISBN ,
          CodigoBarra ,
          NombreTitulo ,
          ProveedorId ,
          Denominacion ,
          Nombre ,
          AutorNombre ,
          EditorialNombre ,
          FechaModificacion ,
          PrecioVentaTitulo ,
          PrecioCompraTitulo ,
          STKPropio ,
          STKConsignado ,
          STKVJOPropio ,
          STKVJOConsignado ,
          OUsuario ,
          OUPUsuario
        )
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
		OUP.Usuario
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
			AND ((@ConStock IS NULL AND @OchoDeMarzo IS NULL)
						OR (@ConStock = 1 AND @OchoDeMarzo = 1 AND (STK.Consignado > 0 OR STK.Propio > 0 OR STKVJO.Consignado > 0 OR STKVJO.Propio > 0))
						OR (@ConStock = 1 AND @OchoDeMarzo = 0 AND (STK.Consignado > 0 OR STK.Propio > 0 OR STKVJO.Consignado = 0 OR STKVJO.Propio = 0))
						OR (@ConStock = 1 AND @OchoDeMarzo IS NULL AND (STK.Consignado > 0 OR STK.Propio > 0))
						OR (@ConStock = 0 AND @OchoDeMarzo IS NULL AND (STK.Consignado = 0 OR STK.Propio = 0 OR STK.Consignado IS NULL OR STK.Propio IS NULL))
						OR (@ConStock = 0 AND @OchoDeMarzo = 1 AND (STK.Consignado = 0 OR STK.Propio = 0 OR STKVJO.Consignado > 0 OR STKVJO.Propio > 0))
						OR (@ConStock IS NULL AND @OchoDeMarzo = 1 AND (STKVJO.Consignado > 0 OR STKVJO.Propio > 0)) 
						OR (@ConStock = 0 AND @OchoDeMarzo = 0 AND (STK.Consignado = 0 OR STK.Propio = 0 OR STKVJO.Consignado = 0 OR STKVJO.Propio = 0 OR STK.Consignado IS NULL OR STK.Propio IS NULL)) 
						OR (@ConStock IS NULL AND @OchoDeMarzo = 0 AND (STKVJO.Consignado = 0 OR STKVJO.Propio = 0)))


SELECT * FROM @Temp


END