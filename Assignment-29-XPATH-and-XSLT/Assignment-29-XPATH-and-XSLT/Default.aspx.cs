//////////////////////////////////////////////////////////////////////////////////////////////
//// This is a Web Application created to Implement the functionalities of XPATH and XSLT.
////////////////////////////////////////////////////////////////////////////////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
namespace Assignment_29_XPATH_and_XSLT 
#endregion
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Display Whole XML
        /// <summary>
        /// This is the function called on click of button 1.
        /// On calling of this function the whole xml is displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = "c:\\users\\shweta sharma\\documents\\visual studio 2010\\Projects\\Assignment-29-XPATH-and-XSLT\\Assignment-29-XPATH-and-XSLT\\Student.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(name);

            // Store the content of XML into a string and display in into a text box
            string xmlcontents = doc.InnerXml;
            TextBox1.Text = xmlcontents;
        } 
        #endregion


        #region Display Name, age and Address
        /// <summary>
        /// This is the function called on click of button 2.
        /// On calling of this function the name, age and address is displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = "c:\\users\\shweta sharma\\documents\\visual studio 2010\\Projects\\Assignment-29-XPATH-and-XSLT\\Assignment-29-XPATH-and-XSLT\\Student.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(name);

            XmlNode student = doc.SelectSingleNode("/Students");
            if (student != null)
            {
                XmlNodeList Node = student.SelectNodes("Student");
                string name1 = "";
                string age = "";
                string city = "";
                string country = "";
                int i = 1;
                int j = 1;
                if (Node != null)
                    foreach (XmlNode node in Node)
                    {
                        if (node.Attributes != null)
                        {
                            name1 += "\n" + i++ + ".\t" + node.Attributes.GetNamedItem("name").Value;
                            age += "\n" + j++ + ".\t\t" + node.Attributes.GetNamedItem("age").Value;
                        }
                    }

                // Creating a list of City Nodes
                var cityList = doc.GetElementsByTagName("city");
                i = 1;
                j = 1;
                foreach (XmlNode curr in cityList)
                {
                    city += "\n" + i++ + ".\t\t" + curr.InnerText;
                }


                // Creating a list of Country Nodes
                var countryList = doc.GetElementsByTagName("country");
                foreach (XmlNode curr in countryList)
                {
                    country += "\n" + j++ + ".\t\t" + curr.InnerText;
                }
                TextBox1.Text = "Names:\n" + name + "\n\nAges\n " + age + "\nCities:" + city + "\nCountries: " + country;
            }
        } 
        #endregion


        #region Display XML After adding the childs
        /// <summary>
        /// This is the function called on click of button 3.
        /// On calling of this function the whole xml is displayed after appending the childs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button3_Click(object sender, EventArgs e)
        {
            string temp = "";
            string name = "c:\\users\\shweta sharma\\documents\\visual studio 2010\\Projects\\Assignment-29-XPATH-and-XSLT\\Assignment-29-XPATH-and-XSLT\\Student.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(name);

            XmlNodeList stream = doc.GetElementsByTagName("stream");
            foreach (XmlNode curr in stream)
            {
                temp = curr.InnerText.ToString();
                // Checking whether stream is PCM or not
                if (temp.Equals("PCM"))
                {
                    XmlNode college = doc.CreateNode(XmlNodeType.Element, "College", null); //Creating new Child node
                    college.InnerText = "Engineering";
                    curr.AppendChild(college);
                    doc.Save(name);
                }
            }

            string xmlcontents = doc.InnerXml;
            TextBox1.Text = xmlcontents;
        } 
        #endregion
    }
}