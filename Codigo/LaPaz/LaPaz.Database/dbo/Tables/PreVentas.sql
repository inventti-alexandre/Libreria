CREATE TABLE [dbo].[PreVentas] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [Cliente_Id]       UNIQUEIDENTIFIER NOT NULL,
    [Titulo_Id]        UNIQUEIDENTIFIER NOT NULL,
    [Cantidad]         INT              NULL,
    [CantidadAuditada] INT              NULL,
    [Precio]           MONEY            NULL,
    [FechaGeneracion]  DATETIME         NULL,
    [PC]               NVARCHAR (20)    NULL,
    [Operador_Id]      NVARCHAR (10)    NULL,
    CONSTRAINT [PK_PreVentas] PRIMARY KEY CLUSTERED ([Id] ASC)
);

