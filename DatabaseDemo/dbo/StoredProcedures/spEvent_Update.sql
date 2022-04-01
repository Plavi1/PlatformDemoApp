CREATE PROCEDURE [dbo].[spEvent_Update]
	@Id int,
	@Place nvarchar(50),
	@NumberOfTeamsInEvent int,
	@DateStart date,
	@DateEnd date,
	@NumberOfMatchesUntilTheEnd int, 
	@NumberOfMathchesPlayed int,
	@IsEventFinished bit
AS
begin
  update dbo.[tblEvent]
  set DateEnd = @DateEnd, DateStart = @DateStart, IsEventFinished = @IsEventFinished, NumberOfMatchesPlayed = @NumberOfMathchesPlayed,
  NumberOfMatchesUntilTheEnd = @NumberOfMatchesUntilTheEnd, NumberOfTeamsInEvent = @NumberOfTeamsInEvent, Place = @Place
  where EventId = @Id;
end
