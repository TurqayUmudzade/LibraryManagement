﻿using System;
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
    public partial class UserCrudForm : Form
    {
        private AdminContext _adminContext;
        private User _selectedUser;
        public UserCrudForm()
        {
            InitializeComponent();

            _adminContext = new AdminContext();

            TbUserID.Enabled = false;
            BtnAdd.Enabled = true;
            BtnDelete.Enabled = false;
            BtnUpdate.Enabled = false;
        }

        private void UserCrudForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagement01DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.libraryManagement01DataSet.Users);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LblError.Visible == true)
            {
                MessageBox.Show("Username Taken");
            }
            else
            {

                User user = new User()
                {
                    Username = TbUsername.Text,
                    Password = TbPassword.Text,
                    Fullname = TbFullname.Text,
                    Phonenumber = TbPassword.Text
                };

                _adminContext.Users.Add(user);
                _adminContext.SaveChanges();

                this.usersTableAdapter.Fill(this.libraryManagement01DataSet.Users);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            _selectedUser.Fullname = TbFullname.Text;
            _selectedUser.Username = TbUsername.Text;
            _selectedUser.Password = TbPassword.Text;
            _selectedUser.Phonenumber = TbPhonenumber.Text;

            _adminContext.SaveChanges();

            this.usersTableAdapter.Fill(this.libraryManagement01DataSet.Users);

            BtnAdd.Enabled = true;
            BtnDelete.Enabled = false;
            BtnUpdate.Enabled = false;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            _adminContext.Users.Remove(_selectedUser);
            _adminContext.SaveChanges();

            this.usersTableAdapter.Fill(this.libraryManagement01DataSet.Users);

            BtnAdd.Enabled = true;
            BtnDelete.Enabled = false;
            BtnUpdate.Enabled = false;
        }

        private void DgvUserCrud_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Edit Buttons
            BtnAdd.Enabled = false;
            BtnDelete.Enabled = true;
            BtnUpdate.Enabled = true;

            //Find the user object
            _selectedUser = _adminContext.Users.Find(DgvUserCrud.Rows[e.RowIndex].Cells[0].Value);

            //Edit the textboxes
            TbUserID.Text = _selectedUser.UserID.ToString();
            TbUsername.Text = _selectedUser.Username;
            TbFullname.Text = _selectedUser.Fullname;
            TbPassword.Text = _selectedUser.Password;
            TbPhonenumber.Text = _selectedUser.Phonenumber;



        }

        //CAUSES AN ERROR
        private void TbUsername_TextChanged(object sender, EventArgs e)
        {
            /*_adminContext = new AdminContext();

            LblError.Visible = false;

            foreach (var item in _adminContext.Users)
            {

                if (item.Username == TbUsername.Text)
                {
                    LblError.Text = "Name taken by user";
                    LblError.Visible = true;
                }
            }

            //checks if another admin has this username
            foreach (var item in _adminContext.Admins)
            {

                if (item.Username == TbUsername.Text)
                {
                    LblError.Text = "Name taken by admin";
                    LblError.Visible = true;
                }
            }*/

        }
    }
}
