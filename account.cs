using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Own
{
    class account
    {
        int balance = 0;

        // For opening Account
        public void open(int amount)
        {   // 1000
            int amt = amount;
            balance += amt;
            MessageBox.Show("Account Opend Successfully");
        }

        // For Withdraw Amount
        public void withdraw(int amount)
        {   //200  
            // 1000 = 1000 - 200 = 800
            balance -= amount;
            MessageBox.Show("Balance after Withdrawal Successfully: "+balance); // 800
        }

        // For Deposit Amount
        public void deposit(int amount)
        {   // 1200
            // 800 + 1200 = 2000
            balance += amount;
            MessageBox.Show("Balance After Deposited Amount Successfully: " + balance); // 2000
        }

        // For CheckBalance
        public void checkbalance()
        {
            MessageBox.Show("Total Amount: " + balance); // 2000
        }
    }
}
