using Microsoft.AspNetCore.Mvc;
using Final_Assignment_2.Models;

namespace Final_Assignment_2.Controllers
{
    
        [ApiController]
        [Route("[controller]")]
        public class BookController : ControllerBase
        {
            // GET: /Book
            [HttpGet]
            public IActionResult GetAllBooks()
            {
                return Ok("All books returned.");
            }

            // GET: /Book/{id}
            [HttpGet("{id}")]
            public IActionResult GetBookById(int id)
            {
                return Ok($"Book with ID {id} returned.");
            }

            // POST: /Book
            [HttpPost]
            public IActionResult AddBook([FromBody] BookModel book)
            {
                return Ok("Book added.");
            }

            // PUT: /Book/{id}
            [HttpPut("{id}")]
            public IActionResult UpdateBook(int id, [FromBody] BookModel book)
            {
                return Ok($"Book with ID {id} updated.");
            }

            // DELETE: /Book/{id}
            [HttpDelete("{id}")]
            public IActionResult DeleteBook(int id)
            {
                return Ok($"Book with ID {id} deleted.");
            }

            // GET: /Book/Genre/{genre}
            [HttpGet("Genre/{genre}")]
            public IActionResult GetBooksByGenre(string genre)
            {
                return Ok($"Books in the {genre} genre returned.");
            }

        }

}
