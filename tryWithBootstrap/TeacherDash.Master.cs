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
    public partial class TeacherDash : System.Web.UI.MasterPage
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
        public void scanDetails()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))

            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Teacher where Staff_ID ='" + lblID.Text + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {

                        //StaffID = dr["Staff_ID"].ToString();
                        //FName = dr["F_Name"].ToString();
                        //SName = dr["S_Name"].ToString();
                        //subject = dr["Subject"].ToString();
                        //email = dr["Email"].ToString();
                        PictureLink = dr["Picture_Link"].ToString();

                    }
                }
                //lblName.Text = FName + " " + SName;
                //lblSubject.Text = subject;
                //lblEmail.Text = email;
                Image1.ImageUrl = "~/ProfilePictures/" + PictureLink;



            }
        }

        protected void btnNewContent_Click(object sender, EventArgs e)
        {
            Response.Redirect("TeachersContents.aspx");
        }

        protected void btnSubAssign_Click(object sender, EventArgs e)
        {
            Response.Redirect("TeacherViewStudentUploads.aspx");
        }

        protected void btnSeeResults_Click(object sender, EventArgs e)
        {
            Response.Redirect("TeacherViewResults.aspx"); 
        }

        protected void btnUploaded_Click(object sender, EventArgs e)
        {
            Response.Redirect("TeachersUploaded.aspx");
        }

        protected void btnAddQuiz_Click(object sender, EventArgs e)
        {
            Response.Redirect("TeacherAddQuiz.aspx");
        }

        protected void btnManage_Click(object sender, EventArgs e)
        {
            Session["userIDs"] = lblID.Text;
            Session["User"] = Session["usertype"].ToString();
            Response.Redirect("~/Manage.aspx");
        }
    }
}