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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr a, int b, int c, int d);
        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)//Exit Button
        {
            Environment.Exit(0);
        }

        private void SBTMBtn_Click(object sender, EventArgs e)//Submit Button   
        {
            var s = new Verify();
            s.Show();
            this.Hide();
        }
    }
}


