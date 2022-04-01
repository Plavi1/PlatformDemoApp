CREATE PROCEDURE [dbo].[spVoteOnWaiting_GetVote]
	@Id nvarchar(50)
AS
begin
	SELECT *
	from dbo.[tblVoteOnWaiting]
	where TeamId = @Id;
end
