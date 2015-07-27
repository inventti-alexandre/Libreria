CREATE TABLE [dbo].[s00SucCnExp] (
    [CodSuc] INT           NOT NULL,
    [Fecha]  SMALLDATETIME NOT NULL,
    CONSTRAINT [PK_s00SucCnExp] PRIMARY KEY CLUSTERED ([CodSuc] ASC, [Fecha] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00SucCnExp]
    ON [dbo].[s00SucCnExp]([CodSuc] ASC, [Fecha] ASC);

