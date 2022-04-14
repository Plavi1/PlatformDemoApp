using DataAccessDemo.Models;

namespace DataAccessDemo.Data
{
    public interface ITeamData
    {
        Task DeleteTeam(string teamId);
        Task<Team?> GetTeam(string teamId);
        Task<IEnumerable<Team>> GetTeams();
        Task<Team> InsertTeam(Team team);
        Task<Team> UpdateTeam(Team team);
    }
}