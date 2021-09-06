
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Web.UI.WebControls;
using System.Configuration;

namespace tryWithBootstrap.classes
{
    public class config
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
        public SqlConnection connection = null;
        public SqlCommand cmd = null;

        DataSet ds;
        DataTable dt;

        public string Table = "user_login";
        public string ConnectionType = "";

        string RecordSource = "";

        ListView tempdata;

        // function to connect to the database
        public config()
        {
            try
            {

                connection = new SqlConnection(ConnectionString);

            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        // Function to execute select statements

        public int InsertData(string sql_command)
        {
            int num = 0;
            int i = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionString))

            {

                conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql_command, conn);
                try
                {
                    i = cmd.ExecuteNonQuery();
                }
                catch (Exception )
                {
                    //MessageBox.Show(ex.Message);
                }
                if (i > 0)
                {
                    num = 1;
                }
                conn.Close();
            }
            return num;
        }
        public void ExecuteSql(string Sql_command)
        {

            nowquiee(Sql_command);

        }

        // creates connection to MySQL before execution
        public void nowquiee(string sql_comm)
        {
            try
            {
                SqlConnection cs = new SqlConnection(ConnectionString);
                cs.Open();
                SqlCommand myc = new SqlCommand(sql_comm, cs);
                myc.ExecuteNonQuery();
                cs.Close();


            }
            catch (Exception )
            {

                //MessageBox.Show(err.Message);
            }
        }

        // function to execute delete , insert and update
        public void Execute(string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;
            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();

                //======================if sql contains select==========================================
                SqlDataAdapter da2 = new SqlDataAdapter(RecordSource, connection);

                DataSet tempds = new DataSet();
                da2.Fill(tempds, ConnectionType);
                da2.Fill(tempds);

                //======================================================================================


            }
            catch (Exception ) {
               // MessageBox.Show(err.Message); 
            }
        }

        // function to bring selected results based on column name and row index
        public string Results(int ROW, string COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
            catch (Exception) { 
           
               // MessageBox.Show(err.Message);
                return "";

            }
        }

        // function to bring selected results based on column index and row index
        public string Results(int ROW, int COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
            catch (Exception )
            {
               // MessageBox.Show(err.Message);
                return dt.Rows[ROW][COLUMN_NAME].ToString();

            }
        }

        // Execute select statement
        public void ExecuteSelect(string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;

            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();
                SqlDataAdapter da = new SqlDataAdapter(RecordSource, connection);
                ds = new DataSet();
                da.Fill(ds, ConnectionType);
                da.Fill(dt);
                tempdata = new ListView();
            }
            catch (Exception )
            {
               // MessageBox.Show(err.Message);
            }


        }

        // count Number of rows after selecy
        public int Count()
        {
            return dt.Rows.Count;
        }




    }
}