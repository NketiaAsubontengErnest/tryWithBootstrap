using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tryWithBootstrap
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = Server.MapPath("~/Student_Uploads/");
                string fileName = Path.GetFileName(FileUpload1.FileName);
                string fileLink = folderPath + Path.GetFileName(FileUpload1.FileName);
                //Label6.Text = fileLink;

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                else
                {
                    FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
                    Response.Write("<script> alert ('file Saved Successfully')</script>");
                    // +Path.GetExtension(@FileUpload1)
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}