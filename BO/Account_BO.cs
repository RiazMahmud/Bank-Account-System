using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;
using System.Collections;
namespace BO
{
    public class Account_BO
    {
        
        Account_DAL account_DAL = new Account_DAL();
        public bool createAccount(ArrayList account)
        {
            
            return account_DAL.createAccount(account);
        }

        public ArrayList readAccount()
        {
            return account_DAL.readAccount();
        }
        public double makeDeposit(double previousBalance,double givenBalance)
        {
            double presentBalance;
            presentBalance = previousBalance + givenBalance;
            return presentBalance;
        }
        public double makeWithdraw(double previousBalance, double givenBalance)
        {
            double presentBalance;
            presentBalance = previousBalance - givenBalance;
            if (presentBalance >= 500)
            {
                return presentBalance;
            }
            else
                return previousBalance;
            
        }
        public bool security_Checker(string name, string password)
        {
            return account_DAL.security_Checker(name, password);
        }
    }
}
