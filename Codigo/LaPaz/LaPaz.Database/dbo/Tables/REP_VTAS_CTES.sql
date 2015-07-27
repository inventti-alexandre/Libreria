CREATE TABLE [dbo].[REP_VTAS_CTES] (
    [ClienteSuc] INT              NOT NULL,
    [Cliente_Id] NUMERIC (18)     NOT NULL,
    [CodTipo]    NVARCHAR (11)    NOT NULL,
    [Desc1]      NVARCHAR (80)    NULL,
    [Desc2]      NVARCHAR (100)   NULL,
    [Libro_Id]   UNIQUEIDENTIFIER NOT NULL,
    [Titulo]     NVARCHAR (50)    NULL,
    [Autor_Id]   NUMERIC (18)     NOT NULL,
    [vp]         INT              NULL,
    [vc]         INT              NULL,
    CONSTRAINT [PK_REP_VTAS_CTES] PRIMARY KEY CLUSTERED ([ClienteSuc] ASC, [Cliente_Id] ASC, [CodTipo] ASC, [Libro_Id] ASC, [Autor_Id] ASC)
);

