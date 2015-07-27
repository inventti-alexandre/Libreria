INSERT INTO [lapaz].[dbo].[users]
           ([usuario]
           ,[password]
           ,[rol]
           ,[lapazUser]
           ,[Sucursal])
SELECT [usuario]
      ,[password]
      ,[rol]
      ,[lapazUser]
      ,[Sucursal]
  FROM [lapazUsers].[dbo].[users]


