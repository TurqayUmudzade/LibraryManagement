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
            this.label1 = new System.Windows.Forms.Label();
            this.LoginUsernameTB = new System.Windows.Forms.TextBox();
            this.LoginPasswordTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // LoginUsernameTB
            // 
            this.LoginUsernameTB.Location = new System.Drawing.Point(57, 89);
            this.LoginUsernameTB.Name = "LoginUsernameTB";
            this.LoginUsernameTB.Size = new System.Drawing.Size(207, 22);
            this.LoginUsernameTB.TabIndex = 1;
            // 
            // LoginPasswordTb
            // 
            this.LoginPasswordTb.Location = new System.Drawing.Point(57, 171);
            this.LoginPasswordTb.Name = "LoginPasswordTb";
            this.LoginPasswordTb.Size = new System.Drawing.Size(207, 22);
            this.LoginPasswordTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // BTN_SignIn
            // 
            this.BTN_SignIn.Location = new System.Drawing.Point(95, 217);
            this.BTN_SignIn.Name = "BTN_SignIn";
            this.BTN_SignIn.Size = new System.Drawing.Size(122, 47);
            this.BTN_SignIn.TabIndex = 4;
            this.BTN_SignIn.Text = "SIgn In";
            this.BTN_SignIn.UseVisualStyleBackColor = true;
            this.BTN_SignIn.Click += new System.EventHandler(this.BTN_SignIn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 288);
            this.Controls.Add(this.BTN_SignIn);
            this.Controls.Add(this.LoginPasswordTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginUsernameTB);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginUsernameTB;
        private System.Windows.Forms.TextBox LoginPasswordTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_SignIn;
    }
}

