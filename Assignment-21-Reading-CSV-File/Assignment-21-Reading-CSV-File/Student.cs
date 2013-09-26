//////////////////////////////////////////////////////////////////////////////////
////This is a Student namespace conatining the basic attributes of class student.
//////////////////////////////////////////////////////////////////////////////////


#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DataHandler; 
#endregion

namespace StudentDetails
{
    /// <summary>
    /// This is the class Student containing various attributes, properties and Function to perform various operations.
    /// </summary>
    public class Student
    {
        int _rollno;
        string _fname;
        string _lname;
        int _age;

        #region Properties
        public int rollno
        {
            get
            {
                return this._rollno;
            }

            set
            {
                this._rollno = value;
            }
        }

        public string fname
        {
            get
            {
                return this._fname;
            }

            set
            {
                this._fname = value;
            }
        }

        public string lname
        {
            get
            {
                return this._lname;
            }

            set
            {
                this._lname = value;
            }
        }

        public int age
        {
            get
            {
                return this._age;
            }

            set
            {
                this._age = value;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// This is the paramertized constructor of class student.
        /// </summary>
        /// <param name="rno"></param>
        /// <param name="name"></param>
        /// <param name="lname"></param>
        /// <param name="age"></param>
        public Student(int rno, string name, string lname, int age)
        {
            this.rollno = rno;
            this.fname = name;
            this.lname = lname;
            this.age = age;
        }


        /// <summary>
        /// This is the paramertless constructor of class student.
        /// </summary>
        public Student()
        {
            this.rollno = 0;
            this.fname = " ";
            this.lname = " ";
            this.age = 0;
        }
        #endregion

        StudentDataHandler data = new StudentDataHandler();

       

        #region Add Student
       /// <summary>
       /// This is the method which is created to puch the attributes of student object into database.
       /// </summary>
       /// <returns></returns>
        public bool AddStudent()
        {
            return data.AddStudent(rollno, fname, lname, age);
        }

        #endregion

    }
}