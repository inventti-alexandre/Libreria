CREATE TABLE [dbo].[RegistrosExportaciones] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [SucursalExportacion_Id] INT              NULL,
    [FechaDesde]             DATETIME         NULL,
    [FechaHasta]             DATETIME         NULL,
    [FechaGeneracion]        DATETIME         NULL,
    [Sucursal_Id]            INT              NULL,
    [Operador_id]            UNIQUEIDENTIFIER NULL,
    [PC]                     NVARCHAR (20)    NULL,
    CONSTRAINT [PK_RegistrosExportaciones] PRIMARY KEY CLUSTERED ([Id] ASC)
);

