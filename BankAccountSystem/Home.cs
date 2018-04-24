using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO;
namespace BankAccountSystemUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void setFullScreen()
        {
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;
            Location = new Point(0, 0);
            Size = new Size(x, y);
        }
        private void setMainPanel()
        {
            int mX = (Width - panel5.Width) / 2;
            int mY = (Height - panel5.Height) / 2;
            panel5.Location = new Point(mX, mY);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setFullScreen();
            setMainPanel();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void logIn_Click(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            if (userName.Text == "" || password.Text == "")
            {
                MessageBox.Show("Wrong!!! Enter the information fully");
            }
            else
            {
                if (account_BO.security_Checker(userName.Text, password.Text))
                {
                    this.Hide();
                    Home_Admin home_Admin = new Home_Admin();
                    home_Admin.Show();
                }
                else
                {
                    MessageBox.Show("Wrong UserName or Password");
                    userName.Clear();
                    password.Clear();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Name And Password Is Required!!");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            time_lbl.Text = dt.ToString();
        }
    }
}
