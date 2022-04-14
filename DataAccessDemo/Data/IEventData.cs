using DataAccessDemo.Models;

namespace DataAccessDemo.Data
{
    public interface IEventData
    {
        Task DeleteEvent(int eventId);
        Task<Event?> GetEvent(int eventId);
        Task<IEnumerable<Event>> GetEvents();
        Task<Event> InsertEvent(Event newEvent);
        Task<Event> UpdateEvent(Event newEvent);
    }
}