using System.ComponentModel.DataAnnotations;

namespace Final_Assignment_2.Models // Change to your actual namespace
{
    public class BookModel
    {
        [Key]
        public int BookId { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required, StringLength(100)]
        public string Author { get; set; }

        [Required, StringLength(20)]
        public string ISBN { get; set; }

        [Range(1450, 2050)]
        public int PublicationYear { get; set; }

        [Required, StringLength(50)]
        public string Genre { get; set; }
    }
}
