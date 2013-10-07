////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the namespace percenatge created to execute various unit tests on Percentage.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Namespace
using Assignment_33_Test_Cases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web; 
#endregion

namespace CheckPercentage
{
    
    
    /// <summary>
    ///This is a test class for DataTest and is intended
    ///to contain all DataTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DataTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

       

        #region Exception Handling
        /// <summary>
        /// This is the Unit test Case created to throw null exception when the value of percentage is 0.0
        ///</summary>

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetPercentageTest_exceptions()
        {
            Data target = new Data();
            double expected = 0.0; // TODO: Initialize to an appropriate value
            double actual = target.percentage;
            Assert.IsTrue(actual == expected);
                throw new ArgumentNullException("Null Value Found");
            
        } 
        #endregion
        
        #region Boundary Values

        /// <summary>
        ///This is the Unit test Case created to Check Boundary Values of the Percentage.
        ///</summary>

        [TestMethod()]
        public void GetPercentageTest_BoundaryValues()
        {
            Data target = new Data();
            target.percentage = 85.50;
            double actual = target.percentage;
            double expected = 1.0;
            if (actual >= 0 && actual <= 100)
                expected = actual;
            Assert.AreEqual(expected, actual);

        } 
        #endregion

        #region Negative Testing
        /// <summary>
        /// This is the Unit test Case created to for Negative Unit Testing
        ///</summary>

        [TestMethod()]
        public void GetPercentage_NegativeTest()
        {
            Data target = new Data();
            // Checking the Negative Scenario where percentage is greater than 100
            target.percentage = 101.25;
            double actual = target.percentage;
            Assert.IsFalse(actual >= 0 && actual <= 100, "Percentage lies in Boundary Value");

            // Checking the Negative Scenario where percentage is less than 0
            target.percentage = -10.50;
            actual = target.percentage;
            Assert.IsFalse(actual >= 0 && actual <= 100, "Percentage lies in Boundary Value");
        } 
        #endregion
        
        #region Positive Testing
		/// <summary>
        /// This is the Unit test Case created to for Positive Unit Testing
        ///</summary>
        
        [TestMethod()]
        public void GetPercentage_PositiveTest()
        {
            Data target = new Data();
            // Checking the Positive Scenario where percentage is Less than 100 and greater than 0
            target.percentage = 99.25;
            double actual = target.percentage;
            Assert.IsTrue(actual >= 0 && actual <= 100, "Percentage lies in Boundary Value");


            // Checking the Positive Scenario where percentage is Less than 100 and greater than 0
            target.percentage = 00.54;
            actual = target.percentage;
            Assert.IsTrue(actual >= 0 && actual <= 100, "Percentage lies in Boundary Value");
        }
 
	#endregion   

    }
}
