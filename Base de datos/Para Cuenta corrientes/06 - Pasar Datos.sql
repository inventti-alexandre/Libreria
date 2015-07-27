INSERT INTO [lapaz].[dbo].[Email] ([ClienteId],[FechaEmail],[Email],[Saldo],[FechaVencimiento])
SELECT [ClienteId]
      ,[FechaEmail]
      ,[Email]
      ,[Saldo]
      ,[FechaVencimiento]
  FROM [lapazUsers].[dbo].[Email]