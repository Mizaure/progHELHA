USE [Info2020]
GO
/****** Object:  StoredProcedure [dbo].[LoginVerify]    Script Date: 30/09/2019 14:49:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[LoginVerify] 
	-- Add the parameters for the stored procedure here
@UserID nvarchar(50),
@Passwd nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Count(0) FROM DBO.Users WHERE UserID = @UserID AND Passwd = @Passwd; 
END























