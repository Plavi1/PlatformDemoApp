CREATE PROCEDURE [dbo].[spTeam_GetTeam]
    @Id nvarchar(50)
AS
begin
	SELECT * 
	from dbo.[tblTeam]
	where TeamId = @Id;
end
