////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the namespace Assignment_26_XML_3 containing Student Class used for reading data from XML File and Writing it to Database.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web; 
#endregion

namespace Assignment_26_XML_3
{
    /// <summary>
    /// This is the implementaion of the student class having various attributes.
    /// </summary>
    public class Student
    {

            public int rollNo;
            public string grade;
            public string branch;
            public string name;
            /// <summary>
            /// This function is created to Insert the list fo students generated from xml file to database
            /// </summary>
            /// <param name="students"></param>
            /// <returns></returns>
            public static bool InsertStudents(List<Student> stdata)
            {
                string connStr = "Data Source=OPTIMUS-PC-NEW1;Initial Catalog=studentfromxml;Integrated Security=True";
                try
                {
                    for (int i = 0; i < stdata.Count; i++)   //Iterate through list
                    {
                        int rollNo1 = stdata[i].rollNo;
                        string grade1 = stdata[i].grade;
                        string branch1 = stdata[i].branch;
                        string name1 = stdata[i].name;
                        string query = "insert into stdata(rollNo,grade,branch,name) values (@a1,@a2,@a3,@a4)";
                        using (SqlConnection conn = new SqlConnection(connStr)) //initialize SQL Connection
                        {
                            using (SqlCommand cmd = new SqlCommand()) //Initialize SQL Command
                            {
                                conn.Open();
                                
                                cmd.Parameters.AddWithValue("@a1", rollNo1);
                                cmd.Parameters.AddWithValue("@a2", grade1);
                                cmd.Parameters.AddWithValue("@a3", branch1);
                                cmd.Parameters.AddWithValue("@a4", name1);
                                cmd.CommandText = query;
                                cmd.Connection = conn;
                                SqlDataAdapter dd = new SqlDataAdapter(cmd);
                                DataSet dst = new DataSet();
                                dd.Fill(dst);
                                conn.Close();//close the connection
                            }
                        }
                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }

        }
    }
