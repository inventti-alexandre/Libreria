INSERT INTO [lapaz].[dbo].[ComentariosClientes]([Cliente],[Comentario],[baja],[Fecha])
SELECT [Cliente],[Comentario],[baja],[Fecha] FROM [lapazUsers].[dbo].[ComentariosClientes]
GO


