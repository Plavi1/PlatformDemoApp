using DataAccessDemo.DbAccess;
using DataAccessDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Data
{
    public class TeamInChallengeData : ITeamInChallengeData
    {
        private readonly ISqlDataAccess _db;

        public TeamInChallengeData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task InsertTeamInChallenge(TeamInChallenge teamInChallenge) =>
            _db.SaveData("dbo.spTeamInChallenge_Insert", new
            {
                teamInChallenge.ChallengeId,
                teamInChallenge.ChallengerTeamId,
                teamInChallenge.ChallengedTeamId,
                teamInChallenge.EventId
            });

        public Task DeleteTeamInChallenge(string challengeId) =>
            _db.SaveData("dbo.spTeamInChallenge_Delete", new { ChallengeId = challengeId });
    }
}
