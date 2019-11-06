namespace LibraryManagement.Forms
{
    partial class AdminCrudForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TbAdminID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbAdminFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbAdminUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbAdminPassword = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DgvAdminCrud = new System.Windows.Forms.DataGridView();
            this.adminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagement01DataSet1 = new LibraryManagement.LibraryManagement01DataSet1();
            this.libraryManagement01DataSet = new LibraryManagement.LibraryManagement01DataSet();
            this.libraryManagement01DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsTableAdapter = new LibraryManagement.LibraryManagement01DataSet1TableAdapters.AdminsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdminCrud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagement01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagement01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagement01DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "AdminID";
            // 
            // TbAdminID
            // 
            this.TbAdminID.Location = new System.Drawing.Point(106, 106);
            this.TbAdminID.Name = "TbAdminID";
            this.TbAdminID.Size = new System.Drawing.Size(179, 22);
            this.TbAdminID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Full Name";
            // 
            // TbAdminFullName
            // 
            this.TbAdminFullName.Location = new System.Drawing.Point(106, 182);
            this.TbAdminFullName.Name = "TbAdminFullName";
            this.TbAdminFullName.Size = new System.Drawing.Size(179, 22);
            this.TbAdminFullName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Admin Username";
            // 
            // TbAdminUsername
            // 
            this.TbAdminUsername.Location = new System.Drawing.Point(106, 264);
            this.TbAdminUsername.Name = "TbAdminUsername";
            this.TbAdminUsername.Size = new System.Drawing.Size(179, 22);
            this.TbAdminUsername.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password";
            // 
            // TbAdminPassword
            // 
            this.TbAdminPassword.Location = new System.Drawing.Point(106, 334);
            this.TbAdminPassword.Name = "TbAdminPassword";
            this.TbAdminPassword.Size = new System.Drawing.Size(179, 22);
            this.TbAdminPassword.TabIndex = 20;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(97, 384);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(188, 38);
            this.BtnAdd.TabIndex = 21;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(96, 475);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(88, 37);
            this.BtnUpdate.TabIndex = 22;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(190, 475);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(95, 37);
            this.BtnDelete.TabIndex = 23;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DgvAdminCrud
            // 
            this.DgvAdminCrud.AutoGenerateColumns = false;
            this.DgvAdminCrud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAdminCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAdminCrud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminIDDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.DgvAdminCrud.DataSource = this.adminsBindingSource;
            this.DgvAdminCrud.Location = new System.Drawing.Point(400, 72);
            this.DgvAdminCrud.Name = "DgvAdminCrud";
            this.DgvAdminCrud.RowHeadersWidth = 51;
            this.DgvAdminCrud.RowTemplate.Height = 24;
            this.DgvAdminCrud.Size = new System.Drawing.Size(598, 440);
            this.DgvAdminCrud.TabIndex = 24;
            // 
            // adminIDDataGridViewTextBoxColumn
            // 
            this.adminIDDataGridViewTextBoxColumn.DataPropertyName = "AdminID";
            this.adminIDDataGridViewTextBoxColumn.HeaderText = "AdminID";
            this.adminIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminIDDataGridViewTextBoxColumn.Name = "adminIDDataGridViewTextBoxColumn";
            this.adminIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.libraryManagement01DataSet1;
            // 
            // libraryManagement01DataSet1
            // 
            this.libraryManagement01DataSet1.DataSetName = "LibraryManagement01DataSet1";
            this.libraryManagement01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryManagement01DataSet
            // 
            this.libraryManagement01DataSet.DataSetName = "LibraryManagement01DataSet";
            this.libraryManagement01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryManagement01DataSetBindingSource
            // 
            this.libraryManagement01DataSetBindingSource.DataSource = this.libraryManagement01DataSet;
            this.libraryManagement01DataSetBindingSource.Position = 0;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // AdminCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 585);
            this.Controls.Add(this.DgvAdminCrud);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TbAdminPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbAdminUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbAdminFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbAdminID);
            this.Controls.Add(this.label1);
            this.Name = "AdminCrudForm";
            this.Text = "AdminCrudForm";
            this.Load += new System.EventHandler(this.AdminCrudForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdminCrud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagement01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagement01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagement01DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbAdminID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbAdminFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbAdminUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbAdminPassword;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView DgvAdminCrud;
        private System.Windows.Forms.BindingSource libraryManagement01DataSetBindingSource;
        private LibraryManagement01DataSet libraryManagement01DataSet;
        private LibraryManagement01DataSet1 libraryManagement01DataSet1;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private LibraryManagement01DataSet1TableAdapters.AdminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}