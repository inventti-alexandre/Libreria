CREATE TABLE [dbo].[s00SueNove] (
    [kcCodOpe] NVARCHAR (10) NOT NULL,
    [nTipo]    TINYINT       NOT NULL,
    [Concepto] NVARCHAR (50) NULL,
    [Cnt]      TINYINT       NULL,
    [Importe]  REAL          NULL,
    [Tot]      REAL          NULL,
    [Coment]   NVARCHAR (50) NULL,
    [Fecha]    SMALLDATETIME NULL,
    [RecSuc]   TINYINT       NULL,
    [RecId]    NVARCHAR (11) NULL,
    [RecLcn]   NVARCHAR (13) NULL,
    CONSTRAINT [PK_s00SueNove] PRIMARY KEY CLUSTERED ([kcCodOpe] ASC, [nTipo] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00SueNove]
    ON [dbo].[s00SueNove]([kcCodOpe] ASC, [nTipo] ASC, [Fecha] ASC);

