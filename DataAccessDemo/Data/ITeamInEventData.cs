using DataAccessDemo.Models;

namespace DataAccessDemo.Data
{
    public interface ITeamInEventData
    {
        Task DeleteTeamInEvent(string teamId);
        Task InsertTeamInEvent(TeamInEvent teamInEvent);
    }
}