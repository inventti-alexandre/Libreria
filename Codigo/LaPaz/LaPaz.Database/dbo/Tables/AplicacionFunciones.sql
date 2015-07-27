CREATE TABLE [dbo].[AplicacionFunciones] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [Funcion]          NVARCHAR (12)    NOT NULL,
    [Nombre]           NVARCHAR (50)    NULL,
    [Comentario]       NVARCHAR (50)    NULL,
    [DefincionTecnica] NVARCHAR (50)    NULL,
    CONSTRAINT [PK_AplicacionFunciones] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00Func]
    ON [dbo].[AplicacionFunciones]([Funcion] ASC);

