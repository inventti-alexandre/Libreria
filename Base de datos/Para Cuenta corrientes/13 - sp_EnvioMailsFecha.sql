USE [lapaz]
GO

/****** Object:  StoredProcedure [dbo].[lpu_sp_EnvioMailsFecha]    Script Date: 15/01/2015 05:31:23 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[lpu_sp_EnvioMailsFecha] @fecha datetime
	-- Add the parameters for the stored procedure here
	--<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	--<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT lpc.Denominacion,lpue.FechaEmail,lpue.FechaVencimiento,lpue.Saldo,lpue.Email
FROM [lapazUsers].[dbo].[Email] lpue
INNER JOIN  [lapaz].[dbo].[Clientes] lpc
ON lpue.ClienteId = lpc.Id
WHERE lpue.fechaemail between @fecha and @fecha +1
order by FechaEmail desc
END

GO


