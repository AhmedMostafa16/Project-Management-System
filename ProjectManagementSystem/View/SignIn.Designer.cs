namespace ProjectManagementSystem
{
    partial class SignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.button1 = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.ForgotPasswordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(408, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.UserNameTextBox.Location = new System.Drawing.Point(83, 281);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(282, 16);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.PasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTxtBox.Location = new System.Drawing.Point(83, 402);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(282, 16);
            this.PasswordTxtBox.TabIndex = 1;
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignInBtn.FlatAppearance.BorderSize = 0;
            this.SignInBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.SignInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SignInBtn.Location = new System.Drawing.Point(170, 478);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(111, 28);
            this.SignInBtn.TabIndex = 0;
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // ForgotPasswordBtn
            // 
            this.ForgotPasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPasswordBtn.FlatAppearance.BorderSize = 0;
            this.ForgotPasswordBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ForgotPasswordBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ForgotPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgotPasswordBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ForgotPasswordBtn.Location = new System.Drawing.Point(146, 552);
            this.ForgotPasswordBtn.Name = "ForgotPasswordBtn";
            this.ForgotPasswordBtn.Size = new System.Drawing.Size(158, 13);
            this.ForgotPasswordBtn.TabIndex = 0;
            this.ForgotPasswordBtn.UseVisualStyleBackColor = false;
            this.ForgotPasswordBtn.Click += new System.EventHandler(this.ForgotPasswordBtn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.ControlBox = false;
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.ForgotPasswordBtn);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignIn_MouseDown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Button ForgotPasswordBtn;
    }
}
