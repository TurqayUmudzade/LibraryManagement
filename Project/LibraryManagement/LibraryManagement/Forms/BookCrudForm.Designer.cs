namespace LibraryManagement.Forms
{
    partial class BookCrudForm
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
            this.DgbBookCrud = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TbBookID = new System.Windows.Forms.TextBox();
            this.TbBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbBookGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbBookPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgbBookCrud)).BeginInit();
            this.SuspendLayout();
            // 
            // DgbBookCrud
            // 
            this.DgbBookCrud.AllowUserToAddRows = false;
            this.DgbBookCrud.AllowUserToDeleteRows = false;
            this.DgbBookCrud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgbBookCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbBookCrud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgbBookCrud.Location = new System.Drawing.Point(358, 44);
            this.DgbBookCrud.Name = "DgbBookCrud";
            this.DgbBookCrud.ReadOnly = true;
            this.DgbBookCrud.RowHeadersWidth = 51;
            this.DgbBookCrud.RowTemplate.Height = 24;
            this.DgbBookCrud.Size = new System.Drawing.Size(558, 402);
            this.DgbBookCrud.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "BookID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Book Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Book Genre";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "BookID";
            // 
            // TbBookID
            // 
            this.TbBookID.Location = new System.Drawing.Point(51, 78);
            this.TbBookID.Name = "TbBookID";
            this.TbBookID.Size = new System.Drawing.Size(179, 22);
            this.TbBookID.TabIndex = 2;
            // 
            // TbBookName
            // 
            this.TbBookName.Location = new System.Drawing.Point(51, 154);
            this.TbBookName.Name = "TbBookName";
            this.TbBookName.Size = new System.Drawing.Size(179, 22);
            this.TbBookName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book Name";
            // 
            // TbBookGenre
            // 
            this.TbBookGenre.Location = new System.Drawing.Point(51, 222);
            this.TbBookGenre.Name = "TbBookGenre";
            this.TbBookGenre.Size = new System.Drawing.Size(179, 22);
            this.TbBookGenre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book Genre:";
            // 
            // TbBookPrice
            // 
            this.TbBookPrice.Location = new System.Drawing.Point(51, 306);
            this.TbBookPrice.Name = "TbBookPrice";
            this.TbBookPrice.Size = new System.Drawing.Size(179, 22);
            this.TbBookPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(42, 356);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(188, 38);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(41, 447);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(88, 37);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(135, 447);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(95, 37);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BookCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 515);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TbBookPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbBookGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbBookID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgbBookCrud);
            this.Name = "BookCrudForm";
            this.Text = "BookCrudForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgbBookCrud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgbBookCrud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbBookID;
        private System.Windows.Forms.TextBox TbBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbBookGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbBookPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
    }
}