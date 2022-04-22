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

        public Task<IEnumerable<Challenge>> GetChallenges()
        {
            var result = _db.LoadData<Challenge, dynamic>("dbo.spChallenge_GetAll", new { });

            return result;
        }

        public async Task<Challenge?> GetChallenge(string challengeId)
        {
            var result = await _db.LoadData<Challenge, dynamic>(
                "dbo.spChallenge_GetChallenge",
                new { Id = challengeId });
            return result.FirstOrDefault();
        }

        public async Task<Challenge> InsertChallenge(Challenge challenge)
        {
            await _db.SaveData("dbo.spChallenge_Insert", new
            {
                challenge.ChallengeId,
                challenge.Time,
                challenge.Date,
                challenge.LocationOfTheBasketballCourt,
                challenge.PlaceOfTeams,
                challenge.NumberOfTimeOrDateChanged,
                challenge.IsChallengeConfirmed,
                challenge.IsChallengeFinished,
                challenge.VotesChallenger,
                challenge.VotesChallenged
            });

            return challenge;
        }

        public async Task<Challenge> UpdateChallenge(Challenge challenge) 
        {
            await _db.SaveData("dbo.spChallenge_Update", challenge);

            return challenge;
        }

        public Task DeleteChallenge(string challengeId) =>
            _db.SaveData("dbo.spChallenge_Delete", new { Id = challengeId });
    }
}
