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
    public partial class AdminCrudForm : Form
    {
        public AdminCrudForm()
        {
            InitializeComponent();
        }

        private void AdminCrudForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagement01DataSet1.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.libraryManagement01DataSet1.Admins);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
             
        }
    }
}
