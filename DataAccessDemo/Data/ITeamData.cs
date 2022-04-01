using DataAccessDemo.Models;

namespace DataAccessDemo.Data
{
    public interface ITeamData
    {
        Task DeleteTeam(string teamId);
        Task<Team?> GetTeam(string teamId);
        Task<IEnumerable<Team>> GetTeams();
        Task InsertTeam(Team team);
        Task UpdateTeam(Team team);
    }
}