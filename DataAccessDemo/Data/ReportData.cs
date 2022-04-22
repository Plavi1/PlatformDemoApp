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

        public async Task<Report?> GetReport(int reportId)
        {
            var result = await _db.LoadData<Report, dynamic>(
                "dbo.spReport_GetReport",
                new { Id = reportId });
            return result.FirstOrDefault();
        }

        public async Task<Report> InsertReport(Report report)
        {
            await _db.SaveData("dbo.spReport_Insert", new
            {
                report.ReportedTeamId,
                report.SenderTeamId,
                report.ReportMessage
            });

            return report;
        }

        public async Task<Report> UpdateReport(Report report)
        {
            await _db.SaveData("dbo.spReport_Update", report);

            return report;
        }

        public Task DeleteReport(int reportId) =>
            _db.SaveData("dbo.spReport_Delete", new { Id = reportId });
    }
}
