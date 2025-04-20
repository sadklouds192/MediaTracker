using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediaTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NovelsController : ControllerBase
    {
        // GET: api/Novels
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<NovelsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Novels
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Novels/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Novels/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
