CREATE PROCEDURE [dbo].[spTeamInEvent_GetAll]
AS
BEGIN
	SELECT * 
	FROM dbo.[tblTeamInEvent];
END
