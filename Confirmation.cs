using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
