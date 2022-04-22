CREATE PROCEDURE [dbo].[spTeamInEvent_GetTeamInEvent]
	@Id nvarchar(50)
AS
begin 
	SELECT *
	from dbo.[tblTeamInEvent]
	where TeamId = @Id;
end
