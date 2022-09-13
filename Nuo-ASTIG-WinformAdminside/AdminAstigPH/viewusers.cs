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

    public partial class viewusers : Form
    {
        static string connectionString = @"Server=tcp:dlsudthesis.database.windows.net,1433;Initial Catalog=blazingshop;Persist Security Info=False;User ID=nullobjectadmin;Password=1234!thesis;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection myConn = new SqlConnection(connectionString);
        int pwork, pserv, usell, ubuy;
        public viewusers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admindashboard().ShowDialog();
        }

        //load data
        private void button6_Click(object sender, EventArgs e)
        {
            uc();
            us();
            aw();
            aserv();
            BindData();
            BindData2();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
        }


        public void uc()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT (Id) FROM Customer";
            connection.Open();
            var obj = cmd.ExecuteScalar();
            ubuy = obj != null ? (int)obj : 0;
            connection.Close();

        }

        public void us()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT (Id) FROM Seller";
            connection.Open();
            var obj = cmd.ExecuteScalar();
            usell = obj != null ? (int)obj : 0;
            connection.Close();

        }

        public void aw()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT (CategoryID) FROM Products WHERE CategoryID=1";
            connection.Open();
            var obj = cmd.ExecuteScalar();
            pwork = obj != null ? (int)obj : 0;
            connection.Close();

        }
        public void aserv()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT (CategoryID) FROM Products WHERE CategoryID=2";
            connection.Open();
            var obj = cmd.ExecuteScalar();
            pserv = obj != null ? (int)obj : 0;
            connection.Close();

        }






        public void BindData()
        {
            List<int> yValues = new List<int>(new int[] { usell, ubuy });
            List<string> xValues = new List<string>(new string[] { "SELLERS", "CONSUMERS" });
            chart1.Series[0].Points.DataBindXY(xValues, yValues);
        }
        public void BindData2()
        {
            List<int> yValues = new List<int>(new int[] { pwork, pserv });
            List<string> xValues = new List<string>(new string[] { "ARTWORKS", "ARTSERVICE" });
            chart2.Series[0].Points.DataBindXY(xValues, yValues);
        }
    }
}
