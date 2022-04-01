CREATE PROCEDURE [dbo].[spTeamInEvent_Insert]
	@TeamId nvarchar(50),
	@EventId int
AS
begin
	insert into dbo.[tblTeamInEvent] (TeamId, EventId)
	values (@TeamId, @EventId)
end
