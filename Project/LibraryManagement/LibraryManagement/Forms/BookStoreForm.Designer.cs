namespace LibraryManagement.Forms
{
    partial class BookStoreForm
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
            this.BookSearchBoxTB = new System.Windows.Forms.TextBox();
            this.DgvSearchResult = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.Your = new System.Windows.Forms.Label();
            this.DgvCart = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.BtnSignOut = new System.Windows.Forms.Button();
            this.BtnReturnBooks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // BookSearchBoxTB
            // 
            this.BookSearchBoxTB.Location = new System.Drawing.Point(22, 69);
            this.BookSearchBoxTB.Name = "BookSearchBoxTB";
            this.BookSearchBoxTB.Size = new System.Drawing.Size(176, 22);
            this.BookSearchBoxTB.TabIndex = 0;
            // 
            // DgvSearchResult
            // 
            this.DgvSearchResult.AllowUserToAddRows = false;
            this.DgvSearchResult.AllowUserToDeleteRows = false;
            this.DgvSearchResult.AllowUserToResizeColumns = false;
            this.DgvSearchResult.AllowUserToResizeRows = false;
            this.DgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvSearchResult.Location = new System.Drawing.Point(236, 29);
            this.DgvSearchResult.Name = "DgvSearchResult";
            this.DgvSearchResult.RowHeadersWidth = 51;
            this.DgvSearchResult.RowTemplate.Height = 24;
            this.DgvSearchResult.Size = new System.Drawing.Size(382, 233);
            this.DgvSearchResult.TabIndex = 1;
            this.DgvSearchResult.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvSearchResult_RowHeaderMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "bookID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Genre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 385);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Location = new System.Drawing.Point(19, 348);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(85, 17);
            this.returnDateLabel.TabIndex = 4;
            this.returnDateLabel.Text = "Return Date";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(22, 112);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(137, 36);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(22, 437);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(109, 33);
            this.BtnConfirm.TabIndex = 7;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // Your
            // 
            this.Your.AutoSize = true;
            this.Your.Location = new System.Drawing.Point(233, 302);
            this.Your.Name = "Your";
            this.Your.Size = new System.Drawing.Size(79, 17);
            this.Your.TabIndex = 9;
            this.Your.Text = "Your Items:";
            // 
            // DgvCart
            // 
            this.DgvCart.AllowUserToAddRows = false;
            this.DgvCart.AllowUserToDeleteRows = false;
            this.DgvCart.AllowUserToResizeColumns = false;
            this.DgvCart.AllowUserToResizeRows = false;
            this.DgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column4});
            this.DgvCart.Location = new System.Drawing.Point(236, 331);
            this.DgvCart.Name = "DgvCart";
            this.DgvCart.RowHeadersWidth = 51;
            this.DgvCart.RowTemplate.Height = 24;
            this.DgvCart.Size = new System.Drawing.Size(382, 170);
            this.DgvCart.TabIndex = 10;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "bookID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(910, 29);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(0, 36);
            this.UsernameLabel.TabIndex = 11;
            // 
            // BtnSignOut
            // 
            this.BtnSignOut.Location = new System.Drawing.Point(977, 112);
            this.BtnSignOut.Name = "BtnSignOut";
            this.BtnSignOut.Size = new System.Drawing.Size(100, 36);
            this.BtnSignOut.TabIndex = 12;
            this.BtnSignOut.Text = "Sign Out";
            this.BtnSignOut.UseVisualStyleBackColor = true;
            this.BtnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // BtnReturnBooks
            // 
            this.BtnReturnBooks.Location = new System.Drawing.Point(977, 176);
            this.BtnReturnBooks.Name = "BtnReturnBooks";
            this.BtnReturnBooks.Size = new System.Drawing.Size(100, 41);
            this.BtnReturnBooks.TabIndex = 13;
            this.BtnReturnBooks.Text = "ReturnBooks";
            this.BtnReturnBooks.UseVisualStyleBackColor = true;
            this.BtnReturnBooks.Click += new System.EventHandler(this.BtnReturnBooks_Click);
            // 
            // BookStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 525);
            this.Controls.Add(this.BtnReturnBooks);
            this.Controls.Add(this.BtnSignOut);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.DgvCart);
            this.Controls.Add(this.Your);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvSearchResult);
            this.Controls.Add(this.BookSearchBoxTB);
            this.Name = "BookStoreForm";
            this.Text = "BookStore";
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookSearchBoxTB;
        private System.Windows.Forms.DataGridView DgvSearchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label Your;
        private System.Windows.Forms.DataGridView DgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button BtnSignOut;
        private System.Windows.Forms.Button BtnReturnBooks;
    }
}