CREATE TABLE [dbo].[PRECIOSACT2] (
    [id]                 UNIQUEIDENTIFIER NOT NULL,
    [PrecioCompraTitulo] MONEY            NULL,
    [PrecioVentaTitulo]  MONEY            NULL,
    [PrcVta1]            REAL             NULL,
    [PrcComp]            REAL             NULL,
    [FeGr]               SMALLDATETIME    NULL,
    [Cod]                NVARCHAR (17)    NULL
);

