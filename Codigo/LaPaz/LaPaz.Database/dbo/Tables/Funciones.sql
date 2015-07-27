CREATE TABLE [dbo].[Funciones] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [Descripcion]            NVARCHAR (50)    NULL,
    [kccodfunc]              NCHAR (12)       NULL,
    [Comentario]             NVARCHAR (50)    NULL,
    [DefinicionTecnica]      NVARCHAR (50)    NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_Funciones] PRIMARY KEY CLUSTERED ([Id] ASC)
);

