using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PlatformAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamInEventController : ControllerBase
    {
        private readonly ITeamInEventData teamInEventData;

        public TeamInEventController(ITeamInEventData teamInEventData)
        {
            this.teamInEventData = teamInEventData;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeamsInEvent()
        {
            try
            {
                return Ok(await teamInEventData.GetAllTeamInEvent());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TeamInEvent>> GetTeamInEvent(string id)
        {
            try
            {
                var result = await teamInEventData.GetTeamInEvent(id);

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
        public async Task<ActionResult<TeamInEvent>> PostTeamInEvent(TeamInEvent teamInEvent)
        {
            try
            {
                if (teamInEvent == null)
                {
                    return BadRequest();
                }
                var createdTeamInEvent = await teamInEventData.InsertTeamInEvent(teamInEvent);
                return CreatedAtAction(nameof(GetTeamInEvent), new { id = createdTeamInEvent.TeamId }, createdTeamInEvent);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTeamInEvent(string id)
        {
            try
            {
                var teamInEventToDelete = await teamInEventData.GetTeamInEvent(id);

                if (teamInEventToDelete == null)
                {
                    return NotFound($"Team with ID:{id} not found");
                }

                await teamInEventData.DeleteTeamInEvent(id);

                return Ok();

            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
