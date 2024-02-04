using Microsoft.AspNetCore.Mvc;
using Final_Assignment_2.Models;

namespace Final_Assignment_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReaderController : ControllerBase
    {
        // GET: /Reader
        [HttpGet]
        public IActionResult GetAllReaders()
        {
            return Ok("All readers info returned.");
        }

        // GET: /Reader/{id}
        [HttpGet("{id}")]
        public IActionResult GetReaderById(int id)
        {
            return Ok($"Reader info with ID {id} returned.");
        }

        // POST: /Reader
        [HttpPost]
        public IActionResult AddReader([FromBody] ReaderModel reader)
        {
            return Ok("Reader added.");
        }

        // PUT: /Reader/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateReader(int id, [FromBody] ReaderModel reader)
        {
            return Ok($"Reader with ID {id} updated.");
        }

        // DELETE: /Reader/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteReader(int id)
        {
            return Ok($"Reader with ID {id} deleted.");
        }
        // GET: /Reader/RegisteredAfter/{date} This is the format 2021-01-01 for the date yyyy-mm-dd
        [HttpGet("RegisteredAfter/{date}")]
        public IActionResult GetReadersRegisteredAfter(DateTime date)
        {
            return Ok($"Readers registered after {date.ToShortDateString()} (yyyy-mm-dd) returned.");
        }

    }
}
