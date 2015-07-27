CREATE TABLE [dbo].[Numeradores] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [SucursalId]             INT              NOT NULL,
    [TipoNumeradorId]        INT              NOT NULL,
    [LCN]                    NVARCHAR (13)    NULL,
    [UltimoNumero]           INT              NULL,
    [Copias]                 TINYINT          NULL,
    [ImpresoraPath]          NVARCHAR (100)   NULL,
    [ImpresoraPath2]         NVARCHAR (100)   NULL,
    [ImpresoraPuerto]        NVARCHAR (30)    NULL,
    [ImpresoraPuerto2]       NVARCHAR (50)    NULL,
    [Lpt1Computadora]        NVARCHAR (50)    NULL,
    [Lpt2Computadora]        NVARCHAR (50)    NULL,
    [Lpt3Computadora]        NVARCHAR (50)    NULL,
    [Lpt4Computadora]        NVARCHAR (50)    NULL,
    [PcGr]                   NVARCHAR (20)    NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Numeradores_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00Numerador]
    ON [dbo].[Numeradores]([SucursalId] ASC, [TipoNumeradorId] ASC);

