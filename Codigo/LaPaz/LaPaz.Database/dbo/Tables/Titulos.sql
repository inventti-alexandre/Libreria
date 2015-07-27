CREATE TABLE [dbo].[Titulos] (
    [Id]                     UNIQUEIDENTIFIER CONSTRAINT [DF_s00Libros_Libro_Id] DEFAULT (newid()) NOT NULL,
    [Cod]                    VARCHAR (17)     NULL,
    [ISBN]                   VARCHAR (15)     NULL,
    [NombreTitulo]           VARCHAR (50)     NULL,
    [ProveedorId]            UNIQUEIDENTIFIER NULL,
    [AutorId]                INT              NULL,
    [EditorialId]            INT              NULL,
    [TemaId]                 INT              NULL,
    [SubtemaId]              INT              NULL,
    [PrecioVentaTitulo]      MONEY            NULL,
    [PrecioCompraTitulo]     MONEY            NULL,
    [CodigoBarra]            VARCHAR (50)     NULL,
    [ISBNg]                  VARCHAR (50)     NULL,
    [FechaAltaTitulo]        DATETIME         NULL,
    [TipoArticuloId]         INT              NULL,
    [ModoStockId]            INT              NULL,
    [TipoTituloId]           INT              NULL,
    [UnidadesId]             INT              NULL,
    [TomosTitulosId]         INT              NULL,
    [EstadoTituloId]         INT              NULL,
    [AdicionalId]            INT              NULL,
    [PesoTitulo]             INT              NULL,
    [PaisId]                 INT              NULL,
    [FechaEdicion]           DATETIME         NULL,
    [IdiomaId]               INT              NULL,
    [PartesId]               INT              NULL,
    [Paginas]                INT              NULL,
    [Encuad]                 INT              NULL,
    [Comentario]             VARCHAR (100)    NULL,
    [StkMin]                 INT              NULL,
    [FUltVta]                DATETIME         NULL,
    [Fingreso]               DATETIME         NULL,
    [nControl]               INT              NULL,
    [UbicacionId]            INT              NULL,
    [TituloUnicoId]          UNIQUEIDENTIFIER NULL,
    [PresentacionId]         INT              NULL,
	[Activo]                 BIT              NOT NULL DEFAULT 1,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [OperadorUltimoPrecioId] UNIQUEIDENTIFIER NULL, 
    CONSTRAINT [PK_s00Libros] PRIMARY KEY NONCLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Titulos_Proveedor] FOREIGN KEY (ProveedorId) REFERENCES Proveedores(Id), 
    CONSTRAINT [FK_Titulos_Autor] FOREIGN KEY (AutorId) REFERENCES Autores(Id), 
    CONSTRAINT [FK_Titulos_Editorial] FOREIGN KEY (EditorialId) REFERENCES Editoriales(Id), 
    CONSTRAINT [FK_Titulos_Tema] FOREIGN KEY (TemaId) REFERENCES Temas(Id), 
    CONSTRAINT [FK_Titulos_SubTema] FOREIGN KEY (SubtemaId) REFERENCES SubTemas(Id), 
    CONSTRAINT [FK_Titulos_TipoArticulo] FOREIGN KEY (TipoArticuloId) REFERENCES TiposTitulos(Id), 
    CONSTRAINT [FK_Titulos_ModoStock] FOREIGN KEY (ModoStockId) REFERENCES TitulosModoStock(Id), 
    CONSTRAINT [FK_Titulos_TipoTitulo] FOREIGN KEY (TipoTituloId) REFERENCES TiposTitulos(Id), 
    CONSTRAINT [FK_Titulos_Unidades] FOREIGN KEY (UnidadesId) REFERENCES Unidades(Id), 
    CONSTRAINT [FK_Titulos_TomosTitulos] FOREIGN KEY (TomosTitulosId) REFERENCES TomosTitulos(Id), 
    CONSTRAINT [FK_Titulos_EstadoTitulo] FOREIGN KEY (EstadoTituloId) REFERENCES EstadosTitulo(Id), 
    CONSTRAINT [FK_Titulos_Adicional] FOREIGN KEY (AdicionalId) REFERENCES TitulosAdicionales(Id), 
    CONSTRAINT [FK_Titulos_Pais] FOREIGN KEY (PaisId) REFERENCES Paises(Id), 
    CONSTRAINT [FK_Titulos_Idioma] FOREIGN KEY (IdiomaId) REFERENCES Idiomas(Id), 
    CONSTRAINT [FK_Titulos_Partes] FOREIGN KEY (PartesId) REFERENCES TitulosPartes(Id), 
    CONSTRAINT [FK_Titulos_Ubicacion] FOREIGN KEY (UbicacionId) REFERENCES Ubicaciones(Id), 
    CONSTRAINT [FK_Titulos_TituloUnico] FOREIGN KEY (TituloUnicoId) REFERENCES TitulosUnicos(Id), 
    CONSTRAINT [FK_Titulos_Presentacion] FOREIGN KEY (PresentacionId) REFERENCES TituloPresentaciones(Id), 
    CONSTRAINT [FK_Titulos_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Titulos_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Titulos_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id),
	CONSTRAINT [FK_Titulos_OperadorModificacion] FOREIGN KEY ([OperadorModificacionId]) REFERENCES Operadores(Id) 
    
);


GO
CREATE NONCLUSTERED INDEX [IX_s00Libros_1]
    ON [dbo].[Titulos]([NombreTitulo] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_s00Libros_2]
    ON [dbo].[Titulos]([AutorId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_s00Libros_3]
    ON [dbo].[Titulos]([CodigoBarra] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_s00Libros_4]
    ON [dbo].[Titulos]([ISBN] ASC);


GO
CREATE NONCLUSTERED INDEX [IXs00Libros]
    ON [dbo].[Titulos]([FechaAlta] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Titulos_Tunning1]
    ON [dbo].[Titulos]([Id] ASC, [ProveedorId] ASC, [AutorId] ASC, [NombreTitulo] ASC)
    INCLUDE([Cod], [TemaId], [PrecioVentaTitulo]);

