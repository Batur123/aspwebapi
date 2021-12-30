using LiteDB;
using Microsoft.AspNetCore.Mvc;
using aspwebapi.Database;

namespace aspwebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
           return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return id.ToString();
        }
        
        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            return value;
           // var User = new UserDatabase(1, "asd", "asd", "asd");
           // return User;
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
