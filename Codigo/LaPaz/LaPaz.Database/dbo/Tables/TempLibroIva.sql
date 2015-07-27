CREATE TABLE [dbo].[TempLibroIva] (
    [Iva_Id]    NUMERIC (18)  NOT NULL,
    [TipoLibro] TINYINT       NULL,
    [CompSuc]   TINYINT       NULL,
    [CompId]    NVARCHAR (11) NULL,
    [LCN]       NVARCHAR (13) NULL,
    [nComp]     TINYINT       NULL,
    [Fecha]     SMALLDATETIME NULL,
    [FConta]    SMALLDATETIME NULL,
    [Cpto]      NVARCHAR (50) NULL,
    [Cuit]      NVARCHAR (11) NULL,
    [INetoGrab] REAL          NULL,
    [IExento]   REAL          NULL,
    [IvaTasa1]  REAL          NULL,
    [IvaTasa2]  REAL          NULL,
    [IvaTasa3]  REAL          NULL,
    [ITotal]    REAL          NULL,
    [lCerrado]  TINYINT       NULL,
    CONSTRAINT [PK_S00LibroIva] PRIMARY KEY CLUSTERED ([Iva_Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_S00LibroIva]
    ON [dbo].[TempLibroIva]([TipoLibro] ASC, [CompSuc] ASC, [CompId] ASC, [nComp] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_S00LibroIva_1]
    ON [dbo].[TempLibroIva]([TipoLibro] ASC, [FConta] ASC);

