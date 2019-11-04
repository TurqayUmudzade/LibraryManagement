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
using System.Collections;
namespace LibraryManagement.Forms
{

    public partial class AdminDashboardForm : Form
    {
        private readonly AdminContext _adminContext;
        public AdminDashboardForm()
        {
            InitializeComponent();

            AdminContext _adminContext = new AdminContext();

            DgvTodaysRetuns.Visible = true;
            DgvTomorrow.Visible = false;
            DgvLate.Visible = false;

            DateTime today = new DateTime();
            today = DateTime.Today;

            DateTime tomorrow = new DateTime();
            tomorrow = today.AddDays(1);

            List<Management> orderListToday = new List<Management>();
            orderListToday = _adminContext.Managements.Include("User").Where(m => m.BookReturnDate == today).ToList();

            foreach (var item in orderListToday) {
                DgvTodaysRetuns.Rows.Add(item.User.UserID,item.User.Username,item.User.Phonenumber);
            }

            List<Management> orderListTmr = new List<Management>();
            orderListTmr = _adminContext.Managements.Include("User").Where(m => m.BookReturnDate == tomorrow).ToList();

            foreach (var item in orderListTmr)
            {
                DgvTomorrow.Rows.Add(item.User.UserID, item.User.Username, item.User.Phonenumber);
            }



            /* List<User> userList = new List<User>();
             userList = _adminContext.Users.ToList();


             foreach (User user in userList)
             {
                 DgvTodaysRetuns.Rows.Add(user.UserID, user.Username, user.Fullname, user.Phonenumber);
             }
 */
        }

        private void BtnTodayR_Click(object sender, EventArgs e)
        {
            DgvTodaysRetuns.Visible = true;
            DgvTomorrow.Visible = false;
            DgvLate.Visible = false;
        }

        private void BtnTomorrow_Click(object sender, EventArgs e)
        {
            DgvTodaysRetuns.Visible = false;
            DgvTomorrow.Visible = true;
            DgvLate.Visible = false;
        }

        private void BtnLate_Click(object sender, EventArgs e)
        {
            DgvTodaysRetuns.Visible = false;
            DgvTomorrow.Visible = false;
            DgvLate.Visible = true;
        }
    }
}
