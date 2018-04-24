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
    public partial class Home_Admin_AccountWithdraw_Withdraw : Form
    {
        public Home_Admin_AccountWithdraw_Withdraw()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void logIn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
        public int index1;
        public int index2;
        public void giveIndex(int i)
        {
            index1 = i;
        }
        public void giveYear(int i)
        {
            index2 = i;
        }
        private void Withdraw_Click(object sender, EventArgs e)
        {

        }

        private void Home_Admin_AccountWithdraw_Withdraw_Load(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_New home_add_new = new Home_Admin_Withdraw_New();
           
            try
            {
                
                Account_BO account_BO = new Account_BO();
                ArrayList list = new ArrayList(account_BO.readAccount());
                userName.Text = list[index1 + 1].ToString();
                year.Text = list[index2].ToString();
                userID1.Text = list[index1].ToString();
                stYearP.Text = list[index1 + 5].ToString();
                stMonthP.Text = list[index1 + 6].ToString();
                jan.Text = "DUE";
                feb.Text = "DUE";
                mar.Text = "DUE";
                apr.Text = "DUE";
                may.Text = "DUE";
                june.Text = "DUE";
                july.Text = "DUE";
                augu.Text = "DUE";
                sep.Text = "DUE";
                oct.Text = "DUE";
                nov.Text = "DUE";
                dec.Text = "DUE";
                if (index2 - index1 == 5)
                {


                    if (list[index2 + 1].ToString() == "February")
                    {
                        jan.Text = "NILL";
                    }
                    else if (list[index2 + 1].ToString() == "March")
                    {
                        jan.Text = "NILL";
                        feb.Text = "NILL";
                    }
                    else if (list[index2 + 1].ToString() == "April")
                    {
                        jan.Text = "NILL";
                        feb.Text = "NILL";
                        mar.Text = "NILL";
                    }
                    else if (list[index2 + 1].ToString() == "May")
                    {
                        jan.Text = "NILL";
                        feb.Text = "NILL";
                        mar.Text = "NILL";
                        apr.Text = "NILL";
                    }
                    else if (list[index2 + 1].ToString() == "June")
                    {
                        jan.Text = "NILL";
                        feb.Text = "NILL";
                        mar.Text = "NILL";
                        apr.Text = "NILL";
                        may.Text = "NILL";
                    }
                    else if (list[index2 + 1].ToString() == "July")
                    {
                        jan.Text = "NILL";
                        feb.Text = "NILL";
                        mar.Text = "NILL";
                        apr.Text = "NILL";
                        may.Text = "NILL";
                        june.Text = "NILL";
                    }
                    else if (list[index2 + 1].ToString() == "August")
                    {
                        jan.Text = "NILL";
                        feb.Text = "NILL";
                        mar.Text = "NILL";
                        apr.Text = "NILL";
                        may.Text = "NILL";
                        june.Text = "NILL";
                        july.Text = "NILL";
                    }
                    else if (list[index2 + 1].ToString() == "September")
                    {
                        jan.Text = "NILL";
                        feb.Text = "NILL";
                        mar.Text = "NILL";
                        apr.Text = "NILL";
                        may.Text = "NILL";
                        june.Text = "NILL";
                        july.Text = "NILL";
                        augu.Text = "NILL";
                    }
                    else if (list[index2 + 1].ToString() == "October")
                    {
                        jan.Text = "NILL";
                        feb.Text = "NILL";
                        mar.Text = "NILL";
                        apr.Text = "NILL";
                        may.Text = "NILL";
                        june.Text = "NILL";
                        july.Text = "NILL";
                        augu.Text = "NILL";
                        sep.Text = "NILL";
                    }
                    else if (list[index2 + 1].ToString() == "November")
                    {
                        jan.Text = "NILL";
                        feb.Text = "NILL";
                        mar.Text = "NILL";
                        apr.Text = "NILL";
                        may.Text = "NILL";
                        june.Text = "NILL";
                        july.Text = "NILL";
                        augu.Text = "NILL";
                        sep.Text = "NILL";
                        oct.Text = "NILL";
                    }
                    else if (list[index2 + 1].ToString() == "December")
                    {
                        jan.Text = "NILL";
                        feb.Text = "NILL";
                        mar.Text = "NILL";
                        apr.Text = "NILL";
                        may.Text = "NILL";
                        june.Text = "NILL";
                        july.Text = "NILL";
                        augu.Text = "NILL";
                        sep.Text = "NILL";
                        oct.Text = "NILL";
                        nov.Text = "NILL";
                    }
                }
                 for (int i = index2 + 1; list[i].ToString() != "*****"; i++)
                    {
                        if (list[i].ToString() == "January" || list[i].ToString() == "February" || list[i].ToString() == "March" || list[i].ToString() == "April" || list[i].ToString() == "May" || list[i].ToString() == "June" || list[i].ToString() == "July" || list[i].ToString() == "August" || list[i].ToString() == "September" || list[i].ToString() == "October" || list[i].ToString() == "November" || list[i].ToString() == "December")
                        {
                            if (list[i].ToString() == "January")
                            {
                                jan.Text = "PAID";
                            }
                            if (list[i].ToString() == "February")
                            {
                                feb.Text = "PAID";
                            }
                            if (list[i].ToString() == "March")
                            {
                                mar.Text = "PAID";
                            }
                            if (list[i].ToString() == "April")
                            {
                                apr.Text = "PAID";
                            }
                            if (list[i].ToString() == "May")
                            {
                                may.Text = "PAID";
                            }
                            if (list[i].ToString() == "June")
                            {
                                june.Text = "PAID";
                            }
                            if (list[i].ToString() == "July")
                            {
                                july.Text = "PAID";
                            }
                            if (list[i].ToString() == "August")
                            {
                                augu.Text = "PAID";
                            }
                            if (list[i].ToString() == "September")
                            {
                                sep.Text = "PAID";
                            }
                            if (list[i].ToString() == "October")
                            {
                                oct.Text = "PAID";
                            }
                            if (list[i].ToString() == "November")
                            {
                                nov.Text = "PAID";
                            }
                            if (list[i].ToString() == "December")
                            {
                                dec.Text = "PAID";
                            }
                        }
                        else
                        {
                            break;
                        }

                    }



                
            }
            catch (Exception)
            {
                MessageBox.Show("Error !!!");
            }
           
        }

       

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountWithdraw home_Admin_AccountWithdraw = new Home_Admin_AccountWithdraw();
            home_Admin_AccountWithdraw.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountWithdraw home_Admin_AccountWithdraw = new Home_Admin_AccountWithdraw();
            home_Admin_AccountWithdraw.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin home_Admin = new Home_Admin();
            home_Admin.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Home_Admin_CreateAccount home_Admin_Create = new Home_Admin_CreateAccount();
            home_Admin_Create.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountStatement home_Admin_Accountstatement = new Home_Admin_AccountStatement();
            home_Admin_Accountstatement.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountUpdate home_Admin_AccountUpdate = new Home_Admin_AccountUpdate();
            home_Admin_AccountUpdate.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountRemove home_Admin_AccountRemove = new Home_Admin_AccountRemove();
            home_Admin_AccountRemove.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
           
        }

        private void WithdrawBalance_Click(object sender, EventArgs e)
        {
            
        }

        private void WithdrawAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        
       
        private void payFeb_Click(object sender, EventArgs e)
        {
           
            
           
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
           
            try
            {

                if (feb.Text != "PAID" && feb.Text != "NILL")
                {

                    h2.Show();
                    h2.giveData(index1, index2,2);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }
                        
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
        }

        private void payJan_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();

            try
            {
                if (jan.Text != "PAID" && jan.Text != "NILL")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 1);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
            
        }

        private void payMar_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();

            try
            {
                if (mar.Text != "PAID" && mar.Text != "NILL")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 3);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
         }

        private void payApr_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();

            try
            {
                if (apr.Text != "PAID" && apr.Text != "NILL")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 4);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
        }

        private void payMay_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (may.Text != "PAID" && may.Text != "NILL")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 5);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
         }

        private void payJune_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (june.Text != "PAID" && june.Text != "NILL")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 6);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
         }

        private void payJuly_Click(object sender, EventArgs e)
        {

            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (july.Text != "PAID" && july.Text != "NILL")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 7);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
        }

        private void payAug_Click(object sender, EventArgs e)
        {

            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (augu.Text != "PAID" && augu.Text != "NILL")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 8);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
        }

        private void paySep_Click(object sender, EventArgs e)
        {

            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (sep.Text != "PAID" && sep.Text != "NILL")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 9);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Paid");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
             
        }

        private void payOct_Click(object sender, EventArgs e)
        {

            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (oct.Text != "PAID" && oct.Text != "NILL")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 10);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
        }

        private void payNov_Click(object sender, EventArgs e)
        {

            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (nov.Text != "PAID" && nov.Text != "NILL")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 11);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
              
        }

        private void payDec_Click(object sender, EventArgs e)
        {

            Home_Admin_Withdraw_Show h2 = new Home_Admin_Withdraw_Show();
            try
            {
                if (dec.Text != "PAID" && dec.Text != "NILL")
                {

                    h2.Show();
                    h2.giveData(index1, index2, 12);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already Paid or Not Subscribed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }     
        }

        private void stNewYearBt_Click(object sender, EventArgs e)
        {
            Home_Admin_Withdraw_New h = new Home_Admin_Withdraw_New();
            h.giveData(index1, index2, year.Text);
            this.Hide();
            h.Show();
        }

        private void year_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            time_lbl.Text = dt.ToString();
        }
               
       }
           
  }


