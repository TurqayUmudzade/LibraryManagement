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
    public partial class UserCrudForm : Form
    {
        public UserCrudForm()
        {
            InitializeComponent();
        }

        private void UserCrudForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagement01DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.libraryManagement01DataSet.Users);

        }
    }
}
