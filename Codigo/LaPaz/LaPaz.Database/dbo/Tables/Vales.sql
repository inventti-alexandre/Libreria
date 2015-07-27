CREATE TABLE [dbo].[Vales] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [CajaId]                 UNIQUEIDENTIFIER NULL,
    [MutualId]               INT              NULL,
    [NroVale]                NVARCHAR (15)    NULL,
    [Fecha]                  DATETIME         NULL,
    [Importe]                MONEY            NULL,
    [OperadorCajaId]         UNIQUEIDENTIFIER NULL,
    [sTipo]                  INT              NULL,
    [sSuc]                   INT              NULL,
    [sId]                    NVARCHAR (11)    NULL,
    [sFecha]                 DATETIME         NULL,
    [sComprob]               NVARCHAR (20)    NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [OperadorAutoriza]       UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Vales] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Vales_Mutuales] FOREIGN KEY ([MutualId]) REFERENCES [dbo].[Mutuales] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_s00Vales]
    ON [dbo].[Vales]([MutualId] ASC, [NroVale] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_s00Vales_1]
    ON [dbo].[Vales]([Fecha] ASC);

