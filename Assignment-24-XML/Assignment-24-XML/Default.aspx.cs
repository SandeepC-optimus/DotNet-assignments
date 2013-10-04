//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is Assignment_24_XML Web application, Created to perform following Functions:
//// (1) Add Node: On clicking this button a new node (“assignment”) should be added in XML file. 
//// It should have an attribute ‘Submitted=”y” and child nodes as <number>1</number> 
//// (2) First Child: Will display the first child of root node in a textbox. 
//// (3) Insert Before: Insert an empty node (‘testing’) before Training node. 
//// (4) Remove Node: This should remove the ‘Assignment’ node. 
//// (5) Child node: display all the child nodes of root node in a textbox. 
//// (6) Total Nodes: Displays the total number of child nodes of root node.
//// (7) Replace Child: Replace ‘Testing’ node with ‘Testing Over’ node.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Diagnostics;
using System.Xml.XPath; 
#endregion

namespace Assignment_24_XML
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Create XML
        /// <summary>
        /// This is the function created to Create XML document at a particular location in a particular format,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button5_Click(object sender, EventArgs e)
        {
            using (XmlWriter writer = XmlWriter.Create("Test.xml"))
            {
                string filepath = "C://Users/Shweta Sharma/Documents/Visual Studio 2010/Projects/Assignment-24-XML/Assignment-24-XML/test.xml";

                // Object of xml text writer is used to create the xml document

                XmlTextWriter w = new XmlTextWriter(filepath, null);
                w.Formatting = Formatting.Indented;
                w.WriteStartDocument();
                w.WriteStartElement("iCalibrator");
                w.WriteStartElement("Training");
                w.WriteAttributeString("Day", "1");
                w.WriteElementString("Chapter", "XML-1");
                w.WriteElementString("Chapter", "XML-2");
                w.WriteEndElement();
                w.WriteEndElement();
                w.WriteEndDocument();
                w.Flush();
                w.Close();


            }
        } 
        #endregion
        
        #region First Child
        /// <summary>
        /// This is the function created to find the First Child node of a XML Document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            XPathDocument document = new XPathDocument("C://Users/Shweta Sharma/Documents/Visual Studio 2010/Projects/Assignment-24-XML/Assignment-24-XML/test.xml");
            XPathNavigator navigator = document.CreateNavigator();

            XPathNodeIterator nodes = navigator.Select("/");

            // Traverse the Navigator to First Child
            navigator.MoveToFirstChild();

            // Display the value of Navigator
            TextBox1.Text = navigator.Value.ToString(); ;
            TextBox1.Enabled = false;


        } 
        #endregion
        
        #region Insert Before
        /// <summary>
        /// This is the function created to Insert Before: Insert an empty node (‘testing’) before Training node.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button3_Click(object sender, EventArgs e)
        {
            string fileName = "C://Users/Shweta Sharma/Documents/Visual Studio 2010/Projects/Assignment-24-XML/Assignment-24-XML/test.xml";
            XmlDocument doc = new XmlDocument();

            // Loading the document
            doc.Load(fileName);

            XmlNode root = doc.DocumentElement;

            //Create a new node.
            XmlElement elem = doc.CreateElement("Testing");
            elem.InnerText = "";

            //Add the node to the document.
            root.InsertBefore(elem, root.FirstChild);

            //Saving the Changes made into document
            doc.Save(fileName);

        } 
        #endregion
        
        #region Add Node
        /// <summary>
        /// This is the function created to Add Node: On clicking this button a new node (“assignment”) should be added in XML file. 
        /// It should have an attribute ‘Submitted=”y” and child nodes as <number>1</number>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            string filepath = "C://Users/Shweta Sharma/Documents/Visual Studio 2010/Projects/Assignment-24-XML/Assignment-24-XML/test.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);
            //creating new node
            XmlNode assignment = doc.CreateNode(XmlNodeType.Element, "Assignment", null);

            //adding attribute Submitted to Assignment node
            XmlAttribute quantity = doc.CreateAttribute("Submitted");

            //adding assignment attribute submitted's value to 'Y'
            quantity.Value = "y";

            //creating new child node
            XmlNode number = doc.CreateNode(XmlNodeType.Element, "number", null);

            //assigning the value to 1
            number.InnerText = "1";

            //appending the number node to Assignment node
            assignment.AppendChild(number);

            //appending attributes to student
            if (assignment.Attributes != null) assignment.Attributes.Append(quantity);

            //appending assignment node to document
            if (doc.DocumentElement != null) doc.DocumentElement.AppendChild(assignment);


            //Saving the Changes made into document
            doc.Save(filepath);
        } 
        #endregion

        #region Remove Node
        /// <summary>
        /// This is the function created to Remove Node: This should remove the ‘Assignment’ node.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button4_Click(object sender, EventArgs e)
        {
            string filepath = "C://Users/Shweta Sharma/Documents/Visual Studio 2010/Projects/Assignment-24-XML/Assignment-24-XML/test.xml";
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filepath);

                // Move to root element
                XmlElement elm = doc.DocumentElement;

                // Finding the root Assignment and removing it
                if (elm != null)
                {
                    XmlNode findnode = elm.SelectSingleNode("Assignment");
                    if (findnode != null) elm.RemoveChild(findnode);
                }
                doc.Save(filepath);
            }

            catch (Exception exp)
            {
                Response.Write(exp.Message + "Node not available");
            }

        } 
        #endregion

        #region Open XML Document
        /// <summary>
        /// This is the function created to Open the XML Document in Internet Explorer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button9_Click(object sender, EventArgs e)
        {
            // Opening the xml document in Internet Explorer
            Process.Start("IExplore.exe", "http://localhost:4139/test.xml");
        } 
        #endregion

        #region Child Node
        /// <summary>
        ///  This is the function created to find Child node: display all the child nodes of root node in a textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button6_Click(object sender, EventArgs e)
        {
            string filepath = "C://Users/Shweta Sharma/Documents/Visual Studio 2010/Projects/Assignment-24-XML/Assignment-24-XML/test.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);

            // Creating an object of XPathNaviagtor
            XPathNavigator navigator = doc.CreateNavigator();

            string temp = "";

            // Traversing using xpath navigator
            while (navigator.MoveToChild(XPathNodeType.Element))
            {
                temp = temp + navigator.Name;
                temp = temp + " , ";
            }

            TextBox2.Text = temp;
        }

        #endregion

        #region Total Nodes
        /// <summary>
        ///  This is the function created to Find Total Nodes: Displays the total number of child nodes of root node.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button7_Click(object sender, EventArgs e)
        {

            XPathDocument document = new XPathDocument("C://Users/Shweta Sharma/Documents/Visual Studio 2010/Projects/Assignment-24-XML/Assignment-24-XML/test.xml");
            XPathNavigator navigator = document.CreateNavigator();
            int total = 0;
            // Traversing using xpath navigator
            while (navigator.MoveToChild(XPathNodeType.Element))
            {
                total++;
            }

            TextBox3.Text = total.ToString();

        } 
        #endregion

        #region Replace Child
        /// <summary>
        /// This is the function created to Replace Child: Replace ‘Testing’ node with ‘Testing Over’ node.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button8_Click(object sender, EventArgs e)
        {

            string filepath = "C://Users/Shweta Sharma/Documents/Visual Studio 2010/Projects/Assignment-24-XML/Assignment-24-XML/test.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);

            XmlNode node = doc.DocumentElement;

            // Creating an xml element to be replaced
            XmlElement element = doc.CreateElement("TestingOver");

            if (node != null)
                node.ReplaceChild(element, node.ChildNodes.Item(0));

            doc.Save(filepath);

        } 
        #endregion



    }
}
