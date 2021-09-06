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
    public partial class WebForm5 : System.Web.UI.Page
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                StudentDataload();
                TeacersDataload();
            }
        }

        protected void StudentDataload()
        {
            DataTable dtbl = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnectionString))

            {
                conn.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select * from Student  ", conn);
                cmd.Fill(dtbl);

                if (dtbl.Rows.Count > 0)
                {
                    StudentGridView.DataSource = dtbl;
                    StudentGridView.DataBind();
                }
                else
                {
                    dtbl.Rows.Add(dtbl.NewRow());
                    StudentGridView.DataSource = dtbl;
                    StudentGridView.DataBind();
                    StudentGridView.Rows[0].Cells.Clear();
                    StudentGridView.Rows[0].Cells.Add(new TableCell());
                    StudentGridView.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
                    StudentGridView.Rows[0].Cells[0].Text = "there are no data in the database";
                    StudentGridView.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;

                }


            }
        }

        protected void TeacersDataload()
        {
            DataTable dtbl = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnectionString))

            {
                conn.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select * from Teacher  ", conn);
                cmd.Fill(dtbl);

                if (dtbl.Rows.Count > 0)
                {
                    TeachersGridView.DataSource = dtbl;
                    TeachersGridView.DataBind();
                }
                else
                {
                    dtbl.Rows.Add(dtbl.NewRow());
                    TeachersGridView.DataSource = dtbl;
                    TeachersGridView.DataBind();
                    TeachersGridView.Rows[0].Cells.Clear();
                    TeachersGridView.Rows[0].Cells.Add(new TableCell());
                    TeachersGridView.Rows[0].Cells[0].ColumnSpan = dtbl.Columns.Count;
                    TeachersGridView.Rows[0].Cells[0].Text = "there are no data in the database";
                    TeachersGridView.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;

                }


            }
        }

        protected void StudentGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            StudentGridView.EditIndex = e.NewEditIndex;
            StudentDataload();
        }

        protected void StudentGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            StudentGridView.EditIndex = -1;
            StudentDataload();
        }


        protected void StudentGridView_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {

            int Id = Convert.ToInt32((TextBox)StudentGridView.Rows[e.RowIndex].Cells[0].Controls[0]);
            string index = ((TextBox)StudentGridView.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string Fname = ((TextBox)StudentGridView.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string Sname = ((TextBox)StudentGridView.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string teacher = ((TextBox)StudentGridView.Rows[e.RowIndex].Cells[5].Controls[0]).Text;


            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Student set Index_No='" + index + "', F_Name='" + Fname + "', S_Name='" + Sname + "', Teacher_Name='" + teacher + "' where ID='" + Id + "' ", conn);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    Response.Write("<script> alert ('records updated')</script>");
                    StudentGridView.EditIndex = -1;
                    StudentDataload();

                }

            }
        }

        protected void StudentGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(StudentGridView.DataKeys[e.RowIndex].Value.ToString());
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string QueryCode = "DELETE FROM Student WHERE ID ='" + Id + "'";
                    SqlCommand sqlCom = new SqlCommand(QueryCode, conn);
                    int x = sqlCom.ExecuteNonQuery();
                    if (x > 0)
                    {
                        Response.Write("<script> alert ('records delated')</script>");
                        StudentGridView.EditIndex = -1;
                        StudentDataload();
                    }

                }
            }
            catch (Exception)
            {
                Response.Write("<script> alert ('there was a problem deleting student')</script>");

            }

        }

        protected void TeachersGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            TeachersGridView.EditIndex = -1;
            TeacersDataload();
        }

        protected void TeachersGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            TeachersGridView.EditIndex = e.NewEditIndex;
            TeacersDataload();
        }

        protected void TeachersGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int Id = Convert.ToInt32(((TextBox)TeachersGridView.Rows[e.RowIndex].Cells[1].Controls[0]).Text);
            string Staffid = ((TextBox)TeachersGridView.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string Fname = ((TextBox)TeachersGridView.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string Sname = ((TextBox)TeachersGridView.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string Subject = ((TextBox)TeachersGridView.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
            string Email = ((TextBox)TeachersGridView.Rows[e.RowIndex].Cells[5].Controls[0]).Text;


            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Teacher set F_Name='" + Fname + "', S_Name='" + Sname + "', Subject='" + Subject + "', Email='" + Email + "' where Staff_ID='" + Staffid + "' ", conn);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    Response.Write("<script> alert ('records updated')</script>");
                    TeachersGridView.EditIndex = -1;
                    TeacersDataload();

                }

            }
        }

        protected void TeachersGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string Staffid = ((TextBox)TeachersGridView.Rows[e.RowIndex + 1].Cells[1].Controls[0]).Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string QueryCode = "DELETE FROM Teacher WHERE Staff_ID ='" + Staffid + "'";
                    SqlCommand sqlCom = new SqlCommand(QueryCode, conn);
                    int x = sqlCom.ExecuteNonQuery();
                    if (x > 0)
                    {
                        Response.Write("<script> alert ('records delated')</script>");
                        TeachersGridView.EditIndex = -1;
                        TeacersDataload();
                    }

                }
            }
            catch (Exception)
            {
                Response.Write("<script> alert ('there was a problem deleting student')</script>");

            }
        }
    }
}