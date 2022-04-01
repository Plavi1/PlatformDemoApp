CREATE PROCEDURE [dbo].[spReport_GetAll]
AS
begin
	SELECT * 
	from dbo.[tblReport];
end
