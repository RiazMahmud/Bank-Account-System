using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data.SqlClient;namespace BankAccountSystemUI
{
    class DBClass
    {
        public static SqlConnection CreateConnnection(){
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=\\psf\Home\Documents\UserDatafile.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conn = new SqlConnection(connString);
            Conn.Open();
            return Conn;
        }

    }
}
