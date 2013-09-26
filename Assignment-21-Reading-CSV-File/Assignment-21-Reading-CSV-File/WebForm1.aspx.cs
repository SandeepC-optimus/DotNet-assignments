#region NameSpace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using UtilityFunc;
using StudentDetails; 
#endregion

namespace Assignment_21_Reading_CSV_File
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            // Initially the Upload status is blank
            Label1.Text="Upload Status:    ";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //catch Exceptions occuring in file upload
            try
            {
                // Show the Upload status
                Label1.Text = "Upload status: File uploaded!";
            }
            catch(Exception ex)
            {
                Label1.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Uploading the data of csv file to databse
            Utility ut = new Utility();
            List<Student> l1= new List<Student>();
            string x = FileUpload1.FileName;
            l1=ut.LoadFromCSV(x);
            ut.InsertStudent(l1);
        }
    }
}
