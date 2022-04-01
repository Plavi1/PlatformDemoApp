CREATE PROCEDURE [dbo].[spEvent_GetAll]
AS
begin
  SELECT * 
  from dbo.[tblEvent];
end
