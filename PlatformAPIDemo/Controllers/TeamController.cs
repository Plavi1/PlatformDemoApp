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
        public async Task<ActionResult<Team>> PostTeam(Team team)
        {
            try
            {
                if (team == null)
                {
                    return BadRequest();
                }
                var createdTeam = await teamData.InsertTeam(team);
                return CreatedAtAction(nameof(GetTeam), new { id = createdTeam.TeamId }, createdTeam);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Team>> PutTeam(string id, Team team)
        {
            try
            {
                if(team.TeamId != id)
                {
                    return BadRequest("Team ID mismatch");
                }

                var teamToUpdate = await teamData.GetTeam(id);

                if(teamToUpdate == null)
                {
                    return NotFound($"Team with ID = {id} not found");
                }
                return await teamData.UpdateTeam(team);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }



        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTeam(string id)
        {
            try
            {
                var teamToDelete = await teamData.GetTeam(id);

                if(teamToDelete == null)
                {
                    return NotFound($"Team with ID:{id} not found");
                }

                await teamData.DeleteTeam(id);

                return Ok();

            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
