using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tryWithBootstrap.classes;

namespace tryWithBootstrap
{
    
    public partial class WebForm7 : System.Web.UI.Page
    {
        config db = new config();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int a = db.InsertData("INSERT INTO Content (Title, Content)VALUES('" + txtTitle.Text + "', '" + txtContent.Text + "')");

            if (a > 0)
            {
                Response.Write("<script> alert ('Content Saved uploaded')</script>");

            }
        }

        protected void btnClearPost_Click(object sender, EventArgs e)
        {
            txtContent.Text = "";
            txtTitle.Text = "";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            uploadFiles();
        }

        protected void uploadFiles()
        {
            try
            {
                string folderPath = Server.MapPath("~/Teacher_Uploades/");
                string fileName = Path.GetFileName(FileUpload1.FileName);
                string fileLink = folderPath + Path.GetFileName(FileUpload1.FileName);
                //Label6.Text = fileLink;

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                else
                {
                    //int a = db.InsertData("INSERT INTO Teachers_Updload(file_name, file_Type, file_link) VALUES('" + fileName.ToString() + "', '" + (cmbActivity.Text).ToString()+ "', '" + fileLink.ToString() + "')");
                    FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
                    //if (a > 0)
                    //{

                    Response.Write("<script> alert ('file Saved Successfully')</script>");

                    //}
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            cmbActivity.Text = "";
        }

        protected void btnSave_Click1(object sender, EventArgs e)
        {
            uploadFiles();
        }
    }
}