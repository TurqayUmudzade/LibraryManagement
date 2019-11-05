namespace LibraryManagement.Forms
{
    partial class AdminDashboardForm
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
            this.DgvTodaysRetuns = new System.Windows.Forms.DataGridView();
            this.BtnTodayR = new System.Windows.Forms.Button();
            this.BtnTomorrow = new System.Windows.Forms.Button();
            this.BtnLate = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DgvExel = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvTomorrow = new System.Windows.Forms.DataGridView();
            this.DgvLate = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPurchView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTodaysRetuns)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLate)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTodaysRetuns
            // 
            this.DgvTodaysRetuns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTodaysRetuns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTodaysRetuns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvTodaysRetuns.Location = new System.Drawing.Point(12, 99);
            this.DgvTodaysRetuns.Name = "DgvTodaysRetuns";
            this.DgvTodaysRetuns.RowHeadersWidth = 51;
            this.DgvTodaysRetuns.RowTemplate.Height = 24;
            this.DgvTodaysRetuns.Size = new System.Drawing.Size(692, 241);
            this.DgvTodaysRetuns.TabIndex = 0;
            // 
            // BtnTodayR
            // 
            this.BtnTodayR.Location = new System.Drawing.Point(21, 25);
            this.BtnTodayR.Name = "BtnTodayR";
            this.BtnTodayR.Size = new System.Drawing.Size(186, 46);
            this.BtnTodayR.TabIndex = 1;
            this.BtnTodayR.Text = "Today\'s Returns";
            this.BtnTodayR.UseVisualStyleBackColor = true;
            this.BtnTodayR.Click += new System.EventHandler(this.BtnTodayR_Click);
            // 
            // BtnTomorrow
            // 
            this.BtnTomorrow.Location = new System.Drawing.Point(238, 25);
            this.BtnTomorrow.Name = "BtnTomorrow";
            this.BtnTomorrow.Size = new System.Drawing.Size(186, 46);
            this.BtnTomorrow.TabIndex = 2;
            this.BtnTomorrow.Text = "Tomorrows\'s Returns";
            this.BtnTomorrow.UseVisualStyleBackColor = true;
            this.BtnTomorrow.Click += new System.EventHandler(this.BtnTomorrow_Click);
            // 
            // BtnLate
            // 
            this.BtnLate.Location = new System.Drawing.Point(447, 25);
            this.BtnLate.Name = "BtnLate";
            this.BtnLate.Size = new System.Drawing.Size(186, 46);
            this.BtnLate.TabIndex = 3;
            this.BtnLate.Text = "Late Returns";
            this.BtnLate.UseVisualStyleBackColor = true;
            this.BtnLate.Click += new System.EventHandler(this.BtnLate_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(6, 71);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(248, 22);
            this.dateTimePickerStart.TabIndex = 4;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(9, 149);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(253, 22);
            this.dateTimePickerEnd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "To:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPurchView);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerEnd);
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 355);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagement.Properties.Resources.iconfinder_Excel_D_104853__1_;
            this.pictureBox1.Location = new System.Drawing.Point(121, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 49);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DgvExel
            // 
            this.DgvExel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvExel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Boo,
            this.Column7,
            this.Column8});
            this.DgvExel.Location = new System.Drawing.Point(472, 403);
            this.DgvExel.Name = "DgvExel";
            this.DgvExel.RowHeadersWidth = 51;
            this.DgvExel.RowTemplate.Height = 24;
            this.DgvExel.Size = new System.Drawing.Size(605, 344);
            this.DgvExel.TabIndex = 10;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "OrderID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Book";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Boo
            // 
            this.Boo.HeaderText = "Price";
            this.Boo.MinimumWidth = 6;
            this.Boo.Name = "Boo";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Username";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Date";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // DgvTomorrow
            // 
            this.DgvTomorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTomorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTomorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DgvTomorrow.Location = new System.Drawing.Point(12, 99);
            this.DgvTomorrow.Name = "DgvTomorrow";
            this.DgvTomorrow.RowHeadersWidth = 51;
            this.DgvTomorrow.RowTemplate.Height = 24;
            this.DgvTomorrow.Size = new System.Drawing.Size(692, 241);
            this.DgvTomorrow.TabIndex = 11;
            // 
            // DgvLate
            // 
            this.DgvLate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DgvLate.Location = new System.Drawing.Point(12, 99);
            this.DgvLate.Name = "DgvLate";
            this.DgvLate.RowHeadersWidth = 51;
            this.DgvLate.RowTemplate.Height = 24;
            this.DgvLate.Size = new System.Drawing.Size(692, 241);
            this.DgvLate.TabIndex = 12;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "UserID";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "User Full Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Phonenumber";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Books Owned";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "UserID";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "User Full Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Phonenumber";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Books Owned";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "UserID";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "UserName";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "User Full Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phonenumber";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Books Owned";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // BtnPurchView
            // 
            this.BtnPurchView.Location = new System.Drawing.Point(6, 197);
            this.BtnPurchView.Name = "BtnPurchView";
            this.BtnPurchView.Size = new System.Drawing.Size(109, 46);
            this.BtnPurchView.TabIndex = 13;
            this.BtnPurchView.Text = "View Purchases";
            this.BtnPurchView.UseVisualStyleBackColor = true;
            this.BtnPurchView.Click += new System.EventHandler(this.BtnPurchView_Click);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 759);
            this.Controls.Add(this.DgvLate);
            this.Controls.Add(this.DgvTomorrow);
            this.Controls.Add(this.DgvExel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnLate);
            this.Controls.Add(this.BtnTomorrow);
            this.Controls.Add(this.BtnTodayR);
            this.Controls.Add(this.DgvTodaysRetuns);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTodaysRetuns)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTodaysRetuns;
        private System.Windows.Forms.Button BtnTodayR;
        private System.Windows.Forms.Button BtnTomorrow;
        private System.Windows.Forms.Button BtnLate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DgvExel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DgvTomorrow;
        private System.Windows.Forms.DataGridView DgvLate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button BtnPurchView;
    }
}