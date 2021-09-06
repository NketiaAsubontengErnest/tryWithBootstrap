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
    public partial class WebForm1 : System.Web.UI.Page
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))

            {

                string UserType = null;
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from User_login where Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'  ", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        UserType = dr["User_Type"].ToString();
                    }
                }
                // Passing sessions to the next forms
                Session["userIDs"] = txtUsername.Text;
                Session["usertype"] = UserType;
                if (UserType == "TEACHER")
                {
                    Response.Redirect("TeachersWelcome.aspx");
                }
                
                else if (UserType == "STUDENT")
                {
                    Response.Redirect("StudentViewContents.aspx");
                }
                else if (UserType == "ADMIN")
                {
                    Response.Redirect("AdminWelcomePage.aspx");
                }
                else
                {
                    Response.Write("<script> alert ('Invalid login please!!')</script>");
                }


            }
        }
    }
}