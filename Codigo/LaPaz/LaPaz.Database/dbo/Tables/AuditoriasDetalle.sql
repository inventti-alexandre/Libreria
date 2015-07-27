CREATE TABLE [dbo].[AuditoriasDetalle] (
    [ID]           UNIQUEIDENTIFIER NOT NULL,
    [Auditoria_Id] UNIQUEIDENTIFIER NOT NULL,
    [Titulo_Id]    UNIQUEIDENTIFIER NOT NULL,
    [Cantidad]     INT              NULL,
    [PrecioVenta]  MONEY            NULL,
    CONSTRAINT [PK_AuditoriasDetalle] PRIMARY KEY CLUSTERED ([ID] ASC)
);

