using DataAccessDemo.DbAccess;
using DataAccessDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Data
{
    public class EventData : IEventData
    {
        private readonly ISqlDataAccess _db;

        public EventData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<Event>> GetEvents() =>
           _db.LoadData<Event, dynamic>("dbo.spEvent_GetAll", new { });

        public async Task<Event?> GetEvent(int eventId)
        {
            var result = await _db.LoadData<Event, dynamic>(
                "dbo.spEvent_GetEvent",
                new { Id = eventId });
            return result.FirstOrDefault();
        }

        public async Task<Event> InsertEvent(Event newEvent)
        {
            await _db.SaveData("dbo.spEvent_Insert", new
            {
                newEvent.Place,
                newEvent.NumberOfTeamsInEvent,
                newEvent.DateStart,
                newEvent.DateEnd,
                newEvent.NumberOfMatchesUntilTheEnd,
                newEvent.NumberOfMatchesPlayed,
                newEvent.IsEventFinished
            });

            return newEvent;
        }

        public async Task<Event> UpdateEvent(Event newEvent)
        {
            await _db.SaveData("dbo.spEvent_Update", newEvent);

            return newEvent;
        }

        public Task DeleteEvent(int eventId) =>
            _db.SaveData("dbo.spEvent_Delete", new { Id = eventId });
    }
}
