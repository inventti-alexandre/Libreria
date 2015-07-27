CREATE TABLE [dbo].[TitulosConsignaciones] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [TituloId]               UNIQUEIDENTIFIER NULL,
    [ClienteId]              UNIQUEIDENTIFIER NULL,
    [ProveedorId]            UNIQUEIDENTIFIER NULL,
    [TipoConsignacion]       INT              NULL,
    [CntPr]                  INT              NOT NULL DEFAULT 0,
    [CntCn]                  INT              NOT NULL DEFAULT 0,
    [CntVn]                  INT              NOT NULL DEFAULT 0,
	[CntDev]                  INT              NOT NULL DEFAULT 0,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_TitulosConsignaciones] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_TitulosConsignaciones_Titulo] FOREIGN KEY (TituloId) REFERENCES Titulos(Id), 
    CONSTRAINT [FK_TitulosConsignaciones_Cliente] FOREIGN KEY (ClienteId) REFERENCES Clientes(Id), 
    CONSTRAINT [FK_TitulosConsignaciones_Proveedor] FOREIGN KEY (ProveedorId) REFERENCES Proveedores(Id), 
    CONSTRAINT [FK_TitulosConsignaciones_TipoConsignacion] FOREIGN KEY (TipoConsignacion) REFERENCES TiposConsignaciones(Id), 
    CONSTRAINT [FK_TitulosConsignaciones_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_TitulosConsignaciones_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_TitulosConsignaciones_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_TitulosConsignaciones_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id)
    
);

