using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tryWithBootstrap
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStartQuiz_Click(object sender, EventArgs e)
        {
            Session["userIDs"] = Session["userIDs"].ToString();
            Response.Redirect("StudentAnswerQuiz.aspx");
        }
    }
}