CREATE PROCEDURE [dbo].[spChallenge_Delete]
 @Id nvarchar(50)
AS
begin
	Delete
	from dbo.[tblChallenge]
	where ChallengeId = @Id;
end
