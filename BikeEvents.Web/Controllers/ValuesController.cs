using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeEvents.DataAccess.Interfaces;
using BikeEvents.DomainModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BikeEvents.Web.Controllers
{
    
    [Route("api/[controller]")]
    [EnableCors("AllowSpecificOrigin")]
    public class ValuesController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;

        public ValuesController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        
        // GET api/values
        [HttpGet("[action]")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value1", "value2"};
        }

        [HttpGet("[action]")]
        [EnableCors("AllowSpecificOrigin")]
        public ActionResult<IEnumerable<Event>> GetEvents()
        {
            return _eventRepository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}