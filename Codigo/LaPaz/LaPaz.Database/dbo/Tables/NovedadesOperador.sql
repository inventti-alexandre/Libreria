CREATE TABLE [dbo].[NovedadesOperador] (
    [LiquidacionSuc] INT           NOT NULL,
    [Liquidacion_Id] NUMERIC (18)  NOT NULL,
    [kcCodOpe]       NVARCHAR (10) NOT NULL,
    [Importe]        REAL          NULL,
    [ImpPag]         REAL          NULL,
    CONSTRAINT [PK_s00SueLiqOpe] PRIMARY KEY CLUSTERED ([LiquidacionSuc] ASC, [Liquidacion_Id] ASC, [kcCodOpe] ASC)
);

