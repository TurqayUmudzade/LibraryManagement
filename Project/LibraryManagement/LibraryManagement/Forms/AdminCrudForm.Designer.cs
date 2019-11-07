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
            this.TbAdminFullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbAdminUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbAdminPassword = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.DgvAdminCrud = new System.Windows.Forms.DataGridView();
            this.libraryManagement01DataSet1 = new LibraryManagement.LibraryManagement01DataSet1();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsTableAdapter = new LibraryManagement.LibraryManagement01DataSet1TableAdapters.AdminsTableAdapter();
            this.adminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdminCrud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagement01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin ID:";
            // 
            // TbAdminID
            // 
            this.TbAdminID.Location = new System.Drawing.Point(34, 75);
            this.TbAdminID.Name = "TbAdminID";
            this.TbAdminID.Size = new System.Drawing.Size(181, 22);
            this.TbAdminID.TabIndex = 1;
            // 
            // TbAdminFullname
            // 
            this.TbAdminFullname.Location = new System.Drawing.Point(34, 149);
            this.TbAdminFullname.Name = "TbAdminFullname";
            this.TbAdminFullname.Size = new System.Drawing.Size(181, 22);
            this.TbAdminFullname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fullname:";
            // 
            // TbAdminUsername
            // 
            this.TbAdminUsername.Location = new System.Drawing.Point(34, 230);
            this.TbAdminUsername.Name = "TbAdminUsername";
            this.TbAdminUsername.Size = new System.Drawing.Size(181, 22);
            this.TbAdminUsername.TabIndex = 5;
            this.TbAdminUsername.TextChanged += new System.EventHandler(this.TbAdminUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
            // 
            // TbAdminPassword
            // 
            this.TbAdminPassword.Location = new System.Drawing.Point(33, 311);
            this.TbAdminPassword.Name = "TbAdminPassword";
            this.TbAdminPassword.Size = new System.Drawing.Size(181, 22);
            this.TbAdminPassword.TabIndex = 7;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(30, 274);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 17);
            this.label.TabIndex = 6;
            this.label.Text = "Password";
            // 
            // DgvAdminCrud
            // 
            this.DgvAdminCrud.AllowUserToAddRows = false;
            this.DgvAdminCrud.AllowUserToDeleteRows = false;
            this.DgvAdminCrud.AllowUserToResizeColumns = false;
            this.DgvAdminCrud.AllowUserToResizeRows = false;
            this.DgvAdminCrud.AutoGenerateColumns = false;
            this.DgvAdminCrud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAdminCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAdminCrud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminIDDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.DgvAdminCrud.DataSource = this.adminsBindingSource;
            this.DgvAdminCrud.Location = new System.Drawing.Point(313, 51);
            this.DgvAdminCrud.Name = "DgvAdminCrud";
            this.DgvAdminCrud.RowHeadersWidth = 51;
            this.DgvAdminCrud.RowTemplate.Height = 24;
            this.DgvAdminCrud.Size = new System.Drawing.Size(694, 375);
            this.DgvAdminCrud.TabIndex = 8;
            this.DgvAdminCrud.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAdminCrud_RowHeaderMouseDoubleClick);
            // 
            // libraryManagement01DataSet1
            // 
            this.libraryManagement01DataSet1.DataSetName = "LibraryManagement01DataSet1";
            this.libraryManagement01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.libraryManagement01DataSet1;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
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
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(33, 356);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(106, 41);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(33, 403);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(106, 40);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(33, 449);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(106, 41);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.Location = new System.Drawing.Point(48, 255);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 12;
            // 
            // AdminCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 525);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DgvAdminCrud);
            this.Controls.Add(this.TbAdminPassword);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TbAdminUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbAdminFullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbAdminID);
            this.Controls.Add(this.label1);
            this.Name = "AdminCrudForm";
            this.Text = "AdminCrudForm";
            this.Load += new System.EventHandler(this.AdminCrudForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdminCrud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagement01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbAdminID;
        private System.Windows.Forms.TextBox TbAdminFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbAdminUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbAdminPassword;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView DgvAdminCrud;
        private LibraryManagement01DataSet1 libraryManagement01DataSet1;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private LibraryManagement01DataSet1TableAdapters.AdminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblError;
    }
}