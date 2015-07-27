CREATE TABLE [dbo].[Presupuestos] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [Fecha]                  SMALLDATETIME    NULL,
    [Concepto]               NVARCHAR (30)    NULL,
    [LCN]                    NCHAR (13)       NULL,
    [ClienteId]              UNIQUEIDENTIFIER NULL,
    [Descuento]              MONEY            NULL,
    [Total]                  MONEY            NULL,
    [VentaId]                UNIQUEIDENTIFIER NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_Presupuestos] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Presupuestos_Cliente] FOREIGN KEY (ClienteId) REFERENCES Clientes(Id)
);

