CREATE PROCEDURE [dbo].[spEvent_Delete]
    @Id int
AS
begin
	Delete
	from dbo.[tblEvent]
	where EventId = @Id;
end
