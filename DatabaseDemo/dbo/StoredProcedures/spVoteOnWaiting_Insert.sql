CREATE PROCEDURE [dbo].[spVoteOnWaiting_Insert]
	@TeamId nvarchar(50),
	@ChallengeId nvarchar(50),
	@ExpiringDateForVotes date
AS
begin
	insert into dbo.[tblVoteOnWaiting] (ChallengeId, TeamId, ExpiringDateForVotes)
	values (@ChallengeId, @TeamId, @ExpiringDateForVotes)
end
