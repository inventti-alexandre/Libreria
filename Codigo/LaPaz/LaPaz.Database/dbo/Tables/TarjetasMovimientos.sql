CREATE TABLE [dbo].[TarjetasMovimientos] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [CajaMovimientoId]       UNIQUEIDENTIFIER NOT NULL,
    [TarjetaId]              INT              NOT NULL,
    [BancoId]                INT              NULL,
    [TarjetaLiquidacionId]   UNIQUEIDENTIFIER NULL,
    [LoteCupon]              NVARCHAR (15)    NOT NULL,
    [Fecha]                  DATETIME         NOT NULL,
    [Importe]                REAL             NOT NULL,
    [Estado]                 TINYINT          NULL,
    [NroInt]                 INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_TarjetasMovimientos_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TarjetasMovimientos_Tarjetas] FOREIGN KEY ([TarjetaId]) REFERENCES [dbo].[Tarjetas] ([Id]), 
    CONSTRAINT [FK_TarjetasMovimientos_CajaMovimiento] FOREIGN KEY (CajaMovimientoId) REFERENCES CajasMovimientos(Id), 
    CONSTRAINT [FK_TarjetasMovimientos_Banco] FOREIGN KEY (BancoId) REFERENCES Bancos(Id), 
    CONSTRAINT [FK_TarjetasMovimientos_TarjetaLiquidacion] FOREIGN KEY (TarjetaLiquidacionId) REFERENCES TarjetasLiquidacion(Id), 
    CONSTRAINT [FK_TarjetasMovimientos_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_TarjetasMovimientos_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id),
    CONSTRAINT [FK_TarjetasMovimientos_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_TarjetasMovimientos_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00Trj_1]
    ON [dbo].[TarjetasMovimientos]([TarjetaId] ASC, [LoteCupon] ASC, [NroInt] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_s00Trj_2]
    ON [dbo].[TarjetasMovimientos]([Fecha] ASC);

