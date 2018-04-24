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
    public partial class Home_Admin_Withdraw_Show : Form
    {
        public Home_Admin_Withdraw_Show()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        int index1 = 0;
        int index2 = 0;
        int m = 0;
        public void giveData(int i, int j,int k)
        {
            index1 = i;
            index2 = j;
            m = k;
        }
        Home_Admin_AccountWithdraw home_admin = new Home_Admin_AccountWithdraw();
        private void yes_Click(object sender, EventArgs e)
        {
            int j = index2 + 2;
            int j1 = index2 + 1;
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());
            ArrayList lastList = new ArrayList();
            ArrayList saveList = new ArrayList();
            if (account_BO.security_Checker("rintu", password.Text))
            {
                if (index2 - index1 == 5)
                {
                    if (index1 != 0)
                    {
                        for (int i = 0; i < index1; i++)
                        {
                            saveList.Add(list[i]);
                        }

                        for (int i = index1; i <= index2 + 1; i++)
                        {
                            saveList.Add(list[i]);
                        }
                        for (int k = j; k < list.Count; k++)
                        {
                            lastList.Add(list[k]);
                        }
                        if (m == 1)
                            saveList.Add("January");
                        if (m == 2)
                            saveList.Add("February");
                        if (m == 3)
                            saveList.Add("March");
                        if (m == 4)
                            saveList.Add("April");
                        if (m == 5)
                            saveList.Add("May");
                        if (m == 6)
                            saveList.Add("June");
                        if (m == 7)
                            saveList.Add("July");
                        if (m == 8)
                            saveList.Add("August");
                        if (m == 9)
                            saveList.Add("September");
                        if (m == 10)
                            saveList.Add("October");
                        if (m == 11)
                            saveList.Add("November");
                        if (m == 12)
                            saveList.Add("December");
                        for (int i = 0; i < lastList.Count; i++)
                        {
                            saveList.Add(lastList[i]);
                        }

                        account_BO.createAccount(saveList);
                        MessageBox.Show("Payment Successfully Done");
                        this.Hide();

                        home_admin.Show();
                    }
                    else
                    {
                        for (int i = index1; i <= index2 + 1; i++)
                        {
                            saveList.Add(list[i]);
                        }
                        for (int k = j; k < list.Count; k++)
                        {
                            lastList.Add(list[k]);
                        }

                        if (m == 1)
                            saveList.Add("January");
                        if (m == 2)
                            saveList.Add("February");
                        if (m == 3)
                            saveList.Add("March");
                        if (m == 4)
                            saveList.Add("April");
                        if (m == 5)
                            saveList.Add("May");
                        if (m == 6)
                            saveList.Add("June");
                        if (m == 7)
                            saveList.Add("July");
                        if (m == 8)
                            saveList.Add("August");
                        if (m == 9)
                            saveList.Add("September");
                        if (m == 10)
                            saveList.Add("October");
                        if (m == 11)
                            saveList.Add("November");
                        if (m == 12)
                            saveList.Add("December");
                        for (int i = 0; i < lastList.Count; i++)
                        {
                            saveList.Add(lastList[i]);
                        }

                        account_BO.createAccount(saveList);
                        MessageBox.Show("Payment Successfully Done");
                        this.Hide();
                        home_admin.Show();

                    }
                }
                else
                {
                    if (index1 != 0)
                    {
                        for (int i = 0; i < index1; i++)
                        {
                            saveList.Add(list[i]);
                        }

                        for (int i = index1; i <= index2; i++)
                        {
                            saveList.Add(list[i]);
                        }
                        for (int k = j1; k < list.Count; k++)
                        {
                            lastList.Add(list[k]);
                        }
                        if (m == 1)
                            saveList.Add("January");
                        if (m == 2)
                            saveList.Add("February");
                        if (m == 3)
                            saveList.Add("March");
                        if (m == 4)
                            saveList.Add("April");
                        if (m == 5)
                            saveList.Add("May");
                        if (m == 6)
                            saveList.Add("June");
                        if (m == 7)
                            saveList.Add("July");
                        if (m == 8)
                            saveList.Add("August");
                        if (m == 9)
                            saveList.Add("September");
                        if (m == 10)
                            saveList.Add("October");
                        if (m == 11)
                            saveList.Add("November");
                        if (m == 12)
                            saveList.Add("December");
                        for (int i = 0; i < lastList.Count; i++)
                        {
                            saveList.Add(lastList[i]);
                        }

                        account_BO.createAccount(saveList);
                        MessageBox.Show("Payment Successfully Done");
                        this.Hide();

                        home_admin.Show();
                    }
                    else
                    {
                        for (int i = index1; i <= index2; i++)
                        {
                            saveList.Add(list[i]);
                        }
                        for (int k = j1; k < list.Count; k++)
                        {
                            lastList.Add(list[k]);
                        }

                        if (m == 1)
                            saveList.Add("January");
                        if (m == 2)
                            saveList.Add("February");
                        if (m == 3)
                            saveList.Add("March");
                        if (m == 4)
                            saveList.Add("April");
                        if (m == 5)
                            saveList.Add("May");
                        if (m == 6)
                            saveList.Add("June");
                        if (m == 7)
                            saveList.Add("July");
                        if (m == 8)
                            saveList.Add("August");
                        if (m == 9)
                            saveList.Add("September");
                        if (m == 10)
                            saveList.Add("October");
                        if (m == 11)
                            saveList.Add("November");
                        if (m == 12)
                            saveList.Add("December");
                        for (int i = 0; i < lastList.Count; i++)
                        {
                            saveList.Add(lastList[i]);
                        }

                        account_BO.createAccount(saveList);
                        MessageBox.Show("Payment Successfully Done");
                        this.Hide();
                        home_admin.Show();

                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong Password !");
                password.Clear();
            }
                
        }

        private void No_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Cancell");
            this.Hide();
            Home_Admin_AccountWithdraw h = new Home_Admin_AccountWithdraw();
            h.Show();
        }

        private void Home_Admin_Withdraw_Show_Load(object sender, EventArgs e)
        {

        }
        }

    }

