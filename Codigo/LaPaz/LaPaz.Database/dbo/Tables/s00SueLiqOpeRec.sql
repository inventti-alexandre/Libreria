CREATE TABLE [dbo].[s00SueLiqOpeRec] (
    [LiquidacionSuc] INT           NOT NULL,
    [Liquidacion_Id] NUMERIC (18)  NOT NULL,
    [kcCodOpe]       NVARCHAR (10) NOT NULL,
    [Tot]            REAL          NULL,
    [RecSuc]         TINYINT       NULL,
    [RecId]          NVARCHAR (11) NULL,
    [RecLcn]         NVARCHAR (13) NULL,
    CONSTRAINT [PK_s00SueLiqOpeRec] PRIMARY KEY CLUSTERED ([LiquidacionSuc] ASC, [Liquidacion_Id] ASC, [kcCodOpe] ASC)
);

