﻿CREATE PROCEDURE [dbo].[spReport_Update]
	@Id int,
	@ReportTeamId nvarchar(50),
	@SenderTeamId nvarchar(50),
	@ReportMessage nvarchar(250)
AS
begin
	update dbo.[tblReport]
	set ReportedTeamId = @ReportTeamId, SenderTeamId = @SenderTeamId, ReportMessage = @ReportMessage
	where ReportId = @Id;
end
