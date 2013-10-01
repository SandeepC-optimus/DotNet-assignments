//////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the webpage created for a normal user only having the privileges to upload a document.
///////////////////////////////////////////////////////////////////////////////////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 
#endregion

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        FileUpload1.SaveAs("e:\\" + FileUpload1.FileName);
    }
}