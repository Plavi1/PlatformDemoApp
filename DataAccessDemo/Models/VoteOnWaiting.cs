
namespace DataAccessDemo.Models
{
    public class VoteOnWaiting
    {
        public string TeamId { get; set; }
        public string ChallengeId { get; set; }
        public DateTime ExpiringDateForVotes { get; set; } // Eject an error when i put DateOnly (IN API CALL)
    }
}
