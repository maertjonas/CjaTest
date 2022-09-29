using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Domain;
using Services;
using Shared;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {

        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        /*[HttpGet]
        [SwaggerOperation(Summary = "", Description = "")]
        [SwaggerResponse(200, "Ok")]
        public Task<Event> Get(int id) => _eventService.GetEventAsync(id);*/

        [HttpGet]
        [SwaggerOperation(Summary = "", Description = "")]
        [SwaggerResponse(200, "Ok")]
        public Task<IEnumerable<Event>> GetEventsAsync() => _eventService.ReadEventsAsync();



    }

}
