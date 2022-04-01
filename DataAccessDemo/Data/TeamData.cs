using DataAccessDemo.DbAccess;
using DataAccessDemo.Models;

namespace DataAccessDemo.Data
{
    public class TeamData : ITeamData
    {
        private readonly ISqlDataAccess _db;

        public TeamData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<Team>> GetTeams() =>
            _db.LoadData<Team, dynamic>("dbo.spTeam_GetAll", new { });

        public async Task<Team?> GetTeam(string teamId)
        {
            var result = await _db.LoadData<Team, dynamic>(
                "dbo.spTeam_GetTeam",
                new { Id = teamId });
            return result.FirstOrDefault();
        }

        public Task InsertTeam(Team team) =>
            _db.SaveData("dbo.spTeam_Insert", new
            {
                team.TeamId,
                team.TeamName,
                team.PlaceThatTheTeamRepresents,
                team.PasswordHash,
                team.ContactPhone,
                team.Player1,
                team.Player2,
                team.Player3,
                team.Player4,
                team.DateOfRegistration,
                team.Wins,
                team.Losts,
                team.IsInTop5
            });

        public Task UpdateTeam(Team team) =>
            _db.SaveData("dbo.spTeam_Update", team);

        public Task DeleteTeam(string teamId) =>
            _db.SaveData("dbo.spTeam_Delete", new { Id = teamId });

    }
}
