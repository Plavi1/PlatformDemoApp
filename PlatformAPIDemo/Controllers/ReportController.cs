using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PlatformAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportData reportData;

        public ReportController(IReportData reportData)
        {
            this.reportData = reportData;
        }

        [HttpGet]
        public async Task<IActionResult> GetReports()
        {
            try
            {
                return Ok(await reportData.GetReports());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Report>> GetReport(int id)
        {
            try
            {
                var result = await reportData.GetReport(id);

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<Report>> PostReport(Report report)
        {
            try
            {
                if (report == null)
                {
                    return BadRequest();
                }
                var createdReport = await reportData.InsertReport(report);
                return CreatedAtAction(nameof(GetReport), new { id = createdReport.ReportId }, createdReport);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Report>> PutReport(int id, Report report)
        {
            try
            {
                if (report.ReportId != id)
                {
                    return BadRequest("Team ID mismatch");
                }

                var reportToUpdate = await reportData.GetReport(id);

                if (reportToUpdate == null)
                {
                    return NotFound($"Team with ID = {id} not found");
                }
                return await reportData.UpdateReport(report);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteReport(int id)
        {
            try
            {
                var reportToDelete = await reportData.GetReport(id);

                if (reportToDelete == null)
                {
                    return NotFound($"Team with ID:{id} not found");
                }

                await reportData.DeleteReport(id);

                return Ok();

            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
