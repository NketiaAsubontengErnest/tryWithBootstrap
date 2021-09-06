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
    public partial class AdminDashboard : System.Web.UI.MasterPage
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
        string FName;
        string SName;
        string PictureLink;
        string user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblID.Text = Session["userIDs"].ToString();
                user = Session["usertype"].ToString();
                scanDetails();
            }
            
        }
        public void scanDetails()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))

            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Admins where Staff_ID ='" + lblID.Text + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {

                        //StaffID = dr["Staff_ID"].ToString();
                        FName = dr["F_Name"].ToString();
                        SName = dr["S_Name"].ToString();
                        // email = dr["Email"].ToString();
                        PictureLink = dr["Picture_Link"].ToString();


                    }
                }
                //lblAdmin.Text = FName + " " + SName;
                Image1.ImageUrl = "~/ProfilePictures/" + PictureLink;



            }
        }

        protected void btnAddTeacher_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAddTeacher.aspx");
        }

        protected void btnAddStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAddStudnts.aspx");
        }

        protected void btnLists_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminCheckList.aspx");
        }

        protected void btnManage_Click(object sender, EventArgs e)
        {
            Session["userIDs"] = lblID.Text;
            Session["User"] = Session["usertype"].ToString();

            Response.Redirect("~/Manage.aspx");
        }
    }
}