using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using System.Collections;
namespace BankAccountSystemUI
{
    public partial class Home_Admin_Withdraw_New : Form
    {
        public Home_Admin_Withdraw_New()
        {
            InitializeComponent();
        }

        private void NoADD_Click(object sender, EventArgs e)
        {
           
        }
        int index1 = 0;
        int index2 = 0;
        string y = null;
        public void giveData(int i, int j, string k)
        {
            index1 = i;
            index2 = j;
            y = k;

        }
        private void yesADD_Click(object sender, EventArgs e)
        {

        }

        private void yesADD_Click_1(object sender, EventArgs e)
        {
            string x;
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());
            ArrayList savelist = new ArrayList();
            int y1 = 0;
            y1 = Convert.ToInt32(y);
            y1 += 1;
            x = Convert.ToString(y1);
            int i;
            for (i = index1; list[i].ToString() != "*****"; i++)
            {
                if (list[i].ToString() == x)
                {
                    y1++;
                    x = Convert.ToString(y1);
                }
            }
            int j2 = i - 2;
            int j1 = i -1 ;

            for (int k = 0; k <= j2; k++)
            {
                savelist.Add(list[k]);
            }
            savelist.Add(x);
            int j = 0;
            for (j = j1; j < list.Count; j++)
            {
                savelist.Add(list[j]);
            }
            account_BO.createAccount(savelist);
            this.Hide();
            MessageBox.Show("Year " + x + " Added Succssfully, Please Re-enter ID & This Year");
            Home_Admin_AccountWithdraw h = new Home_Admin_AccountWithdraw();
            h.Show();
        }

        private void NoADD_Click_1(object sender, EventArgs e)
        {
            
            this.Hide();
            Home_Admin_AccountWithdraw_Withdraw h = new Home_Admin_AccountWithdraw_Withdraw();
            h.Show();
        }
    }
}
