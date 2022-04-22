CREATE PROCEDURE [dbo].[spReport_Insert]
	@ReportedTeamId nvarchar(50),
	@SenderTeamId nvarchar(50),
	@ReportMessage nvarchar(250)
AS
begin
	insert into dbo.[tblReport] (ReportedTeamId, SenderTeamId, ReportMessage)
	values (@ReportedTeamId, @SenderTeamId, @ReportMessage)
end
