using DataAccessDemo.DbAccess;
using DataAccessDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Data
{
    public class VoteOnWaitingData : IVoteOnWaitingData
    {
        private readonly ISqlDataAccess _db;

        public VoteOnWaitingData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<VoteOnWaiting>> GetVotesOnWaiting() =>
            _db.LoadData<VoteOnWaiting, dynamic>("dbo.spVoteOnWaiting_GetAll", new { });

        public async Task<VoteOnWaiting?> GetVoteOnWaiting(string teamId)
        {
            var result = await _db.LoadData<VoteOnWaiting, dynamic>(
                "dbo.spVoteOnWaiting_GetVote",
                new { Id = teamId });
            return result.FirstOrDefault();
        }

        public async Task<VoteOnWaiting> InsertVoteOnWaiting(VoteOnWaiting voteOnWaiting)
        {
            await _db.SaveData("dbo.spVoteOnWaiting_Insert", new
            {
                voteOnWaiting.TeamId,
                voteOnWaiting.ChallengeId,
                voteOnWaiting.ExpiringDateForVotes
            });

            return voteOnWaiting;
        }

        public async Task<VoteOnWaiting> UpdateVoteOnWaiting(VoteOnWaiting voteOnWaiting)
        {
            await _db.SaveData("dbo.spVoteOnWaiting_Update", voteOnWaiting);

            return voteOnWaiting;
        }

        public Task DeleteVoteOnWaiting(string teamId) =>
            _db.SaveData("dbo.spVoteOnWaiting_Delete", new { Id = teamId });

    }
}
