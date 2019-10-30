using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    class Management
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public User Username { get; set; }

        [Required]
        public float Money { get; set; }

        [Required]
        public Book Book { get; set; }

        [Required]
        public System.Nullable<DateTime> BookReturnDate { get; set; }

        


    }
}
