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
using System.IO;
namespace BankAccountSystemUI
{
   
    public partial class Home_Admin_AccountStatement_Show : Form
    {
        public int index;
        public Home_Admin_AccountStatement_Show()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountStatement home_Admin_Accountstatement = new Home_Admin_AccountStatement();
            home_Admin_Accountstatement.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin home_Admin = new Home_Admin();
            home_Admin.Show();
        }
        int index1;
        int index2;
        public void giveIndex(int i)
        {
            index1 = i;
        }
        public void giveYear(int i)
        {
            index2 = i;
        }
        public void Home_Admin_AccountStatement_Show_Load(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());
            DataTable dt = new DataTable();
           
           
            try
            {
                int j;
                for (j = index1; list[j].ToString() != "*****"; j++)
                {

                }
                string k = list[j - 1].ToString();
                int index = index1;
                int temp = index1;
                userID.Text = list[index].ToString();
                userName.Text = list[index + 1].ToString();
                address.Text = list[index + 2].ToString();
                phoneNo.Text = list[index + 3].ToString();
                presentPictureBox.Load(k);

                userName.Text = list[index1 + 1].ToString();


                dt.Columns.Add("Year");
                dt.Columns.Add("Jan");
                dt.Columns.Add("Feb");
                dt.Columns.Add("Mar");
                dt.Columns.Add("Apr");
                dt.Columns.Add("May");
                dt.Columns.Add("June");
                dt.Columns.Add("July");
                dt.Columns.Add("Aug");
                dt.Columns.Add("Sep");
                dt.Columns.Add("Oct");
                dt.Columns.Add("Nov");
                dt.Columns.Add("Dec");

                dt.Rows.Add("DUE", "DUE", "DUE", "DUE", "DUE", "DUE", "DUE", "DUE", "DUE", "DUE", "DUE", "DUE","DUE");
               
               
                if (index2 - index1 == 5)
                {
                    if (list[index2 + 1].ToString() == "February")
                    {
                        dt.Rows.Add("PAID");
                    }

                    else if (list[index2 + 1].ToString() == "February")
                    {
                        dt.Rows.Add("NILL","PAID");
                    }
                    else if (list[index2 + 1].ToString() == "March")
                    {
                        dt.Rows.Add("NILL", "NILL","PAID");
                    }
                    else if (list[index2 + 1].ToString() == "April")
                    {
                        dt.Rows.Add("NILL", "NILL","NILL","PAID");
                    }
                    else if (list[index2 + 1].ToString() == "May")
                    {
                        dt.Rows.Add("NILL", "NILL","NILL","NILL","PAID");
                    }
                    else if (list[index2 + 1].ToString() == "June")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL","NILL", "PAID");
                    }
                    else if (list[index2 + 1].ToString() == "July")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL", "NILL","NILL","PAID");
                    }
                    else if (list[index2 + 1].ToString() == "August")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL", "NILL","NILL","NILL","PAID");
                    }
                    else if (list[index2 + 1].ToString() == "September")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL","NILL", "PAID");
                    }
                    else if (list[index2 + 1].ToString() == "October")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL","NILL", "PAID");
                    }
                    else if (list[index2 + 1].ToString() == "November")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL","NILL", "PAID");
                    }
                    else if (list[index2 + 1].ToString() == "December")
                    {
                        dt.Rows.Add("NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL", "NILL","NILL","NILL", "PAID");
                    }
                }
                /*for (int i = index2 + 1; list[i].ToString() != "*****"; i++)
                {
                    if (list[i].ToString() == "January" || list[i].ToString() == "February" || list[i].ToString() == "March" || list[i].ToString() == "April" || list[i].ToString() == "May" || list[i].ToString() == "June" || list[i].ToString() == "July" || list[i].ToString() == "August" || list[i].ToString() == "September" || list[i].ToString() == "October" || list[i].ToString() == "November" || list[i].ToString() == "December")
                    {
                        if (list[i].ToString() == "January")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "February")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "March")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "April")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "May")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "June")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "July")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "August")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "September")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "October")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "November")
                        {
                            lt.SubItems.Add("PAID");
                        }
                        if (list[i].ToString() == "December")
                        {
                            lt.SubItems.Add("PAID");
                        }
                    }
                    else
                    {
                        break;
                    }
                

                }*/
                userData.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Error !!!");
            }
            
        }
        private void ShowAccountNo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void signBox_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
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

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountWithdraw home_Admin_AccountWithdraw = new Home_Admin_AccountWithdraw();
            home_Admin_AccountWithdraw.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void year_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountStatement h = new Home_Admin_AccountStatement();
            h.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            time_lbl.Text = dt.ToString();
        }
    }
}
