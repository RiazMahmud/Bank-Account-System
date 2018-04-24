using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ENTITY;
using BO;
using System.Collections;
using System.IO;
namespace BankAccountSystemUI
{
    public partial class Home_Admin_CreateAccount : Form
    {
       

        public Home_Admin_CreateAccount()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Home_Admin_CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin home_Admin = new Home_Admin();
            home_Admin.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void Create_Click(object sender, EventArgs e)
        {
            Account_BO account_Bo = new Account_BO();
            Account_ENTITY account_Entity = new Account_ENTITY();
            
            ArrayList listAccount = new ArrayList(account_Bo.readAccount());
            try
            {
                if (userName.Text != "" && userID.Text != "" && address.Text != "" && phoneNo.Text != "" && this.dateTimePicker1.Text != null && regFee != null && imagePath != null)
                {
                    if (Convert.ToDouble(regFee.Text) == 120)
                    {

                        int flag = 0;
                        for (int i = 0; i < listAccount.Count; i++)
                        {

                            if (listAccount[i].ToString() == userID.Text)
                            {
                                MessageBox.Show("Wrong!!! This User ID is already in used");
                                flag = 1;
                                break;
                            }
                        }
                        account_Entity.identity = "*****";
                        account_Entity.userID = userID.Text;
                        account_Entity.userName = userName.Text;
                        account_Entity.address = address.Text;
                        account_Entity.phoneNo = phoneNo.Text;
                        account_Entity.regFee = Convert.ToInt32(regFee.Text);
                        account_Entity.date = this.dateTimePicker1.Text;


                        if (flag == 0)
                        {
                           
                            listAccount.Add(account_Entity.userID);
                            listAccount.Add(account_Entity.userName);
                            listAccount.Add(account_Entity.address);
                            listAccount.Add(account_Entity.phoneNo);
                            listAccount.Add(account_Entity.regFee);
                            listAccount.Add(account_Entity.date);
                            listAccount.Add(imagePath);
                            listAccount.Add(account_Entity.identity);
                            
                            

                            account_Bo.createAccount(listAccount);
                            MessageBox.Show("The Account create successful");
                            this.Hide();
                            Home_Admin home_admin = new Home_Admin();
                            home_admin.Show();
                        }

                        userID.Clear();
                        userName.Clear();
                        address.Clear();
                        phoneNo.Clear();
                        regFee.ResetText();

                    }
                    else
                    {
                        MessageBox.Show("Wrong!! You have to must deposit at least 120TK");
                    }
                }
                else
                    MessageBox.Show("Wrong!!! Enter the information fully");

               
            }
            catch (Exception)
            {
               
                MessageBox.Show("Error!!! Please Retry");
            }
        }

        public string imagePath;
        private void Upload_Picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog.Title = "Select Image";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFileDialog.FileName;
                imagePath = pictureBox.ImageLocation;
            }
        }

        private void Upload_Sign_Click(object sender, EventArgs e)
        {
        }

        private void signBox_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            time_lbl.Text = dt.ToString();
        }

       
    }
}
