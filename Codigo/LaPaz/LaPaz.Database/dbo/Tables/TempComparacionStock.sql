CREATE TABLE [dbo].[TempComparacionStock] (
    [Libro_Id] UNIQUEIDENTIFIER NOT NULL,
    [CodSuc]   INT              NOT NULL,
    [StkPr]    SMALLINT         NULL,
    [StkCn]    SMALLINT         NULL,
    [StkAud]   SMALLINT         NULL,
    [FeGr]     SMALLDATETIME    NULL,
    [FeGrAud]  SMALLDATETIME    NULL,
    CONSTRAINT [PK_s00LibStkComp] PRIMARY KEY CLUSTERED ([Libro_Id] ASC, [CodSuc] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00LibStkComp]
    ON [dbo].[TempComparacionStock]([Libro_Id] ASC, [CodSuc] ASC);

