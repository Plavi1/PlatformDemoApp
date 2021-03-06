CREATE PROCEDURE [dbo].[spChallenge_Insert]
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
	insert into dbo.[tblChallenge] (ChallengeId,Date,Time,IsChallengeConfirmed,IsChallengeFinished,LocationOfTheBasketballCourt,NumberOfTimeOrDateChanged,PlaceOfTeams,VotesChallenged,VotesChallenger)
	values(@ChallengeId, @Date, @Time, @IsChallengeConfirmed, @IsChallengeFinished, @LocationOfTheBasketballCourt, @NumberOfTimeOrDateChanged, @PlaceOfTeams, @VotesChallenged,@VotesChallenger)
end
