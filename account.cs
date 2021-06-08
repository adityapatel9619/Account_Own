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
        {
            int amt = amount;
            balance += amt;
            MessageBox.Show("Account Opend Successfully");
        }

        // For Withdraw Amount
        public void withdraw(int amount)
        {
            balance -= amount;
            MessageBox.Show("Balance after Withdrawal Successfully: "+balance);
        }

        // For Deposit Amount
        public void deposit(int amount)
        {
            balance += amount;
            MessageBox.Show("Balance After Deposited Amount Successfully: " + balance);
        }

        // For CheckBalance
        public void checkbalance()
        {
            MessageBox.Show("Total Amount: " + balance);
        }
    }
}
