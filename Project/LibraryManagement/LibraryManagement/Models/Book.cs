using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Book
    {       
        [Key]
        public int bookID { get; set; }

        [Required]
        public string bookName { get; set; }

        public string bookGenre { get; set; }
        
        public float bookPrice { get; set; }
    }
}
