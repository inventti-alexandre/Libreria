CREATE TABLE [dbo].[RegistrosImportaciones] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [SucursalImportacion_Id] INT              NULL,
    [FechaDesde]             DATETIME         NULL,
    [FechaHasta]             DATETIME         NULL,
    [FechaGeneracion]        DATETIME         NULL,
    [Sucursal_Id]            INT              NULL,
    [Operador_id]            UNIQUEIDENTIFIER NULL,
    [PC]                     CHAR (20)        NULL,
    CONSTRAINT [PK_RegistrosImportaciones] PRIMARY KEY CLUSTERED ([Id] ASC)
);

