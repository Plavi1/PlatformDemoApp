using DataAccessDemo.DbAccess;
using DataAccessDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Data
{
    public class ChallengeData : IChallengeData
    {
        private readonly ISqlDataAccess _db;

        public ChallengeData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<Challenge>> GetChallenges() =>
            _db.LoadData<Challenge, dynamic>("dbo.spChallenge_GetAll", new { });

        public async Task<Challenge?> GetChallenge(string challengeId)
        {
            var result = await _db.LoadData<Challenge, dynamic>(
                "dbo.spChallenge_GetTeam",
                new { Id = challengeId });
            return result.FirstOrDefault();
        }

        public Task InsertChallenge(Challenge challenge) =>
            _db.SaveData("dbo.spChallenge_Insert", new
            {
                challenge.ChallengeId,
                challenge.Time,
                challenge.Date,
                challenge.LocationOfTheBasketballlCourt,
                challenge.PlaceOfTeams,
                challenge.NumberOfTimeOrDateChanged,
                challenge.isChallangeComfirmed,
                challenge.IsChallengeFinished,
                challenge.VotesChallenger,
                challenge.VotesChallenged
            });

        public Task UpdateChallenge(Challenge challenge) =>
            _db.SaveData("dbo.spChallenge_Update", challenge);

        public Task DeleteChallenge(string challengeId) =>
            _db.SaveData("dbo.spChallenge_Delete", new { Id = challengeId });
    }
}
