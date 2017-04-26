using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace KursovProektUSP
{
    public partial  class searchMoviesF : Form
    {
        public searchMoviesF()
        {
            InitializeComponent();
        }

        

        private void searchMLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Enter a valid length.");
                e.Handled = true;
            }     
        }

        
    }
}
