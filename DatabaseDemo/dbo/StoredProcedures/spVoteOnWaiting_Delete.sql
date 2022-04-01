CREATE PROCEDURE [dbo].[spVoteOnWaiting_Delete]
	@Id nvarchar(50)
AS
begin
	Delete
	from dbo.[tblVoteOnWaiting]
	where TeamId = @Id;
end
