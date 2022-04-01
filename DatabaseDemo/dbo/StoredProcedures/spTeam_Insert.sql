CREATE PROCEDURE [dbo].[spTeam_Insert]
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
  insert into dbo.[tblTeam] (PlaceThatTheTeamRepresents, ContactPhone, DateOfRegistration, IsInTop5, Lost,PasswordHash,Player1,Player2,Player3,Player4,TeamId,TeamName,Wins)
  values (@PlaceThatTheTeamRepresents, @ContactPhone, @DateOfRegistration, @IsInTop5, @Lost, @PasswordHash, @Player1, @Player2, @Player3,@Player4, @TeamId,@TeamName,@Wins);
end
