CREATE TABLE [dbo].[PRECIOSACT] (
    [Id]                 UNIQUEIDENTIFIER NOT NULL,
    [PrecioCompraTitulo] MONEY            NULL,
    [PrecioVentaTitulo]  MONEY            NULL,
    [PrcVta1]            REAL             NULL,
    [PrcComp]            REAL             NULL,
    [FeGr]               SMALLDATETIME    NULL,
    [Cod]                NVARCHAR (17)    NULL
);

