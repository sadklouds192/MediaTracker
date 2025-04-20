using MediaTracker.Core.DataModels;
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
        public async Task<ActionResult<IEnumerable<NovelModel>>> Get()
        {
            return Ok(new List<NovelModel> 
            { 
                new NovelModel { Id = 1, Title = "Lord of The Rings", Author = "J.R.R Tolkien"},
                new NovelModel { Id = 2, Title = "The Last Wish", Author = "Andrzej Sapkowski"} 
            });
        }

        // GET api/<NovelsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NovelModel>> Get(int id)
        {
            return new NovelModel { Id = 2, Title = "The Last Wish", Author = "Andrzej Sapkowski" };
        }

        // POST api/Novels
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NovelModel novel)
        {
            return CreatedAtAction(nameof(Get), new { id = 1}, novel);
        }

        // PUT api/Novels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] NovelModel novel)
        {
            return NoContent();
        }

        // DELETE api/Novels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return NoContent();
        }
    }
}
