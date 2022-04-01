using DataAccessDemo.Models;

namespace DataAccessDemo.Data
{
    public interface ITeamInChallengeData
    {
        Task DeleteTeamInChallenge(string challengeId);
        Task InsertTeamInChallenge(TeamInChallenge teamInChallenge);
    }
}