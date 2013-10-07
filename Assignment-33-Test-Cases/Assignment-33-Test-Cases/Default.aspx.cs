/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the namespace Assignment_33_Test_Cases having a gui where user enters the 10th percentage which is stored in an object and used for Unit testing.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 
#endregion

namespace Assignment_33_Test_Cases
{
    public partial class _Default : System.Web.UI.Page
    {
        public static double x;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Data obj = new Data();
            obj.percentage=Convert.ToDouble(TextBox1.Text);
            double val=obj.GetPercentage();
        }
    }
}
