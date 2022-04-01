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
                "dbo.spVoteOnWaiting_GetTeam",
                new { Id = teamId });
            return result.FirstOrDefault();
        }

        public Task InsertVoteOnWaiting(VoteOnWaiting voteOnWaiting) =>
            _db.SaveData("dbo.spVoteOnWaiting_Insert", new
            {
                voteOnWaiting.TeamId,
                voteOnWaiting.ChallengeId,
                voteOnWaiting.ExpiringDateForVotes
            });

        public Task UpdateVoteOnWaiting(VoteOnWaiting voteOnWaiting) =>
            _db.SaveData("dbo.spVoteOnWaiting_Update", voteOnWaiting);

        public Task DeleteVoteOnWaiting(string teamId) =>
            _db.SaveData("dbo.spVoteOnWaiting_Delete", new { Id = teamId });

    }
}
