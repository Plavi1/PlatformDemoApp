CREATE PROCEDURE [dbo].[spEvent_Update]
	@EventId int,
	@Place nvarchar(50),
	@NumberOfTeamsInEvent int,
	@DateStart date,
	@DateEnd date,
	@NumberOfMatchesUntilTheEnd int, 
	@NumberOfMatchesPlayed int,
	@IsEventFinished bit
AS
begin
  update dbo.[tblEvent]
  set DateEnd = @DateEnd, DateStart = @DateStart, IsEventFinished = @IsEventFinished, NumberOfMatchesPlayed = @NumberOfMatchesPlayed,
  NumberOfMatchesUntilTheEnd = @NumberOfMatchesUntilTheEnd, NumberOfTeamsInEvent = @NumberOfTeamsInEvent, Place = @Place
  where EventId = @EventId;
end
