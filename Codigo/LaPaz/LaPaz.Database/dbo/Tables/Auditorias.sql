CREATE TABLE [dbo].[Auditorias] (
    [Id]                      UNIQUEIDENTIFIER NOT NULL,
    [TipoComprobante]         CHAR (1)         NOT NULL,
    [NumeroComprobante]       INT              NOT NULL,
    [FechaComprobante]        DATETIME         NOT NULL,
    [Concepto]                NVARCHAR (50)    NULL,
    [FechaAnulacion]          DATETIME         NULL,
    [Sucursal_Id]             INT              NOT NULL,
    [FechaAlta]               DATETIME         NOT NULL,
    [OperadorAlta_Id]         UNIQUEIDENTIFIER NOT NULL,
    [FechaModificacion]       DATETIME         NULL,
    [OperadorModificacion_Id] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Auditorias] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00RemAudCab_1]
    ON [dbo].[Auditorias]([NumeroComprobante] ASC);

