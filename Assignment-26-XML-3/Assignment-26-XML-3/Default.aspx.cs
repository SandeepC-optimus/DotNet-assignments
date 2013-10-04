//////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the namespace Assignment_26_XML_3 created to Read data from xml file and write it inot database.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 
#endregion

namespace Assignment_26_XML_3
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Calling the Function of Utility Class
            if (Utility.LoadStudentsFromXMLFile(FileUpload1.FileName)) ;
            Response.Write("Insertion in database is Successful");
        }
    }
}