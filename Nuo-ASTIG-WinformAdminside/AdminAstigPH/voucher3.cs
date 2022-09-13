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
    public partial class voucher3 : Form
    {
        static string connectionString = @"Server=tcp:dlsudthesis.database.windows.net,1433;Initial Catalog=blazingshop;Persist Security Info=False;User ID=nullobjectadmin;Password=1234!thesis;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection myConn = new SqlConnection(connectionString);
        SqlCommand cmd;
        public voucher3()
        {
            InitializeComponent();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Voucher", sqlCon);
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




        //GENERATE 1 time use
        private void button2_Click(object sender, EventArgs e)
        {
            string vc="APH"+ new Random().Next(1000, 9999);


            try
            {
                cmd = new SqlCommand("insert into Voucher (ID,Type,Value,Usage) values(@id,@type,@value,'False')", myConn);
                myConn.Open();
                cmd.Parameters.AddWithValue("@id", vc);
                cmd.Parameters.AddWithValue("@type", "Personal Code");
                cmd.Parameters.AddWithValue("@value", textBox1.Text);
                cmd.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("1-Time Voucher Created!");
                textBox2.Text = vc;
                ResetForm();
            }
            catch
            {
                MessageBox.Show("Check Input!");
            }
        }

        //disable
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("update Voucher set Usage='True' where Id=@id", myConn);
                myConn.Open();
                cmd.Parameters.AddWithValue("@id", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show( textBox2.Text+" - Updated Successfully");
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Voucher", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                //method 1 - direct method
                dataGridView1.DataSource = dtbl;

                //method 2 : DG Columns
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
            }

        }


            //universal
            private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                cmd = new SqlCommand("insert into Voucher (ID,Type,Value,Usage) values(@id,@type,@value,'False')", myConn);
                myConn.Open();
                cmd.Parameters.AddWithValue("@id", textBox2.Text);
                cmd.Parameters.AddWithValue("@type", textBox3.Text);
                cmd.Parameters.AddWithValue("@value", textBox1.Text);
                cmd.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("Universal Voucher Created!");
                ResetForm();
            }
            catch
            {
                MessageBox.Show("Check Input!");
            }


        }


        //enable
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("update Voucher set Usage='False' where Id=@id", myConn);
                myConn.Open();
                cmd.Parameters.AddWithValue("@id", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show(textBox2.Text + " - Updated Successfully");
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
