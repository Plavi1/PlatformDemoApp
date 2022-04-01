CREATE PROCEDURE [dbo].[spVoteOnWaiting_Update]
	@TeamId nvarchar(50),
	@ChallengeId nvarchar(50),
	@ExpiringDateForVotes date
AS
begin
	update dbo.[tblVoteOnWaiting]
	set TeamId = @TeamId, ChallengeId = @ChallengeId, ExpiringDateForVotes = @ExpiringDateForVotes
	where TeamId = @TeamId;
end
