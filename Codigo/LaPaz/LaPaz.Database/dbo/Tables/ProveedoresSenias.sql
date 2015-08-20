CREATE TABLE [dbo].[ProveedoresSenias] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [ProveedorId]            UNIQUEIDENTIFIER NULL,
    [FechaAlta]              DATETIME         NULL,
    [FechaModificacion]      DATETIME         NULL,
	[FechaAnulacion]         DATETIME         NULL,
	[OperadorAutoriza]       UNIQUEIDENTIFIER NULL,
    [Importe]                MONEY            NULL,
    [ImporteUsado]           MONEY            NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    [TiposComprobantes] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProveedoresSenias_OperadorAlta] FOREIGN KEY ([OperadorAltaId]) REFERENCES [dbo].[Operadores] ([Id]),
    CONSTRAINT [FK_ProveedoresSenias_OperadorModificacion] FOREIGN KEY ([OperadorModificacionId]) REFERENCES [dbo].[Operadores] ([Id]),
    CONSTRAINT [FK_ProveedoresSenias_Proveedor] FOREIGN KEY ([ProveedorId]) REFERENCES [dbo].[Proveedores] ([Id]),
    CONSTRAINT [FK_ProveedoresSenias_SucursalAlta] FOREIGN KEY ([SucursalAltaId]) REFERENCES [dbo].[Sucursales] ([Id]),
    CONSTRAINT [FK_ProveedoresSenias_SucursalModificacion] FOREIGN KEY ([SucursalModificacionId]) REFERENCES [dbo].[Sucursales] ([Id]), 
    CONSTRAINT [FK_ProveedoresSenias_TiposComprobantes] FOREIGN KEY (TiposComprobantes) REFERENCES TiposComprobantes(Id)
);


