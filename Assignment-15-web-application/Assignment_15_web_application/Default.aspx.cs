using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_15_web_application
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void Button1_Click1(object sender, EventArgs e)
        {
            string username=UserBox.Text;
            Session["username"]=username;
            Response.Redirect("techNews.aspx");
        }
    }
}