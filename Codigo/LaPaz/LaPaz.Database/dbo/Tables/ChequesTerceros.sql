CREATE TABLE [dbo].[ChequesTerceros] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [CajaMovimientoId]       UNIQUEIDENTIFIER NOT NULL,
    [BancoId]                INT              NOT NULL,
    [NroCheque]              NVARCHAR (15)    NOT NULL,
    [Fecha]                  DATETIME         NULL,
    [FechaCobro]             DATETIME         NULL,
    [Importe]                REAL             NULL,
    [sTipo]                  INT              NULL,
    [sSuc]                   INT              NULL,
    [sId]                    UNIQUEIDENTIFIER NULL,
    [sFecha]                 DATETIME         NULL,
    [sComprob]               NVARCHAR (20)    NULL,
    [snSec]                  INT              NULL,
    [EstadoChequeId]         INT              NULL,
    [OrdenPagoDetalleId]     UNIQUEIDENTIFIER NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_Cheques] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ChequesTerceros_Bancos] FOREIGN KEY ([BancoId]) REFERENCES [dbo].[Bancos] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_s00Cheques_1]
    ON [dbo].[ChequesTerceros]([BancoId] ASC, [NroCheque] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_s00Cheques_2]
    ON [dbo].[ChequesTerceros]([Fecha] ASC);

