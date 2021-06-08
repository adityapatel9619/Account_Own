using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Own
{
    public partial class Form1 : Form
    {
        account ac = new account();
        public Form1()
        {
            InitializeComponent();
        }

        // Loading Form
        private void Form1_Load_1(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label5.Visible = false;
            textBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ac.open(int.Parse(textBox3.Text));
            textBox3.Text = "";
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            label5.Visible = true;
            textBox4.Visible = true;
            
            label4.Visible = false;
            textBox3.Visible = false;
            button1.Visible = false;
        }

        // For Withdrawl 
        private void button2_Click(object sender, EventArgs e)
        {
            ac.withdraw(int.Parse(textBox4.Text));
            textBox4.Text = "";
        }

        // For Depositing
        private void button3_Click(object sender, EventArgs e)
        {
            ac.deposit(int.Parse(textBox4.Text));
            textBox4.Text = "";
        }

        // For Checking Balance
        private void button4_Click(object sender, EventArgs e)
        {
            ac.checkbalance();
        }
    }
}
