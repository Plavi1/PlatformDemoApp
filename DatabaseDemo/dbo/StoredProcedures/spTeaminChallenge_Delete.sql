CREATE PROCEDURE [dbo].[spTeaminChallenge_Delete]
	@ChallengeId nvarchar(50)
AS
begin
	delete
	from dbo.[tblTeamInChallenge]
	where ChallengeId = @ChallengeId
end
