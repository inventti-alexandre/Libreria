CREATE TABLE [dbo].[TitulosConvenio] (
    [ConvenioId] INT              NOT NULL,
    [TituloId]   UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_TitulosConvenio] PRIMARY KEY CLUSTERED ([ConvenioId] ASC, [TituloId] ASC)
);

