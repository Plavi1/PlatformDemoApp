using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PlatformAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteOnWaitingController : ControllerBase
    {
        private readonly IVoteOnWaitingData voteOnWaitingData;

        public VoteOnWaitingController(IVoteOnWaitingData voteOnWaitingData)
        {
            this.voteOnWaitingData = voteOnWaitingData;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVoteOnWaiting()
        {
            try
            {
                return Ok(await voteOnWaitingData.GetVotesOnWaiting());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet("{teamId}")]
        public async Task<ActionResult<VoteOnWaiting>> GetVoteOnWaiting(string teamId)
        {
            try
            {
                var result = await voteOnWaitingData.GetVoteOnWaiting(teamId);

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
        public async Task<ActionResult<VoteOnWaiting>> PostVoteOnWaiting(VoteOnWaiting voteOnWaiting)
        {
            try
            {
                if (voteOnWaiting == null)
                {
                    return BadRequest();
                }
                var createdVoteOnWaiting = await voteOnWaitingData.InsertVoteOnWaiting(voteOnWaiting);
                return CreatedAtAction(nameof(GetVoteOnWaiting), new { id = createdVoteOnWaiting.TeamId }, createdVoteOnWaiting);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        [HttpPut("{teamId}")]
        public async Task<ActionResult<VoteOnWaiting>> PutVoteOnWaiting(string teamId, VoteOnWaiting voteOnWaiting)
        {
            try
            {
                if (voteOnWaiting.TeamId != teamId)
                {
                    return BadRequest("Team ID mismatch");
                }

                var voteOnwaitingToUpdate = await voteOnWaitingData.GetVoteOnWaiting(teamId);

                if (voteOnwaitingToUpdate == null)
                {
                    return NotFound($"Team with ID = {teamId} not found");
                }
                return await voteOnWaitingData.UpdateVoteOnWaiting(voteOnWaiting);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }



        [HttpDelete("{teamId}")]
        public async Task<ActionResult> DeleteVoteOnWaiting(string teamId)
        {
            try
            {
                var teamToDelete = await voteOnWaitingData.GetVoteOnWaiting(teamId);

                if (teamToDelete == null)
                {
                    return NotFound($"Team with ID:{teamId} not found");
                }

                await voteOnWaitingData.DeleteVoteOnWaiting(teamId);

                return Ok();

            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
