using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace tryWithBootstrap
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        
        string ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentDataload();
        }
        protected void StudentDataload()
        {
            DataTable dtbl = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnectionString))

            {
                conn.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select * from Answered_Student  ", conn);
                cmd.Fill(dtbl);

                if (dtbl.Rows.Count > 0)
                {
                    MarksGridView.DataSource = dtbl;
                    MarksGridView.DataBind();
                }
                else
                {
                    dtbl.Rows.Add(dtbl.NewRow());
                    MarksGridView.DataSource = dtbl;
                    MarksGridView.DataBind();
                    MarksGridView.Rows[0].Cells.Clear();
                    MarksGridView.Rows[0].Cells.Add(new TableCell());
                    MarksGridView.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
                    MarksGridView.Rows[0].Cells[0].Text = "there are no data in the database";
                    MarksGridView.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;

                }


            }
        }
    }
}