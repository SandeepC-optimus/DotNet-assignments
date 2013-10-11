///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the name space containing a Class Operation which operates on attributes to interact with model and view layer.
//// Here it represents a part of Presenter layer of Model View Presenter design pattern.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Name space
using System;
using Model1;
using System.Text;
using System.Collections.Generic;
using System.Linq; 
#endregion

namespace Operations1
{
    public class Operation
    {
        //Declare a list of class Student type 
        static List<Student> students = new List<Student>();

        /// <summary>
        /// Add Values to List as the object is declared
        /// </summary>
        static Operation()
        {
            students.Add(new Student { Name = "Sandeep", Age = 23 });
            students.Add(new Student { Name = "Tarun", Age = 25 });
            students.Add(new Student { Name = "Inder", Age = 29 });
            students.Add(new Student { Name = "Chirag", Age = 22 });
            students.Add(new Student { Name = "Abhishek", Age = 25 });
        }
        /// <summary>
        ///  Getting the details of Students 
        /// </summary>
        /// <param name="s_Name"></param>
        /// <returns>List of Students</returns>
        public static List<Student> GetStudent(string s_Name)
        {
            //Interface to iterate through the list
            IEnumerable<Student> lstStudents = new List<Student>();
            lstStudents = students;
            if (!string.IsNullOrEmpty(s_Name))
                lstStudents = (from s in students where (s.Name.Contains(s_Name)) select s);
            return lstStudents.ToList();
        }
    }
}
