CREATE PROCEDURE [dbo].[spReport_Insert]
	@ReportTeamId nvarchar(50),
	@SenderTeamId nvarchar(50),
	@ReportMessage nvarchar(250)
AS
begin
	insert into dbo.[tblReport] (ReportedTeamId, SenderTeamId, ReportMessage)
	values (@ReportTeamId, @SenderTeamId, @ReportMessage)
end
