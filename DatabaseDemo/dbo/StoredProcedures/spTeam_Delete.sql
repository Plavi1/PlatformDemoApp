CREATE PROCEDURE [dbo].[spTeam_Delete]
    @Id nvarchar(50)
AS
begin
	Delete
	from dbo.[tblTeam]
	where TeamId = @Id;
end
