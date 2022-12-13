using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ProjectManagementSystem
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr a, int b, int c, int d);
        private void AddProject_Load(object sender, EventArgs e)
        {

        }

        private void AddProject_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)//Exit Button
        {
            this.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private bool IsDigit(string x)
        {
            foreach (char c in x)
            {
                bool m = false;
                for (char ch = '0'; ch <= '9'; ch++)
                {
                    if (c == ch)
                    {
                        m = true;
                        break;
                    }
                }
                if (m == false)
                {
                    return false;
                }
            }
            return true;
        }
        private void DayTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!IsDigit(DayTextBox.Text))
            {
                MessageBox.Show("Date must be in digits!");
                DayTextBox.Clear();
            }
        }

        private void MonthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsDigit(MonthTextBox.Text))
            {
                MessageBox.Show("Date must be in digits!");
                MonthTextBox.Clear();
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsDigit(YearTextBox.Text))
            {
                MessageBox.Show("Date must be in digits!");
                YearTextBox.Clear();
            }
        }

        private void DayTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!IsDigit(DayTextBox2.Text))
            {
                MessageBox.Show("Date must be in digits!");
                DayTextBox2.Clear();
            }
        }

        private void MonthTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!IsDigit(MonthTextBox2.Text))
            {
                MessageBox.Show("Date must be in digits!");
                MonthTextBox2.Clear();
            }
        }

        private void YearTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!IsDigit(YearTextBox2.Text))
            {
                MessageBox.Show("Date must be in digits!");
                YearTextBox2.Clear();
            }
        }

    }
}
