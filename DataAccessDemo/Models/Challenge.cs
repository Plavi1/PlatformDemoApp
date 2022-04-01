
namespace DataAccessDemo.Models
{
    public class Challenge
    {
        public string ChallengeId { get; set; }
        public DateTime Time { get; set; }  // Eject an error when i put TimeOnly (IN API CALL)
        public DateTime Date { get; set; }  // Eject an error when i put DateOnly (IN API CALL)
        public string LocationOfTheBasketballlCourt { get; set; }
        public string PlaceOfTeams { get; set; }
        public int NumberOfTimeOrDateChanged { get; set; }
        public bool isChallangeComfirmed { get; set; }
        public bool IsChallengeFinished { get; set; }
        public int VotesChallenger { get; set; }
        public int VotesChallenged { get; set; }
    }
}
