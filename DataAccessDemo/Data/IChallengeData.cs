using DataAccessDemo.Models;

namespace DataAccessDemo.Data
{
    public interface IChallengeData
    {
        Task DeleteChallenge(string challengeId);
        Task<Challenge?> GetChallenge(string challengeId);
        Task<IEnumerable<Challenge>> GetChallenges();
        Task InsertChallenge(Challenge challenge);
        Task UpdateChallenge(Challenge challenge);
    }
}