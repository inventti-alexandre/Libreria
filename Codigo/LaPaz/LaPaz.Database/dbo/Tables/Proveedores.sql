﻿CREATE TABLE [dbo].[Proveedores] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [Cuenta]                 INT              NULL,
    [Denominacion]           NVARCHAR (80)    NULL,
    [Domicilio]              NCHAR (100)      NULL,
    [Telefono]               CHAR (40)        NULL,
    [Celular]                CHAR (20)        NULL,
    [Fax]                    CHAR (20)        NULL,
    [Contacto]               VARCHAR (50)     NULL,
    [Cuit]                   NVARCHAR (11)    NULL,
    [TipoDocumento]          INT              NULL,
    [ProvinciaId]            INT              NULL,
    [LocalidadId]            INT              NULL,
    [CondicionCompraId]      INT              NULL,
    [PorcentajeDescuento]    MONEY            NULL,
    [Password]               NVARCHAR (15)    NULL,
    [ProveerdorBcoId]        INT              NULL,
    [CBU]                    NVARCHAR (40)    NULL,
    [GrupoProveedorId]       INT              NULL,
    [PaginaWeb]              NVARCHAR (50)    NULL,
    [EmailPedido]            NVARCHAR (50)    NULL,
    [Estado]                 INT              NULL,
    [Comentarios]            NTEXT            NULL,
    [Gto]                    BIT              NULL,
	[Activo]                 BIT              NOT NULL DEFAULT 1,
    [SucursalAltaId]         INT              NOT NULL,
    [FechaAlta]              DATETIME         NOT NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NOT NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    [PersonaContacto] NCHAR(80) NULL, 
    CONSTRAINT [PK_s00Prov_1] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Proveedores_TipoDocumentoIdentidad] FOREIGN KEY (TipoDocumento) REFERENCES TiposDocumentosIdentidad(Id), 
    CONSTRAINT [FK_Proveedores_Provincia] FOREIGN KEY (ProvinciaId) REFERENCES Provincias(Id), 
    CONSTRAINT [FK_Proveedores_Localidad] FOREIGN KEY (LocalidadId) REFERENCES Localidades(Id), 
    CONSTRAINT [FK_Proveedores_CondicionCompra] FOREIGN KEY (CondicionCompraId) REFERENCES CondicionesCompra(Id), 
    CONSTRAINT [FK_Proveedores_ProveedorBanco] FOREIGN KEY (ProveerdorBcoId) REFERENCES Bancos(Id), 
    CONSTRAINT [FK_Proveedores_GrupoProveedor] FOREIGN KEY (GrupoProveedorId) REFERENCES GruposProveedores(Id), 
    CONSTRAINT [FK_Proveedores_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Proveedores_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Proveedores_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Proveedores_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id)
    
   
);

