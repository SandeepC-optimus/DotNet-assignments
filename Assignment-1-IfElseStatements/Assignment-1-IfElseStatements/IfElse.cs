#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
#endregion

namespace Assignment_1_IfElseStatements
{
    /// <summary>
    /// This is the class created to test the working of if else statements
    /// </summary>
    class Testif
    {
        /// <summary>
        /// This is the Main() Method, responsible for the execution of the Program.
        /// </summary>
        /// <param name="args"></param>
        #region Main Function
        static void Main(string[] args)
        {
            int choice = 0;
            string str;
            Console.WriteLine("Enter your Prefered Language");
            Console.WriteLine("1. DotNet    2. VisualBasic");

            str = Console.ReadLine();
            choice = int.Parse(str);
            #region if-else-if
            if (choice == 1)
            {
                Console.WriteLine("Good choice, C# is a fine lanuage");
            }
            else if (choice == 2)
            {
                Console.WriteLine("VB.NET: OOP, multithreading and more!");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            #endregion
            Console.ReadKey();
        } 
        #endregion
    }
}
