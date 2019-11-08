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
       // private User _selectedUser;
        public LoginForm()
        {
            InitializeComponent();

            _adminContext = new AdminContext();


        }

        private void BTN_SignIn_Click(object sender, EventArgs e)
        {
            LoginAdmin(LoginUsernameTB.Text, LoginPasswordTb.Text);
            LoginUser(LoginUsernameTB.Text, LoginPasswordTb.Text);
            
        }

        public void LoginAdmin(string username, string password)
        {
            List<Admin> adminList = new List<Admin>();
            adminList = _adminContext.Admins.ToList();

            foreach (Admin admin in adminList)
            {
                if (username == admin.Username && password == admin.Password)
                {
                    MessageBox.Show("Welcome Admin");

                    this.Hide();
                    AdminDashboardForm adminDashboard = new AdminDashboardForm();
                    adminDashboard.Show();
                    return;
                }
            }
            

        }
        public void LoginUser(string username, string password)
        {
            List<User> userList = new List<User>();
            userList = _adminContext.Users.ToList();

            foreach (User user in userList)
            {
                if (username == user.Username && password == user.Password)
                {
                    

                    MessageBox.Show("Welcome " + user.Fullname);
                    this.Hide();

                    BookStoreForm bookStore = new BookStoreForm(user.UserID);
                    bookStore.Show();


                    return;
                }
            }
           // MessageBox.Show("No user found");
        }

        private void LoginUsernameTB_MouseClick(object sender, MouseEventArgs e)
        {
            LoginUsernameTB.Text = "";
        }
    }
}
