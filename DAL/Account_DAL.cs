using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ENTITY;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
namespace DAL
{
    public class Account_DAL
    {
        static string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=\\psf\Home\Documents\UserDatafile.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;

        public SqlConnection connectToDB()
        {
            con = new SqlConnection(connString);
            con.Open();
            return con;
        }

        public void disconnect()
        {
            con.Close();
        }


        public bool createAccount(ArrayList account)
        {
            /*StreamWriter write = new StreamWriter("C://BankAccountSystemData//Data//Test.txt");
            try
            {
                for (int i = 0; i < account.Count; i++)
                {
                    write.WriteLine(account[i].ToString());
                }
                write.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }*/


            connectToDB();

            string sql_string = "insert into Table(UserID,UserName,Address,PhoneNo,RegFee,StartingYear,StartingMonth) values (" + account[0].ToString() + "," + account[1].ToString() + "," + account[2].ToString() + "," + account[3].ToString() + "," + account[4].ToString() + "," + account[5].ToString() + "," + account[6].ToString() + ")";
            SqlCommand command = new SqlCommand(sql_string);
            
            try
            {
                command.ExecuteNonQuery();
                Console.WriteLine("DBCom");
                disconnect();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;


        }

        public ArrayList readAccount()
        {
            try
            {
                string[] data = File.ReadAllLines("C://BankAccountSystemData//Data//Test.txt");
                ArrayList list = new ArrayList(data);
                return list;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public bool security_Checker(string name, string password)
        {
            if ("r" == name && "r" == password)
            {
                return true;
            }
            else
                return false;
        }
    }
}
