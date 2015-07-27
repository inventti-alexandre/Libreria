USE [lapaz]
GO

/****** Object:  StoredProcedure [dbo].[lpu_sp_FiltroParaMail]    Script Date: 15/01/2015 05:31:29 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[lpu_sp_FiltroParaMail] -- @inicio int,  @fin int
	-- Add the parameters for the stored procedure here
	--<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	--<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
  Declare @Primero int
  Declare @Ultimo int
  
  SET @Primero= (SELECT DATEDIFF(dd,GETDATE(),(SELECT Top 1 e.FechaEmail FROM Email e ORDER BY Id DESC))) +3
  SET @Ultimo=3

  SELECT lpc.Denominacion, lpccc.Importe,lpccc.Pagado,(lpccc.Importe-lpccc.Pagado) as Deuda, lpccc.FechaVencimiento,lpuc.Email, lpccc.ClienteId
  FROM [lapaz].[dbo].[ClientesCuentasCorriente] lpccc
  INNER JOIN  [lapaz].[dbo].[Clientes] lpc
  ON lpccc.ClienteId = lpc.Id
  INNER JOIN  [lapazUsers].[dbo].[Cliente] lpuc
  ON lpccc.ClienteId = lpuc.ClienteId
  WHERE
  lpccc.Pagado < lpccc.Importe
  --AND lpccc.FechaVencimiento BETWEEN GETDATE() +2(-30) AND GETDATE()+3
  AND lpccc.FechaVencimiento BETWEEN GETDATE() +@Primero AND GETDATE()+@Ultimo
  AND lpuc.MandarMail=1
  order by lpccc.FechaVencimiento desc
END

GO


