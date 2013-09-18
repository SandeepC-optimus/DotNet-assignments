//////////////////////
// This is Assignment-3 Covering the concepts of Enumeration
//////////////////////


#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
#endregion

namespace Assignment_3_Enumeration
{
    /// <summary>
    /// This is the class created to test the working of Enumerations
    /// </summary>
    class TestEnum
    {
        /// <summary>
        /// An Enumeration is created which stores the values of Weekdays
        /// </summary>
        enum WeekDays { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
        /// <summary>
        /// This is the Main() Method, responsible for the execution of the Program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           int choice;
           WeekDays result= WeekDays.Monday;
           string str;
           Console.WriteLine("Choose the Day to see the Message");
           Console.WriteLine("1. Sunday    2.Monday    3.Tuesday     4.Wednesday     5.Thursday     6.Friday   7.Saturday");
           str = Console.ReadLine();
           choice = int.Parse(str);
           if (choice == 1)
           {
               result=WeekDays.Sunday;
               Console.WriteLine(" day is {0}", result);
           }
           else if (choice == 2)
           {
               result= WeekDays.Monday;
               Console.WriteLine(" day is {0}", result);
           }
           else if (choice == 3)
           {
               result=WeekDays.Tuesday;
               Console.WriteLine(" day is {0}", result);
           }
           else if (choice == 4)
           {
               result=WeekDays.Wednesday;
               Console.WriteLine(" day is {0}", result);
           }
           else if (choice == 5)
           {
               result=WeekDays.Thursday;
               Console.WriteLine(" day is {0}", result);
           }
           else if (choice == 6)
           {
               result=WeekDays.Friday;
               Console.WriteLine(" day is {0}", result);
           }
           else if (choice == 7)
           {
               result=WeekDays.Saturday;
               Console.WriteLine(" day is {0}", result);
           }
           else 
           {
               Console.WriteLine(" Invalid Choice ");
               
           }
           Console.ReadKey();
        }
    }
}
