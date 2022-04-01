

namespace DataAccessDemo.Models
{
    public class TeamInChallenge
    {
        public string ChallengeId { get; set; }
        public string ChallengerTeamId { get; set; }
        public string ChallengedTeamId { get; set; }
        public int EventId { get; set; }
    }
}
