//////////////////////
// This is Assignment-5 Covering the concepts of String Arrays
//////////////////////

#region namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
#endregion

namespace Assignment_5_StringArrays
{
    /// <summary>
    /// This is the class created to test the working of String Arrays
    /// </summary>
    class TestStringArrays
    {
       
        /// <summary>
        /// This is a Method GetStringArrays which returns a variable of type String Array
        /// </summary>
        /// <returns>String Array</returns>
        #region public_methods
        public static string[] GetStringArray()
        {
            string[] temp = new string[] { "hi", "how", "are", "You" };
            return temp;
        }
        #endregion

        /// <summary>
        /// This is the Main() Method, responsible for the execution of the Program.
        /// </summary>
        /// <param name="args"></param>
        #region Main Function
        static void Main(string[] args)
        {
            String[] str = new string[6];            // A variable is declared to Store the value returned by GetStringArray Method
            str = GetStringArray();                  // Calling the method GetStringArray and storing the value in a String
            foreach (string value in str)
            {
                Console.WriteLine(value);

            }

            Console.ReadKey();
        }  
        #endregion
       

    }
}
