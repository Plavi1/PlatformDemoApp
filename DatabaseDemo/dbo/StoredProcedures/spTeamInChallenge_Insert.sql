CREATE PROCEDURE [dbo].[spTeamInChallenge_Insert]
    @ChallengeId nvarchar(50),
	@ChallengerTeamId nvarchar(50),
	@ChallengedTeamId nvarchar(50),
	@EventId int
AS
begin
	insert into dbo.[tblTeamInChallenge] (ChallengedTeamId, ChallengerTeamId, ChallengeId, EventId)
	values (@ChallengedTeamId, @ChallengerTeamId, @ChallengeId, @EventId)
end
