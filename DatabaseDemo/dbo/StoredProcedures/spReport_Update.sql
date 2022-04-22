CREATE PROCEDURE [dbo].[spReport_Update]
	@ReportId int,
	@ReportedTeamId nvarchar(50),
	@SenderTeamId nvarchar(50),
	@ReportMessage nvarchar(250)
AS
begin
	update dbo.[tblReport]
	set ReportedTeamId = @ReportedTeamId, SenderTeamId = @SenderTeamId, ReportMessage = @ReportMessage
	where ReportId = @ReportId;
end
