CREATE TABLE [dbo].[ProveedoresBanco] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [ProveedorId]            UNIQUEIDENTIFIER NOT NULL,
    [BancoId]                INT              NULL,
    [CtaCte]                 CHAR (20)        NULL,
    [CajaAhorro]             CHAR (20)        NULL,
    [SucursalAltaId]         INT              NOT NULL,
    [FechaAlta]              DATETIME         NOT NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NOT NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    [Titular] VARCHAR(200) NULL, 
    [CBU] VARCHAR(50) NULL, 
    CONSTRAINT [PK_ProveedoresBanco] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_ProveedoresBanco_Bancos] FOREIGN KEY ([BancoId]) REFERENCES [Bancos]([Id]), 
    CONSTRAINT [FK_ProveedoresBanco_Proveedores] FOREIGN KEY ([ProveedorId]) REFERENCES [Proveedores]([Id]), 
    CONSTRAINT [FK_ProveedoresBanco_SucursalAlta] FOREIGN KEY ([SucursalAltaId]) REFERENCES [Sucursales]([Id])
);

