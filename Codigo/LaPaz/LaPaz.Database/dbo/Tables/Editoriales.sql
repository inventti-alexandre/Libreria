CREATE TABLE [dbo].[Editoriales] (
    [Id]                     INT              NOT NULL IDENTITY,
    [Nombre]                 VARCHAR (50)     NULL,
    [Domicilio]              VARCHAR (50)     NULL,
    [Email]                  VARCHAR (50)     NULL,
    [Contacto]               VARCHAR (50)     NULL,
    [TE1]                    VARCHAR (20)     NULL,
    [TE2]                    VARCHAR (20)     NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [Activo] BIT NULL  , 
    CONSTRAINT [PK_Editoriales] PRIMARY KEY CLUSTERED ([Id] ASC)
);

