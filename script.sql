USE [A_Hospital]
GO
/****** Object:  StoredProcedure [dbo].[apiCIE10]    Script Date: 17/09/2018 10:25:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[apiCIE10] 
	-- Add the parameters for the stored procedure here|
		@Op int = 0,
		@value varchar(120)=''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT off;

 	if(@Op=1)
		begin
		select top 20 db29179_cie10.id10,db29179_cie10.dec10 from [dbo].[db29179_cie10] where dec10 like  @value+'%' 
		end
END

GO
