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
            this.components = new System.ComponentModel.Container();
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
            this.DgvBookCrud = new System.Windows.Forms.DataGridView();
            this.libraryManagement01DataSet = new LibraryManagement.LibraryManagement01DataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new LibraryManagement.LibraryManagement01DataSetTableAdapters.BooksTableAdapter();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookCrud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagement01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // DgvBookCrud
            // 
            this.DgvBookCrud.AutoGenerateColumns = false;
            this.DgvBookCrud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBookCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookCrud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookGenreDataGridViewTextBoxColumn,
            this.bookPriceDataGridViewTextBoxColumn});
            this.DgvBookCrud.DataSource = this.booksBindingSource;
            this.DgvBookCrud.Location = new System.Drawing.Point(295, 44);
            this.DgvBookCrud.Name = "DgvBookCrud";
            this.DgvBookCrud.RowHeadersWidth = 51;
            this.DgvBookCrud.RowTemplate.Height = 24;
            this.DgvBookCrud.Size = new System.Drawing.Size(630, 440);
            this.DgvBookCrud.TabIndex = 12;
            // 
            // libraryManagement01DataSet
            // 
            this.libraryManagement01DataSet.DataSetName = "LibraryManagement01DataSet";
            this.libraryManagement01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryManagement01DataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "bookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "bookID";
            this.bookIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "bookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "bookName";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // bookGenreDataGridViewTextBoxColumn
            // 
            this.bookGenreDataGridViewTextBoxColumn.DataPropertyName = "bookGenre";
            this.bookGenreDataGridViewTextBoxColumn.HeaderText = "bookGenre";
            this.bookGenreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookGenreDataGridViewTextBoxColumn.Name = "bookGenreDataGridViewTextBoxColumn";
            // 
            // bookPriceDataGridViewTextBoxColumn
            // 
            this.bookPriceDataGridViewTextBoxColumn.DataPropertyName = "bookPrice";
            this.bookPriceDataGridViewTextBoxColumn.HeaderText = "bookPrice";
            this.bookPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookPriceDataGridViewTextBoxColumn.Name = "bookPriceDataGridViewTextBoxColumn";
            // 
            // BookCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 515);
            this.Controls.Add(this.DgvBookCrud);
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
            this.Name = "BookCrudForm";
            this.Text = "BookCrudForm";
            this.Load += new System.EventHandler(this.BookCrudForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookCrud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagement01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView DgvBookCrud;
        private LibraryManagement01DataSet libraryManagement01DataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryManagement01DataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceDataGridViewTextBoxColumn;
    }
}