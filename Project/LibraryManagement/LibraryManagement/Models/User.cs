using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
   public  class User
    {
        [Key]
        public int UserID { get; set; }

        public string Fullname { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        

    }
}
