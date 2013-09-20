using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_15_web_application
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if the title of page is Log In then it would keep label as blank or else fetch the username.
            if (this.Page.Title == "Log In")
            {
                Label1.Text = " ";
                LinkButton1.Text= " ";
            }
            else
            {
                LinkButton1.Text = "Log Out";
                
                Label1.Text = Session["username"].ToString();

            }
         }
    }
}
