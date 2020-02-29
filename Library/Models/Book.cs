using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public int ISBN { get; set; }
        [Display(Name = "Publication Date")]
        [DataType(DataType.Date)]
        public DateTime Publication { get; set; }
        [Range(0, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Author")]
        public string Author { get; set; }
     

        public virtual  ICollection<Author> Authors { get; set; }
    }
}