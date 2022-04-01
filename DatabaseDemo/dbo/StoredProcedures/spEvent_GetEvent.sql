CREATE PROCEDURE [dbo].[spEvent_GetEvent]
	@Id int
AS
begin
  SELECT * 
  from dbo.[tblEvent]
  where EventId = @Id;
end
