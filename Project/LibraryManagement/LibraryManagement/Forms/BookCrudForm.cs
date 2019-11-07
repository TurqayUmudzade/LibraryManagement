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
    public partial class BookCrudForm : Form
    {

        private AdminContext _adminContext;
        private Book _selectedBook;
        public BookCrudForm()
        {
            InitializeComponent();
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            TbBookID.Enabled = false;
            _adminContext = new AdminContext();
        }

        private void BookCrudForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagement01DataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryManagement01DataSet.Books);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Book newBook = new Book()
            {
                bookName = TbBookName.Text,
                bookPrice = Convert.ToSingle(TbBookPrice.Text),
                bookGenre = TbBookGenre.Text
            };

            _adminContext.Books.Add(newBook);
            _adminContext.SaveChanges();

            this.booksTableAdapter.Fill(this.libraryManagement01DataSet.Books);


        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _selectedBook.bookName = TbBookName.Text;
            _selectedBook.bookGenre = TbBookGenre.Text;
            _selectedBook.bookPrice = Convert.ToSingle(TbBookPrice.Text);

            _adminContext.SaveChanges();

            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            this.booksTableAdapter.Fill(this.libraryManagement01DataSet.Books);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _adminContext.Books.Remove(_selectedBook);
            _adminContext.SaveChanges();

            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            this.booksTableAdapter.Fill(this.libraryManagement01DataSet.Books);
        }

        private void DgvBookCrud_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedBook = _adminContext.Books.Find(DgvBookCrud.Rows[e.RowIndex].Cells[0].Value);

            TbBookID.Text = _selectedBook.bookID.ToString();
            TbBookName.Text = _selectedBook.bookName;
            TbBookGenre.Text = _selectedBook.bookGenre;
            TbBookPrice.Text = _selectedBook.bookPrice.ToString();

            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
        }
    }
}
