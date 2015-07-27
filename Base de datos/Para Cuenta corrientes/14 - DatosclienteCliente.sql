UPDATE [LCorrientes].[dbo].[Clientes]
   SET [LCorrientes].[dbo].[Clientes].[Telefono] =    lapazUsers.dbo.Cliente.Telefono,
   [LCorrientes].[dbo].[Clientes].Mail =    lapazUsers.dbo.Cliente.Email,
   [LCorrientes].[dbo].[Clientes].MandarMail =    lapazUsers.dbo.Cliente.MandarMail,
   [LCorrientes].[dbo].[Clientes].Llamar =    lapazUsers.dbo.Cliente.Llamar
   FROM [LCorrientes].[dbo].[Clientes]  
	INNER JOIN lapazUsers.dbo.Cliente
	on lapazUsers.dbo.Cliente.ClienteId= LCorrientes.dbo.Clientes.Id


