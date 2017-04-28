using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace KursovProektUSP
{
    public partial class showMoviesF : Form
    {
        public showMoviesF()
        {
            InitializeComponent();
        }
        public OracleConnection ConnectToDB() // Establish database connection
        {
            string connectionString = "Data Source=Admin-PC;User Id=USP;Password=usp;";
            OracleConnection conn = new OracleConnection(connectionString);
            return conn;
        }

        public void read() // Load data from database into DataGridView
        {
            try
            {
                using(OracleConnection conn = ConnectToDB())
                using(OracleCommand cmd = new OracleCommand("select * from movies", conn))
                {
                    conn.Open();
                    using(OracleDataReader reader = cmd.ExecuteReader())
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
 
        private void addMovieB_Click(object sender, EventArgs e) //Navigate through Forms
        {
            this.Hide();
            addMoviesF f = new addMoviesF();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void searchMovieB_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchMoviesF f2 = new searchMoviesF();
            f2.Closed += (s, args) => this.Close();
            f2.Show();
        }

        private void showMoviesF_Load(object sender, EventArgs e)
        {
            read(); //Fill DataGridView with data
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
