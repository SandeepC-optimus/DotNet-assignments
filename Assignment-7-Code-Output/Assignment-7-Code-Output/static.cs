//////////////////////////////
////This is Assignment_7_Code_Output covering the basic concepts of OOPS
/////////////////////////////

#region NameSpace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
#endregion

namespace Assignment_7_Code_Output
{
    
    #region Saving Account Class

    /// <summary>
    /// This is a Dummy Class Created to Check the output of the given code
    /// This is based on real time example of Bank Saving Account
    /// </summary>

    class SavingsAccount
    {
        #region Variable Members
        public double currBalance;
        /// <summary>
        /// The static keyword over here signifies that currBalance variable doesnot belongs to a particular object, it is common for all the objects.
        /// </summary>
        public static double currInterestRate = 0.04;
        #endregion

        #region Constructor
        /// <summary>
        /// This is a parameterized Constructor which initializes the private members at the time of declaration
        /// </summary>
        /// <param name="balance"></param>
        public SavingsAccount(double balance) { currBalance = balance; }
        #endregion
        
        #region Public Methods
        /// <summary>
        /// The method SetInterestRate is static and is using a static member variable of class.
        /// the static keyword over here signifies that it does not belongs to a particular object, it is common for all the objects.
        /// </summary>
        /// <param name="newRate"></param>
        public static void SetInterestRate(double newRate) { currInterestRate = newRate;}
       /// <summary>
        /// The method GetInterestRate is static and is using a static member variable of class.
        /// the static keyword over here signifies that it does not belongs to a particular object, it is common for all the objects.
       /// </summary>
       /// <returns></returns>
        public static double GetInterestRate() { return currInterestRate; }
        /// <summary>
        /// The method SetInterestRate is used to change the interest rate
        /// </summary>
        /// <param name="newRate"></param>
        public void SetInterestRateObj(double newRate) { currInterestRate = newRate; }
        /// <summary>
        /// The method GetInterestRate is used to get the interest rate
        /// </summary>
        /// <returns></returns>
        public double GetInterestRateObj() { return currInterestRate; }
        #endregion

    } 
    #endregion
    class TestCodeOutput
    {
        /// <summary>
        ///  This is the Main() Method, responsible for the execution of the Program.
        /// </summary>
        /// <param name="args"></param>
        #region Main Function
        static void Main(string[] args)
        {

            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);
            Console.WriteLine("Interest Rate is: {0}", s1.GetInterestRateObj());
            s2.SetInterestRateObj(0.08);
            Console.WriteLine("Interest Rate is: {0}", s1.GetInterestRateObj());
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Interest Rate is: {0}", s1.GetInterestRateObj());
            Console.ReadKey();
        } 
        #endregion
    }
}
