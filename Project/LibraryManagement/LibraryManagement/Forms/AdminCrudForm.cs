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
    public partial class AdminCrudForm : Form
    {

        private AdminContext _context;
        private Admin _selectedAdmin;
        public AdminCrudForm()
        {
            InitializeComponent();

            _context = new AdminContext();


            LblError.Visible = false;
            LblError.ForeColor = Color.Red;

            TbAdminID.Enabled = false;
            BtnDelete.Enabled = false;
            BtnUpdate.Enabled = false;
        }

        private void AdminCrudForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagement01DataSet1.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.libraryManagement01DataSet1.Admins);

        }

        private void DgvAdminCrud_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnDelete.Enabled = true;
            BtnUpdate.Enabled = true;

            _selectedAdmin = new Admin();
            _selectedAdmin = _context.Admins.Find(DgvAdminCrud.Rows[e.RowIndex].Cells[0].Value);

            TbAdminID.Text = _selectedAdmin.AdminID.ToString();
            TbAdminFullname.Text = _selectedAdmin.Fullname;
            TbAdminUsername.Text = _selectedAdmin.Username;
            TbAdminPassword.Text = _selectedAdmin.Password;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LblError.Visible == true)
            {
                MessageBox.Show("Username Taken");

            }
            else
            {

                Admin admin = new Admin()
                {
                    Fullname = TbAdminFullname.Text,
                    Password = TbAdminPassword.Text,
                    Username = TbAdminUsername.Text
                };

                _context.Admins.Add(admin);
                _context.SaveChanges();

                this.adminsTableAdapter.Fill(this.libraryManagement01DataSet1.Admins);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _selectedAdmin.Fullname = TbAdminFullname.Text;
            _selectedAdmin.Username = TbAdminUsername.Text;
            _selectedAdmin.Password = TbAdminUsername.Text;

            _context.SaveChanges();

            BtnAdd.Enabled = true;
            BtnDelete.Enabled = false;
            BtnUpdate.Enabled = false;

            this.adminsTableAdapter.Fill(this.libraryManagement01DataSet1.Admins);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _context.Admins.Remove(_selectedAdmin);
            _context.SaveChanges();

            BtnAdd.Enabled = true;
            BtnDelete.Enabled = false;
            BtnUpdate.Enabled = false;
            this.adminsTableAdapter.Fill(this.libraryManagement01DataSet1.Admins);
        }

        private void TbAdminUsername_TextChanged(object sender, EventArgs e)
        {
            _context = new AdminContext();

            LblError.Visible = false;

            foreach (var item in _context.Users)
            {

                if (item.Username == TbAdminUsername.Text)
                {
                    LblError.Text = "Name taken by user";
                    LblError.Visible = true;
                }
            }

            //checks if another admin has this username
            foreach (var item in _context.Admins)
            {

                if (item.Username == TbAdminUsername.Text)
                {
                    LblError.Text = "Name taken by admin";
                    LblError.Visible = true;
                }
            }
        }
    }
}
