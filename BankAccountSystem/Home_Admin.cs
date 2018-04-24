using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CalendarClock;
namespace BankAccountSystemUI
{
    public partial class Home_Admin : Form
    {
        public Home_Admin()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Home_Admin_Load(object sender, EventArgs e)
        {

        }

        private void CreateNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_CreateAccount home_Admin_Create = new Home_Admin_CreateAccount();
            home_Admin_Create.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show(); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin home_Admin = new Home_Admin();
            home_Admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_CreateAccount home_Admin_Create = new Home_Admin_CreateAccount();
            home_Admin_Create.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountStatement home_Admin_Accountstatement = new Home_Admin_AccountStatement();
            home_Admin_Accountstatement.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountUpdate home_Admin_AccountUpdate = new Home_Admin_AccountUpdate();
            home_Admin_AccountUpdate.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountRemove home_Admin_AccountRemove = new Home_Admin_AccountRemove();
            home_Admin_AccountRemove.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountWithdraw home_Admin_AccountWithdraw = new Home_Admin_AccountWithdraw();
            home_Admin_AccountWithdraw.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void AccountStatement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountStatement home_Admin_Accountstatement = new Home_Admin_AccountStatement();
            home_Admin_Accountstatement.Show();
        }

        private void UpdateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountUpdate home_Admin_AccountUpdate = new Home_Admin_AccountUpdate();
            home_Admin_AccountUpdate.Show();
        }

        private void RemoveAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountRemove home_Admin_AccountRemove = new Home_Admin_AccountRemove();
            home_Admin_AccountRemove.Show();
        }

        private void WithdrawBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountWithdraw home_Admin_AccountWithdraw = new Home_Admin_AccountWithdraw();
            home_Admin_AccountWithdraw.Show();
        }

        private void DepositBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocumentChecker d = new DocumentChecker();
            d.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            time_lbl.Text = dt.ToString();
        }
    }
}
