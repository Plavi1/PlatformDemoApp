using DataAccessDemo.Models;

namespace DataAccessDemo.Data
{
    public interface IEventData
    {
        Task DeleteEvent(string eventId);
        Task<Event?> GetEvent(string eventId);
        Task<IEnumerable<Event>> GetEvents();
        Task InsertEvent(Event newEvent);
        Task UpdateEvent(Event newEvent);
    }
}