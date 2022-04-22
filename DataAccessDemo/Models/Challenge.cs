
namespace DataAccessDemo.Models
{
    public class Challenge
    {
        public string ChallengeId { get; set; }
        public TimeSpan Time { get; set; }  // Eject an error when i put TimeOnly (IN API CALL), can't work with DateTime 
        public DateTime Date { get; set; }  // Eject an error when i put DateOnly (IN API CALL)
        public string LocationOfTheBasketballCourt { get; set; }
        public string PlaceOfTeams { get; set; }
        public int NumberOfTimeOrDateChanged { get; set; }
        public bool IsChallengeConfirmed { get; set; }
        public bool IsChallengeFinished { get; set; }
        public int VotesChallenger { get; set; }
        public int VotesChallenged { get; set; }
    }
}
