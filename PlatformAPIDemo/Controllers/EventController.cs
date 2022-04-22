using Microsoft.AspNetCore.Mvc;

namespace PlatformAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventData eventData;

        public EventController(IEventData eventData)
        {
            this.eventData = eventData;
        }

        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            try
            {
                return Ok(await eventData.GetEvents());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            try
            {
                var result = await eventData.GetEvent(id);

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
        public async Task<ActionResult<Event>> PostEvent(Event newEvent)
        {
            try
            {
                if (newEvent == null)
                {
                    return BadRequest();
                }
                var createdEvent = await eventData.InsertEvent(newEvent);
                return CreatedAtAction(nameof(GetEvent), new { id = createdEvent.EventId }, createdEvent);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Event>> PutEvent(int id, Event updateEvent)
        {
            try
            {
                if (updateEvent.EventId != id)
                {
                    return BadRequest("Team ID mismatch");
                }

                var teamToUpdate = await eventData.GetEvent(id);

                if (teamToUpdate == null)
                {
                    return NotFound($"Team with ID = {id} not found");
                }
                return await eventData.UpdateEvent(updateEvent);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }



        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteEvent(int id)
        {
            try
            {
                var teamToDelete = await eventData.GetEvent(id);

                if (teamToDelete == null)
                {
                    return NotFound($"Team with ID:{id} not found");
                }

                await eventData.DeleteEvent(id);

                return Ok();

            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
