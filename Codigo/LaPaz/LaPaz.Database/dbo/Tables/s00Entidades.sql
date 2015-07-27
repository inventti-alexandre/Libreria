CREATE TABLE [dbo].[s00Entidades] (
    [EntidadTipo]  NUMERIC (18)  NOT NULL,
    [Entidad_Id]   NUMERIC (18)  NOT NULL,
    [Cta]          NVARCHAR (30) NULL,
    [cDescrip]     NVARCHAR (50) NULL,
    [Domicilio]    NVARCHAR (50) NULL,
    [Tel1]         NVARCHAR (20) NULL,
    [Tel2]         NVARCHAR (20) NULL,
    [Tel3]         NVARCHAR (20) NULL,
    [Provincia_Id] NUMERIC (18)  NULL,
    [Localidad_Id] NUMERIC (18)  NULL,
    [nMutual]      REAL          NULL,
    [FeGr]         SMALLDATETIME NULL,
    [SucGr]        TINYINT       NULL,
    [OpeGr]        NVARCHAR (20) NULL,
    CONSTRAINT [PK_s00Entidades] PRIMARY KEY CLUSTERED ([EntidadTipo] ASC, [Entidad_Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00Entidades]
    ON [dbo].[s00Entidades]([EntidadTipo] ASC, [Entidad_Id] ASC, [Cta] ASC);


GO
CREATE NONCLUSTERED INDEX [IXs00Entidades]
    ON [dbo].[s00Entidades]([FeGr] ASC);

