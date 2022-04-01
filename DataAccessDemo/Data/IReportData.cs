using DataAccessDemo.Models;

namespace DataAccessDemo.Data
{
    public interface IReportData
    {
        Task DeleteReport(string reportId);
        Task<Report?> GetReport(string reportId);
        Task<IEnumerable<Report>> GetReports();
        Task InsertReport(Report report);
        Task UpdateReport(Report report);
    }
}