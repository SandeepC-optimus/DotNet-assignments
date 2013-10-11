using System;
using Model;

namespace Operations
{
    public class Operation
    {
        //Declare instance of Generic list of type class Student
        static List<Student> students = new List<Student>();  
        
        /// <summary>
        /// Add Values to 
        /// </summary>
        static Operation()
        {
            students.Add( new Student { Name = "Sandeep", Age = "23"});
            students.Add( new Student { Name = "Tarun", Age = "25"});
            students.Add( new Student { Name = "Inder", Age = "29"});
            students.Add( new Student { Name = "Chirag", Age = "22"});
            students.Add( new Student { Name = "Abhishek", Age = "25"});
        }
        /// <summary>
        ///  Getting Students details
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
