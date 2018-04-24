using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using BO;
namespace BankAccountSystemUI
{
    public partial class Home_Admin_AccountUpdate_Update_Show : Form
    {
        public Home_Admin_AccountUpdate_Update_Show()
        {
            InitializeComponent();
            timer1.Start();
        }
        public int index;
        public void giveIndex(int i)
        {
            index = i;
        }
        private void Home_Admin_AccountUpdate_Update_Show_Load(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());
            int i;
            for (i = index; list[i].ToString() != "*****"; i++)
            {

            }
            string k = list[i - 1].ToString();
            updatedAccountNo.Text = list[index].ToString();
            updatedAccountType.Text = list[index+1].ToString();
            updatedHolderName.Text = list[index+2].ToString();
            updatedaddress.Text = list[index+3].ToString();
            updatedPictureBox.Load(k);
            
        }

        private void closeUpdateShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountUpdate h = new Home_Admin_AccountUpdate();
            h.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            time_lbl.Text = dt.ToString();
        }
    }
}
