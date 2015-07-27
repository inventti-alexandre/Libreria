CREATE TABLE [dbo].[OrdenPagoCheques] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [OrdenPagoId]            UNIQUEIDENTIFIER NOT NULL,
    [ChequeTerceroId]        UNIQUEIDENTIFIER NOT NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_OrdenPagoCheques] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OrdenPagoCheques_ChequesTerceros1] FOREIGN KEY ([ChequeTerceroId]) REFERENCES [dbo].[ChequesTerceros] ([Id]),
    CONSTRAINT [FK_OrdenPagoCheques_OrdenesPagoComprobantes] FOREIGN KEY ([OrdenPagoId]) REFERENCES [dbo].[OrdenesPagoComprobantes] ([Id]),
	CONSTRAINT [FK_OrdenPagoCheques_SucursalesAlta] FOREIGN KEY ([SucursalAltaId]) REFERENCES [dbo].[Sucursales]([Id]), 
	CONSTRAINT [FK_OrdenPagoCheques_SucursalesModificacion] FOREIGN KEY ([SucursalModificacionId]) REFERENCES [dbo].[Sucursales]([Id]), 
	CONSTRAINT [FK_OrdenPagoCheques_OperadoresAlta] FOREIGN KEY ([OperadorAltaId]) REFERENCES [dbo].[Operadores]([Id]), 
	CONSTRAINT [FK_OrdenPagoCheques_OperadoresModificacion] FOREIGN KEY ([OperadorModificacionId]) REFERENCES [dbo].[Operadores]([Id])
);

