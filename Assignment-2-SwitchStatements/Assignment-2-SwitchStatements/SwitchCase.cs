//////////////////////
// This is Assignment-2 Covering the concepts of Switch case
//////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
#endregion

namespace Assignment_2_SwitchStatements
{
    /// <summary>
    /// This is the class created to test the working of Switch Case
    /// </summary>
    class TestSwitch
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
            #region SwitchCase
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine lanuage");
                    break;
                case 2:
                    Console.WriteLine("VB.NET: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            #endregion
            Console.ReadKey();
        } 
        #endregion
    }
}
