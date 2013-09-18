//////////////////////
// This is Assignment_8_OOPS_Concept covering the basic concepts of OOPs.
/////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
#endregion

namespace Assignment_8_OOPS_Concept
{
    public class Student
    {
        #region Private member variables
        private int _rollNo;
        private string _name;
        private int _age;
        private int _marks; 
        #endregion

        #region Private Member Variables exposed through properties
        /// <summary>
        /// This is the property Exposing private member _name as Public
        /// </summary>
        public string name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        /// <summary>
        /// This is the property Exposing private member _rollNo as Public
        /// </summary>

        public int rollNo
        {
            get
            {
                return this._rollNo;
            }

            set
            {
                this._rollNo = value;
            }
        }

        /// <summary>
        /// This is the property Exposing private member _age as Public
        /// </summary>
        public int age
        {
            get
            {
                return this._age;
            }

            set
            {
                this._age = value;
            }
        }

        /// <summary>
        /// This is the property Exposing private member _dateOfBirth as Public
        /// </summary>
        public int marks
        {
            get
            {
                return this._marks;
            }

            set
            {
                this._marks = value;
            }
        } 
        #endregion

        

        #region Parameterized Constructor

        /// <summary>
        /// This is a parameterized Constructor which initializes the private members at the time of declaration
        /// </summary>
        
        public Student(string name, int age, int marks)
        {
            Random r=new Random();
            this.rollNo = r.Next(1001, 2000);
            this.name = name;
            this.age = age;
            this.marks = marks;

            Console.WriteLine("Hello {0},Roll Number is {1}",this.name,this.rollNo);
        } 
        #endregion

        

        #region Public Methods
        /// <summary>
        /// This is a Public Method Showing Details of Students;
        /// </summary>
        /// <returns></returns>
        public void Details()
        {
            Console.WriteLine("Hello Student: your details are as follows\n 1. Roll Number is {0} \n 2. Name is {1} \n 3. Age is {2} \n 4. Marks is {3}\n", this.rollNo, this.name, this.age, this.marks);
        }
        /// <summary>
        /// This is a Public Method updating marks of Student;
        /// </summary>
        /// <returns></returns>
        public void UpdateMarks(int m)
        {
            this.marks = m;
            Console.WriteLine("Marks Updated");
        } 
        #endregion

        

        #region Function Overloading
        enum StudentAttribute { Name, Age };

        /// <summary>
        /// This is a Public Overloaded Method implementing printing name when parameter is String;
        /// </summary>
        /// <returns></returns>
        /// 
        public void Print(string choice)
        {
            Console.WriteLine("Your Choice is  {0}", StudentAttribute.Name);
            Console.WriteLine("Name of Student is {0}", this.name);

        }

        /// <summary>
        /// This is a Public Overloaded Method implementing printing age when parameter is integer;
        /// </summary>
        /// <returns></returns>
        public void Print(int choice)
        {
            Console.WriteLine("Your Choice is  {0}", StudentAttribute.Age);
            Console.WriteLine("Age of {0} is {1}", this.name, this.age);
        } 
        #endregion
    }

    /// <summary>
    /// This is Class TestOOPs in which the main function is executed.
    /// </summary>
    class TestOOPs
    {
        #region Main Function
        static void Main(string[] args)
        {
            // Objects are created for class students
            Student s1 = new Student("Sandeep", 22, 90);
            Student s2 = new Student("Ramesh", 36, 60);

            // Methods of Class Student is invoked using objects
            s1.Details();
            s1.UpdateMarks(95);
            s1.Details();
            s2.Details();

            s1.Print("name");
            s1.Print(1);

            Console.ReadKey();

        } 
        #endregion
    }
}
