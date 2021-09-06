using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tryWithBootstrap
{
    public partial class StudentDashboard : System.Web.UI.MasterPage
    {
        string fname;
        string sname;
        string teacher;
        string User;
        string PictureLink;
        string ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblID.Text = Session["userIDs"].ToString();
                User = Session["usertype"].ToString();
                scanDetails();
            }

        }

        protected void btnSubAssign_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentsUpload.aspx");
        }

        protected void btnSeeResults_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentViewQuiz.aspx");
        }

        public void scanDetails()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))

            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Student where Index_No ='" + lblID.Text + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        fname = dr["F_Name"].ToString();
                        sname = dr["S_Name"].ToString();
                        teacher = dr["Teacher_Name"].ToString();
                        PictureLink = dr["Picture_Link"].ToString();

                    }
                }
                //lblName.Text = fname + " " + sname;
                //lblTeacher.Text = teacher;
                //lblEmail.Text = email;
                Image1.ImageUrl = "~/ProfilePictures/" + PictureLink;



            }
        }

        protected void btnManage_Click(object sender, EventArgs e)
        {
            Session["userIDs"] = lblID.Text;
            Session["User"] = Session["usertype"].ToString();
            Response.Redirect("~/Manage.aspx");
        }
    }
}