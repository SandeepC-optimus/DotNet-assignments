//////////////////////
// This is Assignment 6 covering the basic concepts of Encapsulation and Abstraction.
/////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
#endregion

namespace Assignment_6_Encapsulation
{
    // Creata a class railway
    /// <summary>
    /// This is a Real Time Example of Banking System which Implements Encapsulation and Data Abstraction
    /// </summary>
    #region Bank class
    public class bank
    {
        #region Variables
        // Attributes of Class railway
        int age;
        int balance;
        string name;
        string sex;

        #endregion
        #region MemberFunctions
        public void DisplayName()
        {
            Console.WriteLine(name);
        }

        public void UpdatePassengerName(string n)
        {
            name = n;
        }

        public void GetData()
        {
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();

            Console.WriteLine("Enter age");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Sex");
            sex = Console.ReadLine();

            Console.WriteLine("Enter balance");
            balance = int.Parse(Console.ReadLine());
        }

        public void UpdateBalance(int temp)
        {
            balance = temp;
        }
        #endregion

    } 
    #endregion
    class Program
    {
        /// <summary>
        /// This is the Main() Method, responsible for the execution of the Program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Creating objects of 
            #region ObjectDeclaration
            bank b1 = new bank();
            bank b2 = new bank();
            bank b3 = new bank();
            bank b4 = new bank();
            bank b5 = new bank(); 
            #endregion

            #region Invoking Methods using Class
            //invoking member functions of class using objects(Real Time Example of Abstraction)

            b1.GetData();
            b2.GetData();
            b3.GetData();
            b4.GetData();
            b5.GetData();

            // Updating Balance (Real Time Example of Abstraction)
            b1.UpdateBalance(5000);
            b2.UpdateBalance(8000);
            b3.UpdateBalance(4000);
            b4.UpdateBalance(2000);
            b5.UpdateBalance(3200);

            //Updating Name
            b4.UpdatePassengerName("Rajesh");


            //Display Name
            b4.DisplayName(); 
            #endregion
        }
    }
}
