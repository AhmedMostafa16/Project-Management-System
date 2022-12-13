namespace ProjectManagementSystem
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.SBTMBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.UserNameTextBox.Location = new System.Drawing.Point(84, 324);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(282, 16);
            this.UserNameTextBox.TabIndex = 4;
            // 
            // SBTMBtn
            // 
            this.SBTMBtn.BackColor = System.Drawing.Color.Transparent;
            this.SBTMBtn.FlatAppearance.BorderSize = 0;
            this.SBTMBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.SBTMBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SBTMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SBTMBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SBTMBtn.Location = new System.Drawing.Point(170, 447);
            this.SBTMBtn.Name = "SBTMBtn";
            this.SBTMBtn.Size = new System.Drawing.Size(110, 28);
            this.SBTMBtn.TabIndex = 2;
            this.SBTMBtn.UseVisualStyleBackColor = false;
            this.SBTMBtn.Click += new System.EventHandler(this.SBTMBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(409, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.SBTMBtn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForgotPassword_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Button SBTMBtn;
        private System.Windows.Forms.Button button1;
    }
}