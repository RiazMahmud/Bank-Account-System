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
    public partial class Document : Form
    {
        public Document()
        {
            InitializeComponent();
        }

        string y = null;
        string m = null;
        public void giveDocData(string year, string month)
        {
            y = year;
            m = month;
        }

        private void Document_Load(object sender, EventArgs e)
        {
            Account_BO account_BO = new Account_BO();
            ArrayList list = new ArrayList(account_BO.readAccount());
            int user = 0;
            int paid = 0;
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ToString() == y)
                    {

                        if (checker(list[i + 1].ToString(), m))
                        {
                            user++;
                            for (int j = i + 1; list[j].ToString() != "*****"; j++)
                            {
                                if (list[j].ToString() == "January" || list[j].ToString() == "February" || list[j].ToString() == "March" || list[j].ToString() == "April" || list[j].ToString() == "May" || list[j].ToString() == "June" || list[j].ToString() == "July" || list[j].ToString() == "August" || list[j].ToString() == "September" || list[j].ToString() == "October" || list[j].ToString() == "November" || list[j].ToString() == "December")
                                {
                                    if (list[j].ToString() == m)
                                    {
                                        paid++;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                year.Text = y;
                month.Text = m;
                totalUser.Text = user.ToString();
                int n = user * 120;
                totalBill.Text = n.ToString();
                int n1 = paid * 120;
                totalPaid.Text = n1.ToString();
                int n2 = n - n1;
                totalDue.Text = n2.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }
        }
        private bool checker(string m1, string m2)
        {
            int v1 = 0, v2 = 0;

            v1 = Month1(m1);
            v2 = month2(m2);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            if (v1 <= v2)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        private int Month1(string m1)
        {
            int v1 = 0;
            if (m1 == "January")
            {
                v1 = 1;
            }
            else if (m1 == "February")
            {
                v1 = 2;
            }
            else if (m1 == "March")
            {
                v1 = 3;
            }
            else if (m1 == "April")
            {
                v1 = 4;
            }
            else if (m1 == "May")
            {
                v1 = 5;
            }
            else if (m1 == "June")
            {
                v1 = 6;
            }
            else if (m1 == "July")
            {
                v1 = 7;
            }
            else if (m1 == "August")
            {
                v1 = 8;
            }
            else if (m1 == "September")
            {
                v1 = 9;
            }
            else if (m1 == "October")
            {
                v1 = 10;
            }
            else if (m1 == "November")
            {
                v1 = 11;
            }
            else if (m1 == "December")
            {
                v1 = 12;
            }

            return v1;
        }
        private int month2(string m2)
        {
            int v2 = 0;
            if (m2 == "January")
            {
                v2 = 1;
            }
            else if (m2 == "February")
            {
                v2 = 2;
            }
            else if (m2 == "March")
            {
                v2 = 3;
            }
            else if (m2 == "April")
            {
                v2 = 4;
            }
            else if (m2 == "May")
            {
                v2 = 5;
            }
            else if (m2 == "June")
            {
                v2 = 6;
            }
            else if (m2 == "July")
            {
                v2 = 7;
            }
            else if (m2 == "August")
            {
                v2 = 8;
            }
            else if (m2 == "September")
            {
                v2 = 9;
            }
            else if (m2 == "October")
            {
                v2 = 10;
            }
            else if (m2 == "November")
            {
                v2 = 11;
            }
            else if (m2 == "December")
            {
                v2 = 12;
            }
            return v2;
        }

    }
}