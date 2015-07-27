CREATE TABLE [dbo].[Aplicacion] (
    [Id]                   INT           NOT NULL,
    [AuditoriaPeriodo]     INT           NULL,
    [AuditoriaCerrado]     INT           NULL,
    [ServidorCorreo]       NVARCHAR (50) NULL,
    [EmailEmpresa]         NVARCHAR (50) NULL,
    [Version]              CHAR (10)     NULL,
    [SucursalEjecucion_Id] INT           NOT NULL,
    CONSTRAINT [PK_s00Parametros] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00Parametros]
    ON [dbo].[Aplicacion]([Id] ASC);

