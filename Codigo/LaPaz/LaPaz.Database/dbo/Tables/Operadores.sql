CREATE TABLE [dbo].[Operadores] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [Usuario]                NVARCHAR (10)    NOT NULL,
    [Clave]                  NVARCHAR (64)    NULL,
    [VigenteDesde]           DATETIME         NULL,
    [VigenteHasta]           DATETIME         NULL,
    [PersonalId]             UNIQUEIDENTIFIER NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    [Habilitado] BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [PK_Operadores_1] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Operadores_Personal] FOREIGN KEY ([PersonalId]) REFERENCES [Personal]([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_s00Oper]
    ON [dbo].[Operadores]([Usuario] ASC);

