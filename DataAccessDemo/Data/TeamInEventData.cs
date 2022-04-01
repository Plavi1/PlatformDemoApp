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

        public Task InsertTeamInEvent(TeamInEvent teamInEvent) =>
            _db.SaveData("dbo.spTeamInEvent_Insert", new
            {
                teamInEvent.EventId,
                teamInEvent.TeamId
            });

        public Task DeleteTeamInEvent(string teamId) =>
            _db.SaveData("dbo.spTeamInEvent_Delete", new { TeamId = teamId });
    }
}
