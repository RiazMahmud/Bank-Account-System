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
    public partial class Home_Admin_AccountUpdate_Update : Form
    {
        public Home_Admin_AccountUpdate_Update()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
        public void giveIndex(int i)
        {
            index1 = i;
        }
        private void Update_Click(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());

            try
            {
                int temp = index1;
                if (updateUserName.Text != "" && updateUserAddress.Text != "" && updatePhoneNo.Text != "" && imagePath != null)
                {
                    list[temp + 1] = updateUserName.Text;
                    list[temp + 2] = updateUserAddress.Text;
                    list[temp + 3] = updatePhoneNo.Text;
                    int i;
                    for (i = index1; list[i].ToString() != "*****"; i++)
                    {

                    }
                    int j = i - 1;
                    list[j] = imagePath;
                    account_BO.createAccount(list);
                    Home_Admin_AccountUpdate_Update_Show home_Admin_AccountStatement_Update_Show = new Home_Admin_AccountUpdate_Update_Show();
                    home_Admin_AccountStatement_Update_Show.giveIndex(index1);
                    home_Admin_AccountStatement_Update_Show.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Wrong!!! Enter the information carefully");
            }
            catch (Exception)
            {
                MessageBox.Show("Error !!");
            }
            
        }
   
        private void Home_Admin_AccountUpdate_Update_Load(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());
            int i;
            for(i = index1; list[i].ToString() != "*****"; i++)
            {

            }
            string k = list[i-1].ToString();
            int index = index1;
            int temp = index1;
            userID.Text = list[index].ToString();
            userName.Text = list[index + 1].ToString();           
            address.Text = list[index + 2].ToString();
            phoneNo.Text = list[index + 3].ToString();
            updateUserID.Text = list[index].ToString();
            presentPictureBox.Load(k);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Admin_AccountUpdate h = new Home_Admin_AccountUpdate();
            h.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateUserID_Click(object sender, EventArgs e)
        {

        }
        public string imagePath;
        private void updateUpload_Picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog.Title = "Select Image";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                updatePictureBox.ImageLocation = openFileDialog.FileName;
                imagePath = updatePictureBox.ImageLocation;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void presentPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            time_lbl.Text = dt.ToString();
        }
    }
}
