using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class BookCrudForm : Form
    {
        public BookCrudForm()
        {
            InitializeComponent();
        }

        private void BookCrudForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagement01DataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryManagement01DataSet.Books);

        }
    }
}
