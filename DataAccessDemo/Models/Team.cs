

namespace DataAccessDemo.Models
{
    public class Team
    {
        public string TeamId { get; set; }
        public string TeamName { get; set; }
        public string PlaceThatTheTeamRepresents { get; set; }
        public string PasswordHash { get; set; }
        public int ContactPhone { get; set; }
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public string Player3 { get; set; }
        public string Player4 { get; set; }
        public DateTime DateOfRegistration { get; set; }  // Eject an error when i put DateOnly (IN API CALL)
        public int? Wins { get; set; }
        public int? Lost { get; set; }
        public bool IsInTop5 { get; set; }
    }
}
