using DataAccessDemo.Models;

namespace DataAccessDemo.Data
{
    public interface ITeamInEventData
    {
        Task DeleteTeamInEvent(string teamId);
        Task<TeamInEvent> InsertTeamInEvent(TeamInEvent teamInEvent);
        Task<TeamInEvent?> GetTeamInEvent(string teamId);
        Task<IEnumerable<TeamInEvent>> GetAllTeamInEvent();
    }
}