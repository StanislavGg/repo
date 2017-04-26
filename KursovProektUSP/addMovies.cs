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
    public partial class addMoviesF : Form
    {
        public addMoviesF()
        {
            InitializeComponent();
        }

        private void SetButton()
        {
            addToDB.Enabled = (titleTB.Text != "" && genreCB.SelectedIndex != -1 && yearTB.Text != "" && lengthTB.Text != "" && showTBValue.Text != "Rate" && showTBValue.Text != "0");
        }


        private void rateTB_Scroll(object sender, EventArgs e)
        {
            showTBValue.Text = rateTB.Value.ToString();
        }

        private void addToDB_Click(object sender, EventArgs e)
        {
            string hasOscar="";
            string connectionString = "Data Source=Admin-PC;User Id=USP;Password=usp;";
            string querryString = ("INSERT INTO USP.Movies VALUES (auto_sequence.nextval, :mTitle, :mGenre, :mYear, :mLength, :mRate, :mOscar)");

            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = querryString;
            try
            {

              
                command.Parameters.Add(new OracleParameter("mTitle", OracleDbType.Varchar2, titleTB.Text, ParameterDirection.Input));
                command.Parameters.Add(new OracleParameter("mGenre", OracleDbType.Varchar2, genreCB.SelectedItem.ToString(), ParameterDirection.Input));
                command.Parameters.Add(new OracleParameter("mYear", OracleDbType.Int64, Convert.ToInt64(yearTB.Text), ParameterDirection.Input));
                command.Parameters.Add(new OracleParameter("mLength", OracleDbType.Int64, Convert.ToInt64(lengthTB.Text), ParameterDirection.Input));
                command.Parameters.Add(new OracleParameter("mRate", OracleDbType.Int64, Convert.ToInt64(showTBValue.Text), ParameterDirection.Input));
                 if (oscar.Checked == true)
                hasOscar = "Yes";
                 else
                hasOscar = "No";
                command.Parameters.Add(new OracleParameter("mOscar", OracleDbType.Varchar2,hasOscar, ParameterDirection.Input));

                command.ExecuteNonQuery();

                MessageBox.Show("Movie has been added");
                conn.Close();
                titleTB.Text = "";
                genreCB.SelectedIndex = -1;
                yearTB.Text = "";
                lengthTB.Text = "";
                showTBValue.Text = "";
                rateTB.Value = 0;
            }
            catch (OracleException e1)
            {
                MessageBox.Show("Error: " + e1.Message);
            }
            catch (ArgumentException e2)
            {
                MessageBox.Show("Error: " + e2.Message);
            }
        }

        private void yearTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9'|| e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Enter a valid year.");
                e.Handled = true;
            }     
        }

        private void lengthTB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void titleTB_TextChanged(object sender, EventArgs e)
        {
            SetButton();
           
        }

        private void genreCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void yearTB_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void lengthTB_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

       

        private void showTBValue_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            showMoviesF f1 = new showMoviesF();
            f1.Closed += (s, args) => this.Close();
            f1.Show();
        }

       
    }
}
