using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Currency_Converter
{
    /// <summary>
    /// Task 3.1
    /// This is a currency converting Program. Converting Dollars, Rupees, Euros to Pounds.
    /// Author: Shan Ahmed
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUKMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbnDollars_CheckedChanged(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(txtUKMoney.Text) * 1.8;
            lblConverted.Text = amount.ToString() + " Dollars";
        }

        private void rbnEuros_CheckedChanged(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(txtUKMoney.Text) * 1.4;
            lblConverted.Text = amount.ToString() + " Euros";
        }

        private void rbnRupees_CheckedChanged(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(txtUKMoney.Text) * 80;
            lblConverted.Text = amount.ToString() + " Rupees";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Confirmation QuitWindow = new Confirmation();
            QuitWindow.ShowDialog();
        }
    }
}