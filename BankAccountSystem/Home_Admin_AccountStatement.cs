using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ENTITY;
using BO;
using System.Collections;
using System.IO;
namespace BankAccountSystemUI
{
    public partial class Home_Admin_AccountStatement : Form
    {


        public int index;
        public Home_Admin_AccountStatement()
        {
            InitializeComponent();
            
        }

        private void logIn_Click(object sender, EventArgs e)
        {

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

        private void ShowAccountStatement_Click(object sender, EventArgs e)
        {
            Account_BO accountBO = new Account_BO();
            ArrayList list = new ArrayList(accountBO.readAccount());
            if (AccountStatementSearch.Text == "" || stYear.Text == "")
            {
                MessageBox.Show("Wrong!!! Enter the information fully");
            }
            else
            {
                try
                {
                    int flag = 0;
                    int flag1 = 0;
                    int i1 = 0, i2 = 0;
                    for (int i = 0; i < list.Count; i++)
                    {

                        if (list[i].ToString() == AccountStatementSearch.Text)
                        {
                            flag = 1;
                            i1 = i;
                            break;
                        }
                    }
                    for (int i = i1; list[i].ToString() != "*****"; i++)
                    {

                        if (list[i].ToString() == stYear.Text)
                        {

                            flag1 = 1;
                            i2 = i;
                            break;
                        }
                    }
                    if (flag == 1 && flag1 == 1)
                    {
                        try
                        {
                            Home_Admin_AccountStatement_Show home_Admin_AccountStatement_Show = new Home_Admin_AccountStatement_Show();
                            home_Admin_AccountStatement_Show.giveIndex(i1);
                            home_Admin_AccountStatement_Show.giveYear(i2);

                            this.Hide();
                            home_Admin_AccountStatement_Show.Show();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error!!!");
                        }
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("Sorry!!! This account number isn't Exist");
                        AccountStatementSearch.Clear();
                    }
                    if (flag1 == 0)
                    {
                        MessageBox.Show("Sorry!!! This year isn't Exist");
                        stYear.ResetText();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No User Exists");
                }
            }
        }
        private void AccountStatementSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Admin_AccountStatement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin home_Admin = new Home_Admin();
            home_Admin.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
