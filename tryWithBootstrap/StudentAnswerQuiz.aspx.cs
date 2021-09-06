using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using tryWithBootstrap.classes;

namespace tryWithBootstrap
{
    public partial class StudentAnswerQuiz : System.Web.UI.Page
    {
        config db = new config();
        private static decimal correctCount = 0;
        private decimal wrongCount = 0;
        private decimal marks = 0;
        string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblID.Text = Session["userIDs"].ToString();
                loadQuestions();
                scanDetails();
            }
        }
        public void loadQuestions()
        {

            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from Quiz";
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
            sqlconn.Close();

        }

        //this method is user to checke the answers from the questions
        public void checkAns()
        {
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb1 = (RadioButton)ri.FindControl("RadOption1");
                Label lbCorrectAns = (Label)ri.FindControl("lblCorrect");
                lbCorrectAns.Visible = true;

                if (rb1.Checked == true)
                {
                    if (rb1.Text.Equals(lbCorrectAns.Text))
                    {
                        correctCount = correctCount + 1;
                        Label userSelectedAns = (Label)ri.FindControl("lblSelectedAns");
                        userSelectedAns.Visible = true;
                        userSelectedAns.Text = "The selected answer is <b>" + rb1.Text.ToString() + "</b> ";
                        userSelectedAns.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        wrongCount = wrongCount + 1;
                        Label wrongAnswer = (Label)ri.FindControl("lblSelectedAns");
                        wrongAnswer.Text = "The selected answer is <b>" + rb1.Text.ToString() + "</b> is wrong!!!";
                        wrongAnswer.ForeColor = System.Drawing.Color.Red;
                    }
                }

            }

            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb2 = (RadioButton)ri.FindControl("RadOption2");
                Label lbCorrectAns = (Label)ri.FindControl("lblCorrect");
                lbCorrectAns.Visible = true;

                if (rb2.Checked == true)
                {
                    if (rb2.Text.Equals(lbCorrectAns.Text))
                    {
                        correctCount = correctCount + 1;
                        Label userSelectedAns = (Label)ri.FindControl("lblSelectedAns");
                        userSelectedAns.Visible = true;
                        userSelectedAns.Text = "The selected answer is <b>" + rb2.Text.ToString() + "</b> ";
                        userSelectedAns.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        wrongCount = wrongCount + 1;
                        Label wrongAnswer = (Label)ri.FindControl("lblSelectedAns");
                        wrongAnswer.Text = "The selected answer is <b>" + rb2.Text.ToString() + "</b> is wrong!!!";
                        wrongAnswer.ForeColor = System.Drawing.Color.Red;
                    }
                }

            }

            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb3 = (RadioButton)ri.FindControl("RadOption3");
                Label lbCorrectAns = (Label)ri.FindControl("lblCorrect");
                lbCorrectAns.Visible = true;

                if (rb3.Checked == true)
                {
                    if (rb3.Text.Equals(lbCorrectAns.Text))
                    {
                        correctCount = correctCount + 1;
                        Label userSelectedAns = (Label)ri.FindControl("lblSelectedAns");
                        userSelectedAns.Visible = true;
                        userSelectedAns.Text = "The selected answer is <b>" + rb3.Text.ToString() + "</b> ";
                        userSelectedAns.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        wrongCount = wrongCount + 1;
                        Label wrongAnswer = (Label)ri.FindControl("lblSelectedAns");
                        wrongAnswer.Text = "The selected answer is <b>" + rb3.Text.ToString() + "</b> is wrong!!!";
                        wrongAnswer.ForeColor = System.Drawing.Color.Red;
                    }
                }

            }

            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb4 = (RadioButton)ri.FindControl("RadOption4");
                Label lbCorrectAns = (Label)ri.FindControl("lblCorrect");
                lbCorrectAns.Visible = true;

                if (rb4.Checked == true)
                {
                    if (rb4.Text.Equals(lbCorrectAns.Text))
                    {
                        correctCount = correctCount + 1;
                        Label userSelectedAns = (Label)ri.FindControl("lblSelectedAns");
                        userSelectedAns.Visible = true;
                        userSelectedAns.Text = "The selected answer is <b>" + rb4.Text.ToString() + "</b> ";
                        userSelectedAns.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        wrongCount = wrongCount + 1;
                        Label wrongAnswer = (Label)ri.FindControl("lblSelectedAns");
                        wrongAnswer.Text = "The selected answer is <b>" + rb4.Text.ToString() + "</b> is wrong!!!";
                        wrongAnswer.Text = "The selected answer is <b>" + rb4.Text.ToString() + "</b> is wrong!!!";
                        wrongAnswer.ForeColor = System.Drawing.Color.Red;

                    }
                }

            }
            marks = (correctCount / (correctCount + wrongCount)) * 100;
            Label1.Text = "Quiz Submited you score" + "   " + marks.ToString() + " " + "%";
            int a = db.InsertData("INSERT INTO Answered_Student (Student_Index, Marks, Submited_Time)VALUES('" + Session["userIDs"].ToString() + "', '" + marks + "', '" + DateTime.Now + "')");

            if (a > 0)
            {
                Repeater1.Visible = false;
                lblTimer.Visible = false;
                btnSubmit.Visible = false;
                //Response.Write("<script> alert ('Quiz Submited')</script>");
                //Response.Redirect("studentContentShow.aspx");

            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            checkAns();
        }

        public void scanDetails()
        {
            string PictureLink = null;
            using (SqlConnection conn = new SqlConnection(mainconn))

            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Student where Index_No ='" + lblID.Text + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        //fname = dr["F_Name"].ToString();
                        //sname = dr["S_Name"].ToString();
                        //teacher = dr["Teacher_Name"].ToString();
                        PictureLink = dr["Picture_Link"].ToString();

                    }
                }
                //lblName.Text = fname + " " + sname;
                //lblTeacher.Text = teacher;
                //lblEmail.Text = email;
                Image1.ImageUrl = "~/ProfilePictures/" + PictureLink;



            }

        }
    }
}