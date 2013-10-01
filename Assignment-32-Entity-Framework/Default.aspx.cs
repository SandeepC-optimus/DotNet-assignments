/////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the website created using Entity Framework and ADO.NET data Entity Model.
/////////////////////////////////////////////////////////////////////////////////////////////////////////


#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data; 
#endregion

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Text = " ";
    }
    /// <summary>
    /// This is the function called when user clicks on the button.
    /// This function checks the username and password from database and fetch the role of the user and accordingly the pages with the privileges are opened.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        
    SqlConnection con = new SqlConnection();
    con.ConnectionString = "Data Source=OPTIMUS-PC-NEW1;Initial Catalog=userdata;Integrated Security=True";

        // This String decides the page to be opened after login.
    String verify="Deny";
    try
    {
        string query1 = "Select roles from users where username='" + TextBox1.Text + "' and pswrd='" + TextBox2.Text + "' ";
        SqlCommand cmd1 = new SqlCommand(query1, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd1);
        DataTable dt = new DataTable();
        da.Fill(dt);

        //Value or role assigned to the user is stored in string and the page is opened accoring to the privileges
        con.Open();
        verify = cmd1.ExecuteScalar().ToString();
        con.Close();
    }
    catch (SqlException e1)
    {
        Label3.Text = "invalid Username or Password" + e1.Message;
    }

    
    if (verify=="Deny")
    {
        Response.Redirect("Default.aspx");
    }
    else if (verify == "admin")
    {
        Response.Redirect("Admin.aspx",true);
    }
    else if (verify == "Normal")
    {
        Response.Redirect("Normal.aspx",true);
    }
}
    
}