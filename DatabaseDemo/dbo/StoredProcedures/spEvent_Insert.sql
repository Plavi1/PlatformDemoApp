﻿CREATE PROCEDURE [dbo].[spEvent_Insert]
    @Place nvarchar(50),
	@NumberOfTeamsInEvent int,
	@DateStart date,
	@DateEnd date,
	@NumberOfMatchesUntilTheEnd int, 
	@NumberOfMathchesPlayed int,
	@IsEventFinished bit
AS
begin
	insert into dbo.[tblEvent] (DateEnd, DateStart, IsEventFinished, NumberOfMatchesPlayed,NumberOfMatchesUntilTheEnd,NumberOfTeamsInEvent, Place)
	values( @DateEnd, @DateStart, @IsEventFinished, @NumberOfMathchesPlayed, @NumberOfMatchesUntilTheEnd, @NumberOfTeamsInEvent, @Place)
end
