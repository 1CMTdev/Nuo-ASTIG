using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AdminAstigPH
{
    public partial class admindashboard : Form
    {
        public admindashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://dashboard.tawk.to/#/dashboard/61ee581e9bd1f31184d8edcd");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://portal.azure.com/#@08195d68-0190-47b8-8344-b172f23ce9c5/resource/subscriptions/cb8b993a-4b0e-4799-b586-a2bb0c4331a3/resourceGroups/NuoThesis/providers/Microsoft.Sql/servers/dlsudthesis/databases/blazingshop/overview");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Seller1().ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new product2().ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new voucher3().ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new vietrans().ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new viewusers().ShowDialog();
        }
    }
}
