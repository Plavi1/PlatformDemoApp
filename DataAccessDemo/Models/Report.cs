

namespace DataAccessDemo.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public string ReportedTeamId { get; set; }
        public string SenderTeamId { get; set; }
        public string Message { get; set; }
    }
}
