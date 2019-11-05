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
            //Today
            DateTime today = new DateTime();
            today = DateTime.Today;

            List<Management> orderListToday = new List<Management>();
            orderListToday = _adminContext.Managements.Include("User").Where(m => m.BookReturnDate == today).Distinct().ToList();

            foreach (var item in orderListToday)
            {
                int books;
                books = _adminContext.Managements.Where(m => m.User.UserID == item.User.UserID && m.returned == false).Count();
                DgvTodaysRetuns.Rows.Add(item.User.UserID, item.User.Username, item.User.Fullname, item.User.Phonenumber, books);
            }

            //Tomorrow
            DateTime tomorrow = new DateTime();
            tomorrow = today.AddDays(1);

            List<Management> orderListTmr = new List<Management>();
            orderListTmr = _adminContext.Managements.Include("User").Where(m => m.BookReturnDate == tomorrow).Distinct().ToList();

            foreach (var item in orderListTmr)
            {
                int books;
                books = _adminContext.Managements.Where(m => m.User.UserID == item.User.UserID && m.returned == false).Count();
                DgvTomorrow.Rows.Add(item.User.UserID, item.User.Username, item.User.Fullname, item.User.Phonenumber, books);


            }

            //Late
            DateTime now = new DateTime();
            now = DateTime.Now;

            List<Management> orderListLate = new List<Management>();
            orderListLate = _adminContext.Managements.Include("User").Where(m => m.BookReturnDate < now).Distinct().ToList();

            foreach (var item in orderListLate)
            {
                int books;
                books = _adminContext.Managements.Where(m => m.User.UserID == item.User.UserID && m.returned == false).Count();
                DgvLate.Rows.Add(item.User.UserID, item.User.Username, item.User.Fullname, item.User.Phonenumber, books);
            }

         
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

        private void BtnPurchView_Click(object sender, EventArgs e)
        {

            //Interval
            DateTime start = new DateTime();
            DateTime end = new DateTime();
            start = dateTimePickerStart.Value;
            end = dateTimePickerEnd.Value;
            AdminContext _adminContext=new AdminContext();

            List<Purchase> purchasesList = new List<Purchase>();
            purchasesList = _adminContext.Purchases.Include("Management").Where(p => p.BookReturnededDate > start && p.BookReturnededDate < end).ToList();
            foreach (var item in purchasesList)
            {
            
                
                DgvExel.Rows.Add(item.PurchaseID, "item.Management.Book.bookName", item.Money,"username", item.BookReturnededDate);
            }
        }
    }
}
