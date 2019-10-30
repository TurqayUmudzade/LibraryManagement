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


namespace LibraryManagement.Forms
{
    public partial class BookStoreForm : Form
    {
        private readonly AdminContext _adminContext;
        private User _selectedUser;
        private Book _selectedbook;
        public BookStoreForm(int userID)
        {
            InitializeComponent();
            returnDateLabel.Visible = false;
            dateTimePicker1.Visible = false;
            BtnConfirm.Visible = false;

            _selectedUser = new User();
          

           //_adminContext = new AdminContext();

            _selectedUser = _adminContext.Users.Find(userID);

            UsernameLabel.Text= _selectedUser.Fullname;

            _adminContext = new AdminContext();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Clears the Data Grid of all previous searches
            DgvSearchResult.Rows.Clear();
            DgvSearchResult.Refresh();

            List<Book> myBookList = new List<Book>();
            myBookList = Search(BookSearchBoxTB.Text);

            foreach (Book book in myBookList)
            {
                DgvSearchResult.Rows.Add(book.bookID, book.bookName, book.bookGenre, book.bookPrice);
            }

        }

        //Seaches for the Book from database with entered String
        public List<Book> Search(string searchStr)
        {
            List<Book> bookList = new List<Book>();
            bookList = _adminContext.Books.Where(b => b.bookName.Contains(searchStr)).ToList();
            return bookList;
        }

        private void DgvSearchResult_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Show Buy Options
            returnDateLabel.Visible = true;
            dateTimePicker1.Visible = true;
            BtnConfirm.Visible = true;

            _selectedbook = new Book();

            //Take book from search DGV and add to cart DGV
            _selectedbook = _adminContext.Books.Find(DgvSearchResult.Rows[e.RowIndex].Cells[0].Value);
            DgvCart.Rows.Add(_selectedbook.bookID, _selectedbook.bookName, _selectedbook.bookGenre, _selectedbook.bookPrice);

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //Gets user from login with ID
            User user = _adminContext.Users.Find(_selectedUser.UserID);

            Book book;


            foreach (DataGridViewRow dr in DgvCart.Rows)
            {
                //gets book from card row with BookID
                book = new Book();
               book = _adminContext.Books.Find(dr.Cells[0].Value);
                //Creates management object
                Management management = new Management
                {
                    Username = user,
                    BookReturnDate = dateTimePicker1.Value.Date,
                    Book = book,
                    Money = book.bookPrice
                };

                _adminContext.Managements.Add(management);
                _adminContext.SaveChanges();

            }
            MessageBox.Show("Purchase Completed");
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();

        }

        private void BtnReturnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnsForm returnsForm = new ReturnsForm(_selectedUser.UserID);
        }
    }
}
