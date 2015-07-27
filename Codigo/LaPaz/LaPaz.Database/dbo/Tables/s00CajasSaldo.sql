CREATE TABLE [dbo].[s00CajasSaldo] (
    [CjLugar] TINYINT       NOT NULL,
    [CjOper]  NVARCHAR (10) NOT NULL,
    [CjSuc]   INT           NOT NULL,
    [fpEfc]   REAL          NULL,
    [fpChq]   REAL          NULL,
    [fpnBono] REAL          NULL,
    [nCambio] REAL          NULL,
    [SucGr]   TINYINT       NULL,
    [OpeGr]   NVARCHAR (20) NULL,
    [FeGr]    SMALLDATETIME NULL,
    CONSTRAINT [PK_s00CajaSaldo] PRIMARY KEY CLUSTERED ([CjLugar] ASC, [CjOper] ASC, [CjSuc] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00CajaSaldo]
    ON [dbo].[s00CajasSaldo]([CjOper] ASC);


GO
CREATE NONCLUSTERED INDEX [IXs00CajaSaldo]
    ON [dbo].[s00CajasSaldo]([FeGr] ASC);

