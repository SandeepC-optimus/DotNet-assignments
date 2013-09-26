////////////////////////////////////////////
//// This is namespace conatining data handler class which directly interacts at database level.
////////////////////////////////////////////


#region NameSpace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
#endregion

namespace DataHandler
{
    /// <summary>
    /// This is the class created to insert data into Database using ADO.Net
    /// </summary>
    public class StudentDataHandler
    {
      
        #region Add Student
        /// <summary>
        /// This is the method created to push new student data into database.
        /// </summary>
        /// <param name="rollno"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="age"></param>
        /// <param name="dob"></param>
        /// <param name="streamID"></param>
        /// <param name="stateID"></param>
        /// <returns></returns>

        public bool AddStudent(int rollno, string fname, string lname, int age)
        {
            string cstr = "Data Source=OPTIMUS-PC-NEW1;Initial Catalog=students;Integrated Security=SSPI;";
            SqlConnection cn = new SqlConnection(cstr);
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.Open();
                cmd.Parameters.AddWithValue("@a1", rollno);
                cmd.Parameters.AddWithValue("@a2", fname);
                cmd.Parameters.AddWithValue("@a3", lname);
                cmd.Parameters.AddWithValue("@a4", age);
               
                cmd.CommandText = "insert into stData(rollno,fname,lname,age) values(@a1,@a2,@a3,@a4)";
                cmd.Connection = cn;

                SqlDataAdapter dd = new SqlDataAdapter(cmd);
                DataSet dst = new DataSet();
                dd.Fill(dst);

                cn.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        #endregion

        

    }
}