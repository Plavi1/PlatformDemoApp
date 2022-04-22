using Microsoft.AspNetCore.Mvc;

namespace PlatformAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChallengeController : ControllerBase
    {
        private readonly IChallengeData challengeData;

        public ChallengeController(IChallengeData challengeData)
        {
            this.challengeData = challengeData;
        }

        [HttpGet]
        public async Task<IActionResult> GetChallenges()
        {
            try
            {
                return Ok(await challengeData.GetChallenges());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Challenge>> GetChallenge(string id)
        {
            try
            {
                var result = await challengeData.GetChallenge(id);

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
        public async Task<ActionResult<Challenge>> PostChallenge(Challenge challenge)
        {
            try
            {
                if (challenge == null)
                {
                    return BadRequest();
                }
                var createdChallenge = await challengeData.InsertChallenge(challenge);
                return CreatedAtAction(nameof(GetChallenge), new { id = createdChallenge.ChallengeId }, createdChallenge);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteChallenge(string id)
        {
            try
            {
                var challengeToDelete = await challengeData.GetChallenge(id);

                if (challengeToDelete == null)
                {
                    return NotFound($"Team with ID:{id} not found");
                }

                await challengeData.DeleteChallenge(id);

                return Ok();

            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Challenge>> PutChallenge(string id, Challenge challenge)
        {
            try
            {
                if (challenge.ChallengeId != id)
                {
                    return BadRequest("Team ID mismatch");
                }

                var challengeToUpdate = await challengeData.GetChallenge(id);

                if (challengeToUpdate == null)
                {
                    return NotFound($"Team with ID = {id} not found");
                }
                return await challengeData.UpdateChallenge(challenge);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }

    }
}
