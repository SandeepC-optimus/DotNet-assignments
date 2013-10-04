//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the namespace Assignment_25_XML_Searching used for Traversing Student data from XML File.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml; 
#endregion

namespace Assignment_25_XML_Searching
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filepath= "c:\\users\\shweta sharma\\documents\\visual studio 2010\\Projects\\Assignment-25-XML-Searching\\Assignment-25-XML-Searching\\Student.xml";
            XmlDocument doc= new XmlDocument();

            // Load the Document
            doc.Load(filepath);

            // Creating an XmlNode which points to root node Students
            XmlNode stdata= doc.SelectSingleNode("Students");

            // Creating a node list which having all the records of students
            XmlNodeList nodeList = stdata.SelectNodes("Student"); 
                
                if (nodeList != null)
                    foreach (XmlNode node in nodeList)
                    {
                        string branch = "";

                        //Getting the Branch name
                        if (node.Attributes != null) 
                            branch = node.Attributes.GetNamedItem("branch").Value;  
                        if (branch == "MCA")
                        {
                            ListBox1.Items.Add(node.InnerText);
                        }
                                             
                    }
               
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string filepath = "c:\\users\\shweta sharma\\documents\\visual studio 2010\\Projects\\Assignment-25-XML-Searching\\Assignment-25-XML-Searching\\Student.xml";
            XmlDocument doc = new XmlDocument();

            // Load the Document
            doc.Load(filepath);


            // Creating an XmlNode which points to root node Students
            XmlNode stdata = doc.SelectSingleNode("Students");

            // Creating a node list which having all the records of students
            XmlNodeList nodeList = stdata.SelectNodes("Student"); //Add all nodes to node list which are student

            if (nodeList != null)
                foreach (XmlNode node in nodeList)
                {
                    string grade = "";

                    //Getting the Branch name
                    if (node.Attributes != null) 
                        grade = node.Attributes.GetNamedItem("grade").Value;  
                    if (grade == "D")
                    {
                        ListBox2.Items.Add(node.InnerText);
                    }

                }
        }
    }
}