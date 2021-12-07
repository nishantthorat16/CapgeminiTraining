using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCLibrary
{
    public class Book
    {
        [Key]
        public int Id           { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Title     { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Author    { get; set; }

        public string BookCover { get; set; }
    }
}
