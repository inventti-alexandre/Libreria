CREATE TABLE [dbo].[OperadoresFunciones] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [OperadorId]             UNIQUEIDENTIFIER NOT NULL,
    [FuncionId]              INT              NOT NULL,
    [Permitido]              BIT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_OperadoresFunciones] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OperadoresFunciones_Funciones] FOREIGN KEY ([FuncionId]) REFERENCES [dbo].[Funciones] ([Id]),
    CONSTRAINT [FK_OperadoresFunciones_Operadores1] FOREIGN KEY ([OperadorId]) REFERENCES [dbo].[Operadores] ([Id])
);

