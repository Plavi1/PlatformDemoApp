CREATE PROCEDURE [dbo].[spTeam_GetAll]
AS
begin
	SELECT * 
	from dbo.[tblTeam];
end