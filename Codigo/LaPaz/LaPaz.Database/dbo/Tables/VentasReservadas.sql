CREATE TABLE [dbo].[VentasReservadas] (
    [NroReserva]             INT              IDENTITY (1, 1) NOT NULL,
    [SucReserva]             INT              NOT NULL,
    [NroLote]                INT              NOT NULL,
    [LCN]                    CHAR (13)        NOT NULL,
	[Comentario] NVARCHAR(MAX) NULL, 
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,

    CONSTRAINT [PK_VtaReservadas] PRIMARY KEY CLUSTERED ([NroReserva] ASC, [SucReserva] ASC), 
    CONSTRAINT [FK_VentasReservadas_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_VentasReservadas_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_VentasReservadas_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_VentasReservadas_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id)
);

