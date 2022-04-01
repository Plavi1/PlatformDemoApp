using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PlatformAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamData teamData;

        public TeamController(ITeamData teamData)
        {
            this.teamData = teamData;
        }

        [HttpGet]
        public async Task<IActionResult> GetTeams()
        {
            try
            {
                return Ok(await teamData.GetTeams());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> GetTeam(string id)
        {
            try
            {
                var result = await teamData.GetTeam(id);

                if(result == null)
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
    }
}
