CREATE PROCEDURE [dbo].[spTeam_Update]
	@TeamId nvarchar(50),
    @TeamName nvarchar(50),
    @PlaceThatTheTeamRepresents nvarchar(50),
    @PasswordHash nvarchar(50),
    @ContactPhone int,
    @Player1 nvarchar(50),
    @Player2 nvarchar(50),
    @Player3 nvarchar(50),
    @Player4 nvarchar(50),
    @DateOfRegistration date,
    @Wins int,
    @Lost int,
    @IsInTop5 bit
AS
begin
   update dbo.[tblTeam]
   set TeamId = @TeamId, ContactPhone = @ContactPhone, DateOfRegistration = @DateOfRegistration, IsInTop5 = @IsInTop5,
   Lost = @Lost, PasswordHash = @PasswordHash , Player1 = @Player1, Player2 = @Player2, Player3 = @Player3, Player4 = @Player4,
   TeamName = @TeamName, Wins = @Wins
   where TeamId = @TeamId;
end
