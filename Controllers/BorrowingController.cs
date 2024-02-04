using Microsoft.AspNetCore.Mvc;
using Final_Assignment_2.Models;

namespace Final_Assignment_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BorrowingController : ControllerBase
    {
        // GET: /Borrowing
        [HttpGet]
        public IActionResult GetAllBorrowings()
        {
            return Ok("All borrowings returned.");
        }

        // GET: /Borrowing/{id}
        [HttpGet("{id}")]
        public IActionResult GetBorrowingById(int id)
        {
            return Ok($"Borrowing with ID {id} returned.");
        }

        // POST: /Borrowing
        [HttpPost]
        public IActionResult AddBorrowing([FromBody] BorrowingModel borrowing)
        {
            return Ok("Borrowing added.");
        }

        // PUT: /Borrowing/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateBorrowing(int id, [FromBody] BorrowingModel borrowing)
        {
            return Ok($"Borrowing with ID {id} updated.");
        }

        // DELETE: /Borrowing/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteBorrowing(int id)
        {
            return Ok($"Borrowing with ID {id} deleted.");
        }
        // GET: /Borrowing/Overdue
        [HttpGet("Overdue")]
        public IActionResult GetOverdueBorrowings()
        {
            return Ok("Overdue borrowings returned.");
        }

    }
}
