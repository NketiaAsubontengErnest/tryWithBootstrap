using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using tryWithBootstrap.classes;

namespace tryWithBootstrap
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        config db = new config();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void instect(string ans)
        {
            string Questuion = Request.Params["txtQuestions"];
            int a = db.InsertData("INSERT INTO Quiz (Question, Option1, Option2, Option3,Option4,Answer) VALUES( '" + txtQuestion.Text + "', '" + txtOption1.Text + "', '" + txtOption2.Text + "', '" + txtOption3.Text + "', '" + txtOption4.Text + "' , '" + ans + "')");

            if (a > 0)
            {

                Response.Write("<script> alert ('Question Saved Successfully')</script>");
                cls();
            }
        }

        protected void cls()
        {
            txtQuestion.Text = "";
            txtOption1.Text = "";
            txtOption2.Text = "";
            txtOption3.Text = "";
            txtOption4.Text = "";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            cls();
        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            if (cmbCorrectOption.Text == "Option 1")
            {
                instect(txtOption1.Text);
            }
            else if (cmbCorrectOption.Text == "Option 2")
            {
                instect(txtOption2.Text);
            }
            else if (cmbCorrectOption.Text == "Option 3")
            {
                instect(txtOption3.Text);
            }
            else if (cmbCorrectOption.Text == "Option 4")
            {
                instect(txtOption4.Text);
            }
            else
            {
                Response.Write("<script> alert ('there was a problem')</script>");
            }
        }
    }
}