CREATE PROCEDURE [dbo].[spChallenge_Update]
    @ChallengeId nvarchar(50),
	@Time time,
	@Date date,
	@LocationOfTheBasketballCourt nvarchar(50),
	@PlaceOfTeams nvarchar(50),
	@NumberOfTimeOrDateChanged int,
	@IsChallengeConfirmed bit,
	@IsChallengeFinished bit,
	@VotesChallenger int,
	@VotesChallenged int
AS
begin
   update dbo.[tblChallenge]
   set ChallengeId = @ChallengeId, Date = @Date, Time = @Time, IsChallengeConfirmed = @IsChallengeConfirmed, IsChallengeFinished = @IsChallengeFinished,
   LocationOfTheBasketballCourt = @LocationOfTheBasketballCourt, NumberOfTimeOrDateChanged = @NumberOfTimeOrDateChanged, PlaceOfTeams = @PlaceOfTeams,
   VotesChallenged = @VotesChallenged, VotesChallenger = @VotesChallenger
   where ChallengeId = @ChallengeId;
end