using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace AdminAstigPH
{
    class Datahelper
    {
        static string myConStr = @"server=localhost\\sqlexpress;database=blazingshop;trusted_connection=true";
        SqlConnection myConn = new SqlConnection(myConStr);

        public DataTable Viewtra()
        {
            SqlDataAdapter da = new SqlDataAdapter("Viewtra", myConn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
            //dataGrid1.ItemsSource = ds.DefaultView;
            //dataGrid1.AutoGenerateColumns = true;
            //dataGrid1.CanUserAddRows = false;
        }




    }
}
