CREATE TABLE [dbo].[TitulosStock] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [TituloId]               UNIQUEIDENTIFIER NOT NULL,
    [SucursalId]             INT              NOT NULL,
    [StkPr]                  INT              NULL,
    [StkCn]                  INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_TitulosStock] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_TitulosStock_Titulo] FOREIGN KEY (TituloId) REFERENCES Titulos(Id), 
    CONSTRAINT [FK_TitulosStock_Sucursal] FOREIGN KEY (SucursalId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_TitulosStock_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_TitulosStock_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_TitulosStock_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_TitulosStock_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00LibStk]
    ON [dbo].[TitulosStock]([TituloId] ASC, [SucursalId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_TitulosStock_Tunning1]
    ON [dbo].[TitulosStock]([TituloId] ASC, [StkPr] ASC, [OperadorModificacionId] ASC, [SucursalId] ASC)
    INCLUDE([StkCn], [FechaModificacion]);

