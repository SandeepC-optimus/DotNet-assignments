//////////////////////////////////////////////////////////////////
////This is a utilty namespace conatining the basic functions.
/////////////////////////////////////////////////////////////////


#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using StudentDetails; 
#endregion

namespace UtilityFunc
{
    /// <summary>
    /// This is the class containing the basic utility functions for using csv file
    /// </summary>
     public class Utility
    {

        #region Loading csv
        /// <summary>
        /// This is a method which loads the csv file uploaded by user and add the data to list to add it to database
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public List<Student> LoadFromCSV(string fileName)
        {
            List<Student> lst = new List<Student>();
            try
            {
                var reader = new StreamReader(fileName);
                while (!reader.EndOfStream)
                {
                    Student st = new Student();
                    var line = reader.ReadLine();
                    var val = line.Split(',');

                    st.rollno = int.Parse(val[0].ToString());
                    st.fname = val[1].ToString();
                    st.lname = val[2].ToString();
                    st.age = int.Parse(val[3].ToString());
                    lst.Add(st);
                }
                return lst;
            }
            catch (IOException e)
            {
                string exp = e.Message;
                return lst;
            }
        } 
        #endregion

        #region Add to Database
        /// <summary>
        /// This is to add the student from csv file to database
        /// </summary>
        /// <param name="studentData"></param>
        /// <returns></returns>
        public bool InsertStudent(List<Student> studentData)
        {
            try
            {
                foreach (Student data in studentData)
                {
                    data.AddStudent();
                }
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        } 
        #endregion
    }
}