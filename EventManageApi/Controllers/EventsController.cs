using EventManageApi.Domain;
using EventManageApi.Dto;
using EventManageApi.Mapper;
using EventManageApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly ILogger<EventsController> _logger;
        private IEventRepository _eventRepository;

        public EventsController(ILogger<EventsController> logger, IEventRepository eventRepository)
        {
            _logger = logger;
            _eventRepository = eventRepository;
            //_eventRepository = new EventRepository();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Event>> GetAllEvents()
        {
            try
            {
                var data = _eventRepository.GetAll();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Event> GetById(int id)
        {
            var data = _eventRepository.GetById(id);
            if (data == null)
            {
                return Ok(new Event { });
            }
            return Ok(data);
        }

        [HttpPost]
        public ActionResult<bool> Insert(EventDto input)
        {
            var mapData = input.ToDomain();

            //var mapper = new MapToDomain();
            //var mapData = mapper.ToDomain(input);

            var data = _eventRepository.Insert(mapData);
            return Ok(data);
        }

        [HttpPut]
        public ActionResult<bool> Update(EventDto input)
        {
            var mapData = input.ToDomain();
            var data = _eventRepository.Update(mapData);
            return Ok(data);
        }

        [HttpDelete]
        public ActionResult<bool> Delete(int id)
        {
            var data = _eventRepository.Delete(id);
            return Ok(data);
        }
    }
}
