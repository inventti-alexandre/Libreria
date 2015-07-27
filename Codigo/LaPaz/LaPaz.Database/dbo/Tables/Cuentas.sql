CREATE TABLE [dbo].[Cuentas] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [TipoCuentaId]           INT              NOT NULL,
    [Nombre]                 NVARCHAR (30)    NOT NULL,
    [Descripcion]            NVARCHAR (50)    NULL,
    [BancoPropioId]          INT              NULL,
    [OperadorId]             UNIQUEIDENTIFIER NULL,
    [Titular]                NVARCHAR (50)    NULL,
    [FechaApertura]          DATETIME         NOT NULL,
    [FechaCierre]            DATETIME         NULL,
    [Debitos]                MONEY            NULL,
    [Creditos]               MONEY            NULL,
    [DebitosConciliado]      MONEY            NULL,
    [CreditosConciliado]     MONEY            NULL,
    [SucursalAltaId]         INT              NOT NULL,
    [FechaAlta]              DATETIME         NOT NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NOT NULL,
    [SucursalModificacionId] INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [Activo]                 BIT              NOT NULL DEFAULT 1,
    [EstadoId]               INT              NULL DEFAULT 1,
    CONSTRAINT [PK_Cuentas] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Cuentas_BancosPropios] FOREIGN KEY ([BancoPropioId]) REFERENCES [dbo].[BancosPropios] ([Id]),
    CONSTRAINT [FK_Cuentas_TiposCuenta] FOREIGN KEY ([TipoCuentaId]) REFERENCES [dbo].[TiposCuenta] ([Id]),
	CONSTRAINT [FK_Cuentas_Operadores] FOREIGN KEY ([OperadorId]) REFERENCES [dbo].[Operadores] ([Id]),
	CONSTRAINT [FK_Cuentas_OperadoresAlta] FOREIGN KEY ([OperadorAltaId]) REFERENCES [dbo].[Operadores] ([Id]),
	CONSTRAINT [FK_Cuentas_OperadoresModificacion] FOREIGN KEY ([OperadorModificacionId]) REFERENCES [dbo].[Operadores] ([Id]),
	CONSTRAINT [FK_Cuentas_SucursalAlta] FOREIGN KEY ([SucursalAltaId]) REFERENCES [dbo].[Sucursales] ([Id]),
	CONSTRAINT [FK_Cuentas_SucursalModificacion] FOREIGN KEY ([SucursalModificacionId]) REFERENCES [dbo].[Sucursales] ([Id])
);






GO
CREATE NONCLUSTERED INDEX [IX_s00BcoCtas]
    ON [dbo].[Cuentas]([BancoPropioId] ASC, [Id] ASC);

