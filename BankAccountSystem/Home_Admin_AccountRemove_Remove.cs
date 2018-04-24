using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using BO;
namespace BankAccountSystemUI
{
    public partial class Home_Admin_AccountRemove_Remove : Form
    {
        public Home_Admin_AccountRemove_Remove()
        {
            InitializeComponent();
            timer1.Start();
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
        public int index1;
        public void giveIndex(int i)
        {
            index1 = i;
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());
            
            try
            {
                int temp = index1;

                int i;
                int k = 1; ;
                for (i = index1; list[i].ToString() != "*****"; i++)
                {
                    k++;
                }
                list.RemoveRange(temp,k);

                account_BO.createAccount(list);
                MessageBox.Show("Account remove successfull...");

                this.Hide();
                Home_Admin home_Admin = new Home_Admin();
                home_Admin.Show();
            }
            catch
            {
                MessageBox.Show("Wrong!!!");
            }
         }
           
        
        private void Home_Admin_AccountRemove_Remove_Load(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());
            int i;
            for (i = index1; list[i].ToString() != "*****"; i++)
            {

            }
            string k = list[i - 1].ToString();
            int index = index1;
            int temp = index1;
            userID.Text = list[index].ToString();
            userName.Text = list[index + 1].ToString();
            address.Text = list[index + 2].ToString();
            phoneNo.Text = list[index + 3].ToString();
            presentPictureBox.Load(k);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountRemove h = new Home_Admin_AccountRemove();
            h.Show();
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
