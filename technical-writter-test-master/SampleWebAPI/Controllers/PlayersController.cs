using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.Models;

namespace SampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        // GET api/players
        [HttpGet]
        public ActionResult<IEnumerable<Player>> Get()
        {
            Player[] players = null;
            //Do query to db to get all records
            return players;
        }

        // GET api/players/5
        [HttpGet("{id}")]
        public ActionResult<Player> Get(int id)
        {
            Player player = new Player();
            //Query data to db, search Player with `id` = id and assign to player
            return player;
        }

        // POST api/players
        [HttpPost]
        public void Post([FromBody] Player player)
        {
            //submit player data to database
        }

        // PUT api/players/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Player player)
        {
            //PUT player data with id to database
        }

        // DELETE api/players/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //delete player data with `id` == id, if fail (not exist or something happen) return error
        }
    }
}
