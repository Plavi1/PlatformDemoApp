CREATE PROCEDURE [dbo].[spReport_Delete]
	@Id int
AS
begin
	Delete
	from dbo.[tblReport]
	where ReportId = @Id
end
