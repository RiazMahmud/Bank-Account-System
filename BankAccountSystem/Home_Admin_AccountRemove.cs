using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using BO;
namespace BankAccountSystemUI
{
    public partial class Home_Admin_AccountRemove : Form
    {
        public Home_Admin_AccountRemove()
        {
            InitializeComponent();
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

        private void Home_Admin_AccountRemove_Load(object sender, EventArgs e)
        {

        }

        private void logIn_Click(object sender, EventArgs e)
        {

        }

        private void GoRemoveAccount_Click(object sender, EventArgs e)
        {
            Account_BO accountBO = new Account_BO();
            ArrayList list = new ArrayList(accountBO.readAccount());
            if (searchRemoveAccount.Text == "")
            {
                MessageBox.Show("Wrong!!! Enter the information fully");
            }
            else
            {
                try
                {
                    int flag = 0;
                    for (int i = 0; i < list.Count; i++)
                    {

                        if (list[i].ToString() == searchRemoveAccount.Text)
                        {
                            Home_Admin_AccountRemove_Remove home_Admin_AccountRemove_Remove = new Home_Admin_AccountRemove_Remove();
                            home_Admin_AccountRemove_Remove.giveIndex(list.IndexOf(list[i].ToString()));
                            home_Admin_AccountRemove_Remove.Show();
                            this.Hide();

                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("Sorry!!! This account number isn't Exist");
                        searchRemoveAccount.Clear();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No User Exists");
                }
            }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountStatement home_Admin_Accountstatement = new Home_Admin_AccountStatement();
            home_Admin_Accountstatement.Show();
        }

        private void searchRemoveAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin home_Admin = new Home_Admin();
            home_Admin.Show();
        }
    }
}
