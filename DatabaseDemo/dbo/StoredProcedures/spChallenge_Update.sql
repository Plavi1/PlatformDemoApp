CREATE PROCEDURE [dbo].[spChallenge_Update]
    @ChallengeId nvarchar(50),
	@Time time,
	@Date date,
	@LocationOfTheBasketballCourt nvarchar(50),
	@PlaceOfTeams nvarchar(50),
	@NumberOfTimeOrDateChanged int,
	@IsChallengeComfirmed bit,
	@IsChallengeFinished bit,
	@VotesChallenger int,
	@VotesChallenged int
AS
begin
   update dbo.[tblChallenge]
   set ChallengeId = @ChallengeId, Date = @Date, Time = @Time, IsChallengeComfirmed = @IsChallengeComfirmed, IsChallengeFinished = @IsChallengeFinished,
   LocationOfTheBasketballCourt = @LocationOfTheBasketballCourt, NumberOfTimeOrDateChanged = @NumberOfTimeOrDateChanged, PlaceOfTeams = @PlaceOfTeams,
   VotesChallenged = @VotesChallenged, VotesChallenger = @VotesChallenger
   where ChallengeId = @ChallengeId;
end