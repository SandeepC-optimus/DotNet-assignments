////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the namespace Assignment_33_Test_Cases containing a class having percentage as its attribute and this attribute is used implement Unit Test Cases.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 
#endregion

namespace Assignment_33_Test_Cases
{
    public class Data
    {
        public double percentage;

        /// <summary>
        /// This is the method which returns the percentage and is created to check it for unit tests.
        /// </summary>
        /// <returns></returns>
        public double GetPercentage()
        {
            return percentage;
        }
    }
}