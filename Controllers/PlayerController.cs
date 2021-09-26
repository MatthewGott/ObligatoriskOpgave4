using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatoriskOpgave4.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ObligatoriskOpgave4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IManagePlayers mgr = new ManagePlayers();

        // GET: api/<PlayerController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get() {
            return mgr.Get();
        }

        // GET api/<PlayerController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id) {
            return mgr.Get(id);
        }

        // POST api/<PlayerController>
        [HttpPost]
        public bool Post([FromBody] FootballPlayer value) {
            return mgr.Create(value);
        }

        // PUT api/<PlayerController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] FootballPlayer value) {
            return mgr.Update(id, value);
        }

        // DELETE api/<PlayerController>/5
        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id) {
            return mgr.Delete(id);
        }
    }
}
