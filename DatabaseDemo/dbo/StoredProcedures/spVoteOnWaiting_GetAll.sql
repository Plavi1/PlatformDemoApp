CREATE PROCEDURE [dbo].[spVoteOnWaiting_GetAll]
AS
begin
	SELECT *
	from dbo.[tblVoteOnWaiting]
end
