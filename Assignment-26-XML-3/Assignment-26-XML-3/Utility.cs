//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the namespace Assignment_26_XML_3 containing Utility Class used for reading data from XML File and Writing it to Database.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml; 
#endregion

namespace Assignment_26_XML_3
{
    public class Utility
    {
        /// <summary>
        /// This is the function created to load the data from the xml file and push that data to the database.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool LoadStudentsFromXMLFile(string fileName)
        {
            List<Student> list = new List<Student>();
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("c:\\users\\shweta sharma\\documents\\visual studio 2010\\Projects\\Assignment-26-XML-3\\Assignment-26-XML-3\\Student.xml");   //Load the xml file

                //Move to root node named as students
                XmlNode stdata = doc.SelectSingleNode("Students");  
                if (stdata != null)
                {

                    //Move to child node named as student
                    XmlNodeList nodeList = stdata.SelectNodes("Student");
                    Student st = new Student();
                    if (nodeList != null)

                        //Traverse through each student record
                        foreach (XmlNode node in nodeList)
                        {
                            Student s = new Student();
                            if (node.Attributes != null)
                            {
                                s.rollNo = Convert.ToInt32(node.Attributes.GetNamedItem("rollNo").Value);
                                s.branch = node.Attributes.GetNamedItem("branch").Value;
                                s.grade = node.Attributes.GetNamedItem("grade").Value;
                                s.name = node.Attributes.GetNamedItem("name").Value;
                            }

                            //Add object of student class to the list
                            list.Add(s);  

                        }
                }

                // Call the function of Student class to insert list of students to database
                bool status = Student.InsertStudents(list);


                if ( status == true)
                    return true;
                else
                    return false;
                
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}