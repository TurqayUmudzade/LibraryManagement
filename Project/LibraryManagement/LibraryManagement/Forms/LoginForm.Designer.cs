namespace LibraryManagement
{
    partial class LoginForm
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
            this.LoginUsernameTB = new System.Windows.Forms.TextBox();
            this.LoginPasswordTb = new System.Windows.Forms.TextBox();
            this.BTN_SignIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginUsernameTB
            // 
            this.LoginUsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginUsernameTB.Location = new System.Drawing.Point(85, 163);
            this.LoginUsernameTB.Name = "LoginUsernameTB";
            this.LoginUsernameTB.Size = new System.Drawing.Size(207, 15);
            this.LoginUsernameTB.TabIndex = 1;
            this.LoginUsernameTB.Text = "Username";
            this.LoginUsernameTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginUsernameTB_MouseClick);
            // 
            // LoginPasswordTb
            // 
            this.LoginPasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPasswordTb.Location = new System.Drawing.Point(85, 245);
            this.LoginPasswordTb.Name = "LoginPasswordTb";
            this.LoginPasswordTb.Size = new System.Drawing.Size(207, 15);
            this.LoginPasswordTb.TabIndex = 3;
            this.LoginPasswordTb.Text = "Password";
            // 
            // BTN_SignIn
            // 
            this.BTN_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.BTN_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SignIn.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SignIn.ForeColor = System.Drawing.Color.Black;
            this.BTN_SignIn.Location = new System.Drawing.Point(38, 291);
            this.BTN_SignIn.Name = "BTN_SignIn";
            this.BTN_SignIn.Size = new System.Drawing.Size(254, 47);
            this.BTN_SignIn.TabIndex = 4;
            this.BTN_SignIn.Text = "Sign In";
            this.BTN_SignIn.UseVisualStyleBackColor = false;
            this.BTN_SignIn.Click += new System.EventHandler(this.BTN_SignIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagement.Properties.Resources._471px_Google__G__Logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(132, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManagement.Properties.Resources._480px_Google_Contacts_logo_vector_svg;
            this.pictureBox2.Location = new System.Drawing.Point(38, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LibraryManagement.Properties.Resources._392px_Google_Verified_Badge_svg;
            this.pictureBox3.Location = new System.Drawing.Point(38, 236);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel1.Location = new System.Drawing.Point(85, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 4);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.panel2.Location = new System.Drawing.Point(85, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 4);
            this.panel2.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 385);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_SignIn);
            this.Controls.Add(this.LoginPasswordTb);
            this.Controls.Add(this.LoginUsernameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LoginUsernameTB;
        private System.Windows.Forms.TextBox LoginPasswordTb;
        private System.Windows.Forms.Button BTN_SignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

