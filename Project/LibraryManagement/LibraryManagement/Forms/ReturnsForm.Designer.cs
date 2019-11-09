﻿namespace LibraryManagement.Forms
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
            this.components = new System.ComponentModel.Container();
            this.DgvMyPurchaes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPay = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TBOverall = new System.Windows.Forms.TextBox();
            this.labelOverallCost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.DgvMyPurchaes.Location = new System.Drawing.Point(12, 73);
            this.DgvMyPurchaes.Name = "DgvMyPurchaes";
            this.DgvMyPurchaes.RowHeadersWidth = 51;
            this.DgvMyPurchaes.RowTemplate.Height = 24;
            this.DgvMyPurchaes.Size = new System.Drawing.Size(776, 150);
            this.DgvMyPurchaes.TabIndex = 0;
            this.DgvMyPurchaes.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMyPurchaes_RowHeaderMouseDoubleClick);
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
            // BtnPay
            // 
            this.BtnPay.Location = new System.Drawing.Point(703, 241);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(85, 40);
            this.BtnPay.TabIndex = 1;
            this.BtnPay.Text = "Sum Up";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(12, 352);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(88, 40);
            this.BtnConfirm.TabIndex = 2;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Cost:";
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(12, 313);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(138, 22);
            this.TbPrice.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TBOverall
            // 
            this.TBOverall.Location = new System.Drawing.Point(554, 261);
            this.TBOverall.Name = "TBOverall";
            this.TBOverall.Size = new System.Drawing.Size(138, 22);
            this.TBOverall.TabIndex = 6;
            // 
            // labelOverallCost
            // 
            this.labelOverallCost.AutoSize = true;
            this.labelOverallCost.Location = new System.Drawing.Point(551, 241);
            this.labelOverallCost.Name = "labelOverallCost";
            this.labelOverallCost.Size = new System.Drawing.Size(89, 17);
            this.labelOverallCost.TabIndex = 7;
            this.labelOverallCost.Text = "Overall Cost:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "< Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReturnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelOverallCost);
            this.Controls.Add(this.TBOverall);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.DgvMyPurchaes);
            this.Name = "ReturnsForm";
            this.Text = "ReturnsForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMyPurchaes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMyPurchaes;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TBOverall;
        private System.Windows.Forms.Label labelOverallCost;
        private System.Windows.Forms.Button button1;
    }
}