CREATE TABLE [dbo].[Ventas] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [LCN]                    VARCHAR (13)     NOT NULL,
    [ComprobanteId]          INT              NOT NULL,
    [ClienteId]              UNIQUEIDENTIFIER NOT NULL,
    [LetraComprobante]       CHAR (1)         NOT NULL,
    [PuntoVenta]             INT              NOT NULL,
    [NumeroComprobante]      INT              NOT NULL,
    [FechaComprobante]       DATETIME         NULL,
    [FechaVencimiento]       DATETIME         NULL,
    [CondicionVentaId]       INT              NULL,
    [Concepto]               NVARCHAR (50)    NULL,
    [ImporteNeto]            MONEY            NOT NULL,
    [ImporteIva]             MONEY            NOT NULL,
    [ImporteSena]            MONEY            NULL,
    [FechaUltimoPago]        DATETIME         NULL,
    [TotalPagado]            MONEY            NULL,
    [EstadoVentaId]          INT              NOT NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [OperadorAutoriza]       UNIQUEIDENTIFIER NULL,
    [ValidacionUsuario]      NVARCHAR (50)    NULL,
    CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Ventas_Comprobante] FOREIGN KEY (ComprobanteId) REFERENCES TiposComprobantes(id), 
    CONSTRAINT [FK_Ventas_Cliente] FOREIGN KEY (ClienteId) REFERENCES Clientes(Id), 
    CONSTRAINT [FK_Ventas_CondicionVenta] FOREIGN KEY (CondicionVentaId) REFERENCES CondicionesVenta(Id), 
    CONSTRAINT [FK_Ventas_EstadoVenta] FOREIGN KEY (EstadoVentaId) REFERENCES EstadosVenta(Id), 
    CONSTRAINT [FK_Ventas_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Ventas_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
	CONSTRAINT [FK_Ventas_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Ventas_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Ventas_OperadorAutoriza] FOREIGN KEY (OperadorAutoriza) REFERENCES Operadores(Id)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00FacVtaCab_3]
    ON [dbo].[Ventas]([LetraComprobante] ASC, [ComprobanteId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_s00FacVtaCab_4]
    ON [dbo].[Ventas]([FechaComprobante] ASC);

