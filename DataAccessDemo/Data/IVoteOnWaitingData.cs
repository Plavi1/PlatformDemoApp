using DataAccessDemo.Models;

namespace DataAccessDemo.Data
{
    public interface IVoteOnWaitingData
    {
        Task DeleteVoteOnWaiting(string teamId);
        Task<VoteOnWaiting?> GetVoteOnWaiting(string teamId);
        Task<IEnumerable<VoteOnWaiting>> GetVotesOnWaiting();
        Task<VoteOnWaiting> InsertVoteOnWaiting(VoteOnWaiting voteOnWaiting);
        Task<VoteOnWaiting> UpdateVoteOnWaiting(VoteOnWaiting voteOnWaiting);
    }
}