CREATE TABLE [dbo].[TiposGastos] (
    [Id]                     INT              NOT NULL IDENTITY,
    [Nombre]                 NVARCHAR (50)    NOT NULL,
    [Abreviatura]            NVARCHAR (10)    NULL,
    [Descripcion]            NVARCHAR (50)    NULL,
    [BienDeUso]              BIT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_s00Gasto] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_TiposGastos_SucursalesAlta] FOREIGN KEY ([SucursalAltaId]) REFERENCES [Sucursales]([Id]), 
    CONSTRAINT [FK_TiposGastos_SucursalesModificacion] FOREIGN KEY ([SucursalAltaId]) REFERENCES [Sucursales]([Id]), 
    CONSTRAINT [FK_TiposGastos_OperadoresAlta] FOREIGN KEY ([OperadorAltaId]) REFERENCES [Operadores]([Id]), 
    CONSTRAINT [FK_TiposGastos_OperadoresModificacion] FOREIGN KEY ([OperadorAltaId]) REFERENCES [Operadores]([Id])

);


GO
CREATE NONCLUSTERED INDEX [IX_s00Gasto]
    ON [dbo].[TiposGastos]([Id] ASC);

