using System.ComponentModel.DataAnnotations;

namespace Final_Assignment_2.Models
{
    
        public class ReaderModel
        {
            [Key]
            public int ReaderId { get; set; }

            [Required, StringLength(100)]
            public string Name { get; set; }

            [Required, EmailAddress]
            public string Email { get; set; }

            [DataType(DataType.Date)]
            public DateTime RegistrationDate { get; set; }
        }
    
}
