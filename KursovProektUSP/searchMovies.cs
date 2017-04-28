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

        

        private void searchMLength_KeyPress(object sender, KeyPressEventArgs e) // Only number validation for Length
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

        public OracleConnection ConnectToDB() 
        {
            string connectionString = "Data Source=Admin-PC;User Id=USP;Password=usp;";
            OracleConnection conn = new OracleConnection(connectionString);
            return conn;
        }
        public void search() //Search in database
        {
            string comm="";
            string genre;
            if (actionCB.Checked == true)
            {
                genre = actionCB.Text;
            }
            else
                if (animationCB.Checked == true)
                {
                    genre = animationCB.Text;
                }
                else
                    if (comedyCB.Checked == true)
                    {
                        genre = comedyCB.Text;
                    }
                    else
                        if (dramaCB.Checked == true)
                        {
                            genre = dramaCB.Text;
                        }
                        else
                            if (thrillerCB.Checked == true)
                            {
                                genre = thrillerCB.Text;
                            }
                            else
                                if (scifiCB.Checked == true)
                                {
                                    genre = scifiCB.Text;
                                }
                                else
                                    genre = "";
            if(searchMTitle.Text!="" && searchMLength.Text!="" && genre!="")
            {
                comm = "SELECT * from Movies WHERE MTitle = '" + searchMTitle.Text + "'AND MLength='" + Convert.ToInt64(searchMLength.Text) + "'AND MGenre ='"+ genre+ "'";
            }
            else
                if (searchMTitle.Text == "" && searchMLength.Text != "" && genre != "")
                {
                    comm = "SELECT * from Movies WHERE MLength='" + Convert.ToInt64(searchMLength.Text) + "'AND MGenre ='" + genre + "'";
                }
                else
                    if (searchMTitle.Text != "" && searchMLength.Text == "" && genre != "")
                    {
                        comm = "SELECT * from Movies WHERE MTitle = '" + searchMTitle.Text + "'AND MGenre ='" + genre + "'";

                    }
                    else
                        if(searchMTitle.Text != "" && searchMLength.Text != "" && genre == "")
                        {
                            comm = "SELECT * from Movies WHERE MTitle = '" + searchMTitle.Text + "'AND MLength='" + Convert.ToInt64(searchMLength.Text) + "'";
                        }
                    else
                        if (searchMTitle.Text != "" && searchMLength.Text == "" && genre == "")
                        {
                            comm = "SELECT * from Movies WHERE MTitle = '" + searchMTitle.Text + "'";
                        }
                        else
                            if (searchMTitle.Text == "" && searchMLength.Text != "" && genre == "")
                            {
                                comm = "SELECT * from Movies WHERE MLength = '" + searchMLength.Text + "'";
                            }
                            else if (searchMTitle.Text == "" && searchMLength.Text == "" && genre != "")
                            {
                                comm = "SELECT * from Movies WHERE MGenre = '" + genre + "'";
                            }
                            
            

            try
            {
                
                using (OracleConnection conn = ConnectToDB())
                using (OracleCommand cmd = new OracleCommand(comm, conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            search(); // Fill DataGridView with results from the search
        }

       

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addMoviesF f2 = new addMoviesF();
            f2.Closed += (s, args) => this.Close();
            f2.Show();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            showMoviesF f1 = new showMoviesF();
            f1.Closed += (s, args) => this.Close();
            f1.Show();
        }

        
    }
}
