CREATE PROCEDURE [dbo].[spReport_GetReport]
	@Id int
AS
begin 
	SELECT *
	from dbo.[tblReport]
	where ReportId = @Id;
end
