//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the namespace Assignment_28_Serialization_2 containing Student Class containing the attributes of a student, It is Created for the Implementation of serialization.
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
#endregion

namespace Assignment_28_Serialization_2
{
    /// <summary>
    /// This is the Student Class containing the attributes of a student and is made serializable.
    /// </summary>
    [Serializable]
    public class Student
    {
        public int rollNo;
        public string name;
        public int totalMarks;
        private char Grade
        {
            get
            {

                if (totalMarks > 60)
                    return ('D');
                else if (totalMarks >= 60 && totalMarks < 80)
                    return ('C');
                else if (totalMarks >= 80 && totalMarks < 90)
                    return ('B');
                else if (totalMarks >= 90 && totalMarks < 100)
                    return ('A');
                else
                    return ('F');
            }
        }
        /// <summary>
        /// This is the Default constructor.
        /// </summary>
        public Student()
        {
        }


        /// <summary>
        /// This is the Parameterized Constructor
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="rno"></param>
        /// <param name="marks"></param>
        public Student(string name1, int rno, int marks)
        {
            this.name = name1;
            this.rollNo = rno;
            this.totalMarks = marks;
        }
    }
}