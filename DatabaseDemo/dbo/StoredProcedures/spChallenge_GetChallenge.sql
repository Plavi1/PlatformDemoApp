CREATE PROCEDURE [dbo].[spChallenge_GetChallenge]
   @Id nvarchar(50)
AS
begin
   SELECT * 
   from dbo.[tblChallenge]
   where ChallengeId = @Id;
end
