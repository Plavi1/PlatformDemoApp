CREATE PROCEDURE [dbo].[spTeamInEvent_Delete]
	@TeamId nvarchar(50)
AS
begin
	delete 
	from dbo.[tblTeamInEvent]
	where TeamId = @TeamId;
end
