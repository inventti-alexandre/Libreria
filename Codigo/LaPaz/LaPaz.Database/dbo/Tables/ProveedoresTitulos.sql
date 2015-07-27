CREATE TABLE [dbo].[ProveedoresTitulos] (
    [Proveedor_Id] UNIQUEIDENTIFIER NOT NULL,
    [Titulo_Id]    UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_s00ProveedoresLibros_1] PRIMARY KEY CLUSTERED ([Proveedor_Id] ASC, [Titulo_Id] ASC)
);

