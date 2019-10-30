namespace LibraryManagement.Forms
{
    partial class ReturnsForm
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
            this.DgvMyPurchaes = new System.Windows.Forms.DataGridView();
            this.BtnPay = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMyPurchaes)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMyPurchaes
            // 
            this.DgvMyPurchaes.AllowUserToAddRows = false;
            this.DgvMyPurchaes.AllowUserToDeleteRows = false;
            this.DgvMyPurchaes.AllowUserToResizeColumns = false;
            this.DgvMyPurchaes.AllowUserToResizeRows = false;
            this.DgvMyPurchaes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMyPurchaes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMyPurchaes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvMyPurchaes.Location = new System.Drawing.Point(12, 29);
            this.DgvMyPurchaes.Name = "DgvMyPurchaes";
            this.DgvMyPurchaes.RowHeadersWidth = 51;
            this.DgvMyPurchaes.RowTemplate.Height = 24;
            this.DgvMyPurchaes.Size = new System.Drawing.Size(776, 150);
            this.DgvMyPurchaes.TabIndex = 0;
            // 
            // BtnPay
            // 
            this.BtnPay.Location = new System.Drawing.Point(12, 232);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(85, 40);
            this.BtnPay.TabIndex = 1;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(140, 232);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(88, 40);
            this.BtnConfirm.TabIndex = 2;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Order No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Book Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Return Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // ReturnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.DgvMyPurchaes);
            this.Name = "ReturnsForm";
            this.Text = "ReturnsForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMyPurchaes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMyPurchaes;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}