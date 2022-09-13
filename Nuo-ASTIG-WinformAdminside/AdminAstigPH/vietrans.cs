using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdminAstigPH
{
    public partial class vietrans : Form
    {
        int cod, paypal;
        static string connectionString = @"Server=tcp:dlsudthesis.database.windows.net,1433;Initial Catalog=blazingshop;Persist Security Info=False;User ID=nullobjectadmin;Password=1234!thesis;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection myConn = new SqlConnection(connectionString);
        SqlCommand cmd;
        public vietrans()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
        }

        //back
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admindashboard().ShowDialog();

        }

        //load
        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Transchunk", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1 - direct method
                dataGridView1.DataSource = dtbl;

                //method 2 : DG Columns
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
                sqlCon.Close();


              
            }

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT SUM (OverallTotal) FROM Transchunk";
            connection.Open();
            var obj = cmd.ExecuteScalar();
            decimal result = obj != null ? (decimal)obj : 0;
            connection.Close();
            label2.Text = label2.Text + " " + result;
            commish();
        }

        public void commish()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT SUM (WithoutShipping) FROM Transchunk";
            connection.Open();
            var obj = cmd.ExecuteScalar();
            decimal result = obj != null ? (decimal)obj : 0;
            connection.Close();
            label1.Text = label1.Text + " " + result;
            counter();

        }


        public void counter()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT (Mode) FROM Transchunk WHERE Mode='Paypal' ";
            connection.Open();
            var obj = cmd.ExecuteScalar();
            paypal = obj != null ? (int)obj : 0;
            connection.Close();
            ey();
        }
        public void ey()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT (Mode) FROM Transchunk WHERE Mode='COD' ";
            connection.Open();
            var obj = cmd.ExecuteScalar();
            cod = obj != null ? (int)obj : 0;
            connection.Close();
            BindData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void BindData()
        {
            List<int> yValues = new List<int>(new int[] { cod, paypal});
            List<string> xValues = new List<string>(new string[] { "COD", "Paypal"});
            chart1.Series[0].Points.DataBindXY(xValues, yValues);
        }


    }
}
