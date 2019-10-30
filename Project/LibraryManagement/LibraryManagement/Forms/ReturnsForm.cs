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


    public partial class ReturnsForm : Form
    {
        private readonly AdminContext _adminContext;
        private User _selectedUser;
        public ReturnsForm(int id)
        {
            InitializeComponent();

            _selectedUser = new User();
            _adminContext = new AdminContext();
            _selectedUser = _adminContext.Users.Find(id);

            /*SELECT Managements.OrderID, Books.bookName, Managements.BookReturnDate,Managements.Money 
                FROM Managements,Users,Books
                WHERE Users.UserID = Managements.Username_UserID AND Books.bookID = Managements.Book_bookID*/

            /* SELECT Managements.OrderID, Managements.BookReturnDate,Managements.Money ,Books.bookName
             FROM Managements
             INNER JOIN Users
          ON Users.UserID = Managements.Username_UserID
             INNER JOIN  Books
          ON Books.bookID = Managements.Book_bookID*/

            ArrayList arrayList = new ArrayList();
            //arrayList=_adminContext.Managements.Select()
        }
    }
}
