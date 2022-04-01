
namespace DataAccessDemo.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Place { get; set; }
        public int NumberOfTeamsInEvent { get; set; }
        public DateTime DateStart { get; set; } // Eject an error when i put DateOnly (IN API CALL)
        public DateTime DateEnd { get; set; } // Eject an error when i put DateOnly (IN API CALL)
        public int NumberOfMatchesUntilTheEnd { get; set; }
        public int NumberOfMatchesPlayed { get; set; }
        public bool IsEventFinished { get; set; }
    }
}
