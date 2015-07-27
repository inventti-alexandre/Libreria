CREATE TABLE [dbo].[Contactos] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [Denominacion] NVARCHAR (50)    NULL,
    [Domicilio]    NVARCHAR (50)    NULL,
    [Email]        NVARCHAR (50)    NULL,
    [Localidad_Id] INT              NULL,
    [Tel2]         NVARCHAR (20)    NULL,
    [Tel3]         NVARCHAR (20)    NULL,
    [Celular]      NVARCHAR (20)    NULL,
    [Comentarios]  NTEXT            NULL,
    CONSTRAINT [PK_Contactos_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);

