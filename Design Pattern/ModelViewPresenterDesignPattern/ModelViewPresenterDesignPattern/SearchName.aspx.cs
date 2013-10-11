///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the name space containing a web page which represents the View of Model View Presenter design pattern.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Name Space
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Presenter1;
using Model1; 
#endregion

namespace ModelViewPresenterDesignPattern
{
    // This is the Search Student page which implements the Interface Search Student
    public partial class _Default : System.Web.UI.Page, SearchStudent
    {
        // List of Students to Show List fetch on to a grid
        private List<Student> students = new List<Student>();

        // Object of Class Student Present which is basically a part of presentation layer
        private StudentPresent presenter; 

        // This is the event which is triggered when the page is loaded
        protected void Page_Load(object sender, EventArgs e)
        {
            InitPresenter();
        }

        // Method to Initialize the object of Student Present class having Global scope
        private void InitPresenter()
        {
            if (presenter == null)
                presenter = new StudentPresent(this);//Initialize the presenter instance
        }

        // Get the name Entered by User in View Layer
        public string Name   
        {
            get { return txtName.Text; }
        }

        // Void handler Event of Interface Search Student
        public event VoidHandler Search;

        // Implementation of a List of Student in Interface 
        // This Property Fetches the Search result and save it into Local List students
        public List<Model1.Student> Students
        {
            set { students = value; }
        }


        // This is the click button event which is triggered when user click on Search Button
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //Instantiate presenter
            InitPresenter();  

            // Check if search is not null then it will call the Search function
            if (Search != null)
                Search();
            // Display the Data stored in list in Data Grid View
            GridView1.DataSource = students;  
            GridView1.DataBind();
        }
    }
}