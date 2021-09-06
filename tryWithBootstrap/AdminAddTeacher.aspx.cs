using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tryWithBootstrap.classes;

namespace tryWithBootstrap
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private string occupation = "TEACHER";
        config db = new config();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtStaffID.Text == "")
            {

            }
            else
            {
                if (txtDefaultPassword.Text.Equals(txtConfirmPass.Text))
                {
                    int a = db.InsertData("INSERT INTO Teacher(Staff_ID, F_Name, S_Name, Picture_link, Subject, Email) VALUES('" + txtStaffID.Text + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', NULL, '" + txtSubject.Text + "', '" + txtEmail.Text + "')");

                    if (a > 0)
                    {

                        int i = db.InsertData("INSERT INTO User_login (Username, Password, User_Type) VALUES('" + txtStaffID.Text + "','" + txtConfirmPass.Text + "', '" + occupation + "')");
                        if (i > 0)
                        {
                            Response.Write("<script> alert ('Data Saved Successfully')</script>");
                            clr();
                        }

                        //INSERT INTO User_login (Username, Password, User_Type) VALUES( Username,  Password, User_Type)


                    }
                }
            }
        }
       
        protected void clr()
        {
            txtEmail.Text = "";
            txtConfirmPass.Text = "";
            txtDefaultPassword.Text = "";
            txtFirstName.Text = "";
            txtStaffID.Text = "";
            txtSubject.Text = "";
            txtLastName.Text = "";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            clr();
        }
    }
}