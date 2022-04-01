using DataAccessDemo.DbAccess;
using DataAccessDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Data
{
    public class ReportData : IReportData
    {
        private readonly ISqlDataAccess _db;

        public ReportData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<Report>> GetReports() =>
            _db.LoadData<Report, dynamic>("dbo.spReport_GetAll", new { });

        public async Task<Report?> GetReport(string reportId)
        {
            var result = await _db.LoadData<Report, dynamic>(
                "dbo.spReport_GetTeam",
                new { Id = reportId });
            return result.FirstOrDefault();
        }

        public Task InsertReport(Report report) =>
            _db.SaveData("dbo.spReport_Insert", new
            {
                report.ReportedTeamId,
                report.SenderTeamId,
                report.Message
            });

        public Task UpdateReport(Report report) =>
            _db.SaveData("dbo.spReport_Update", report);

        public Task DeleteReport(string reportId) =>
            _db.SaveData("dbo.spReport_Delete", new { Id = reportId });
    }
}
