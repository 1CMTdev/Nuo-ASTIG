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
    public partial class Seller1 : Form
    {
        static string connectionString = @"Server=tcp:dlsudthesis.database.windows.net,1433;Initial Catalog=blazingshop;Persist Security Info=False;User ID=nullobjectadmin;Password=1234!thesis;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection myConn = new SqlConnection(connectionString);
        SqlCommand cmd;
        public Seller1()
        {
            InitializeComponent();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Seller", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1 - direct method
                dataGridView1.DataSource = dtbl;

                //method 2 : DG Columns
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admindashboard().ShowDialog();
        }


        //delist seller
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                cmd = new SqlCommand("update Seller set Allowed='False' where Id=@id", myConn);
                myConn.Open();
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                //cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                myConn.Close();
                ResetForm();
            }
            catch
            {
                MessageBox.Show("Check Input!");
            }
        }

        private void ResetForm()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Seller", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1 - direct method
                dataGridView1.DataSource = dtbl;

                //method 2 : DG Columns
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }
        }

        //approving
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                cmd = new SqlCommand("update Seller set Allowed='True',Avatar=@avatar where Id=@id", myConn);
                myConn.Open();
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@avatar", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                myConn.Close();
                ResetForm();
            }
            catch
            {
                MessageBox.Show("Check Input!");
            }

        }
    }
}
