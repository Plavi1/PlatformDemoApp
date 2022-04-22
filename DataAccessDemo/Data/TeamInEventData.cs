using DataAccessDemo.DbAccess;
using DataAccessDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Data
{
    public class TeamInEventData : ITeamInEventData
    {
        private readonly ISqlDataAccess _db;

        public TeamInEventData(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<TeamInEvent> InsertTeamInEvent(TeamInEvent teamInEvent)
        {
            await _db.SaveData("dbo.spTeamInEvent_Insert", new
            {
                teamInEvent.EventId,
                teamInEvent.TeamId
            });

            return teamInEvent;
        }

        public Task DeleteTeamInEvent(string teamId) =>
            _db.SaveData("dbo.spTeamInEvent_Delete", new { TeamId = teamId });

        public async Task<TeamInEvent?> GetTeamInEvent(string teamId)
        {
            var result = await _db.LoadData<TeamInEvent, dynamic>(
                "dbo.spTeamInEvent_GetTeamInEvent",
                new { Id = teamId });
            return result.FirstOrDefault();
        }

        public Task<IEnumerable<TeamInEvent>> GetAllTeamInEvent() =>
            _db.LoadData<TeamInEvent, dynamic>("dbo.spTeamInEvent_GetAll", new { });
    }
}
