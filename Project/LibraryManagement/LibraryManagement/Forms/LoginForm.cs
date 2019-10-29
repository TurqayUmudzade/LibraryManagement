using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Services;
using LibraryManagement.DAL;
using LibraryManagement.Models;
using LibraryManagement.Forms;

namespace LibraryManagement
{
    public partial class LoginForm : Form
    {
        //private readonly AdminServices _adminServices;
        private readonly AdminContext _adminContext;
        public LoginForm()
        {
            InitializeComponent();
            _adminContext = new AdminContext();
        }

        private void BTN_SignIn_Click(object sender, EventArgs e)
        {
            Login(LoginUsernameTB.Text, LoginPasswordTb.Text);
        }

        public void Login(string username, string password)
        {
            List<Admin> adminList = new List<Admin>();
            adminList = _adminContext.Admins.ToList();

            foreach (Admin admin in adminList)
            {
                if (username == admin.Username && password == admin.Password)
                {
                    MessageBox.Show("Welcome");
                    this.Hide();
                    BookStore bookStore = new BookStore();
                    bookStore.Show();
                    return;
                }
            }
            MessageBox.Show("No user found");

        }
    }
}
