////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is namespace Assignment_27_Serialization_1 containing Student class for the implementation of Serialization.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 
#endregion

namespace Assignment_27_Serialization_1
{
    /// <summary>
    /// This is the Student Class Conataining the attributes of Student and is made serializable.
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
    }
}