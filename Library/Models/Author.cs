using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Author
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Author Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Number Of Pages")]
        public int NumberOfBooks { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}