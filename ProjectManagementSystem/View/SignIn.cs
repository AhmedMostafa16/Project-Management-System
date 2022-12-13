using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementSystem
{
    public partial class SignIn : Form
    {
        public static string UserName, Password;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr a, int b, int c, int d);
        public SignIn()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)//Close Button
        {
            Environment.Exit(0);
        }
        private void SignInBtn_Click(object sender, EventArgs e)//SignINButton
        {
            UserName = UserNameTextBox.Text;
            Password = PasswordTxtBox.Text;
            var ProjectFormListShow = new ProjectFormList();
            ProjectFormListShow.Show();
            this.Hide();
        }
        private void ForgotPasswordBtn_Click(object sender, EventArgs e)//SignINButton
        {
            var ForgotPasswordShow = new ForgotPassword();
            ForgotPasswordShow.Show();
            this.Hide();
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
