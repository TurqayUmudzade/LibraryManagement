using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Models;
using System.Data.Entity;


namespace LibraryManagement.DAL
{
    class AdminContext :DbContext
    {
        public AdminContext() : base("Server=DESKTOP-TULDBCK;Database=LibraryManagement01;Trusted_Connection=True;")
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Management> Managements { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }
}
