using DataAccessDemo.Models;

namespace DataAccessDemo.Data
{
    public interface IReportData
    {
        Task DeleteReport(int reportId);
        Task<Report?> GetReport(int reportId);
        Task<IEnumerable<Report>> GetReports();
        Task<Report> InsertReport(Report report);
        Task<Report> UpdateReport(Report report);
    }
}