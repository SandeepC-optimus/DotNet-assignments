//////////////////////
// This is Assignment_11_Inheritance covering the basic concepts of inheritance where Student is the base class from which another class are inherited.
/////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion
namespace Assignment_11_Inheritance
{
    #region Base Class

    /// <summary>
    /// This is a Real Time Example of Student which implements the concept of Inheritance, Here Student is the base class from which other classes inherits.
    /// </summary>
    
    class Student
    {
        #region Private members
        int _registrationNo;
        string _name;
        DateTime _dateOfBirth;
        #endregion

        #region properties exposing private variables

        /// <summary>
        /// This is the property Exposing private member _registrationNo as Public
        /// </summary>
        public int registrationNo
        {
            get
            {
                return this._registrationNo;
            }
            set
            {
                this._registrationNo = value;
            }
        }
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
        /// This is the property Exposing private member _dateOfBirth as Public
        /// </summary>
        public DateTime dateOfBirth
        {
            get
            {
                return this._dateOfBirth;
            }
            set
            {
                this._dateOfBirth = value;
            }
        }
        #endregion
                       
        #region Constructor

        // Parameterless Constructor
        
        public Student()
        {
            this.registrationNo = 0;
            this.name = "unknown";
            this.dateOfBirth = new DateTime(2010, 8, 1);
            Console.WriteLine("New Student Created parameterless Constructor");
        }
        /// <summary>
        ///     
        /// </summary>
        /// <param name="rno"></param>
        /// <param name="name"></param>
        /// <param name="dob"></param>
        public Student(int rno, string name, DateTime dob)
        {
            this.registrationNo = rno;
            this.name = name;
            this.dateOfBirth = dob;
            Console.WriteLine("New Student Created parameterized Constructor");
        }
        #endregion

        #region Public Method

        /// <summary>
        /// This is a Public Method calculating the age of a student;
        /// </summary>
        /// <returns></returns>

        public int GetAge()
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            return age;
        }
        #endregion

    }

    #endregion

    
    #region Inherited Class School Student

    /// <summary>
    /// This is a Real Time Example of School Student which inherits the properties of Base Class Student
    /// </summary>

    class SchoolStudent : Student
    {
        #region Private Member Variables
        int _classStudying;
        int _totalMarks;
        int _totalMarksObtained;
        double _percentage;
        #endregion


        #region properties exposing private variables

        /// <summary>
        /// This is the property Exposing private member _classStudying as Public
        /// </summary>

        public int classStudying
        {
            get
            {
                return this._classStudying;
            }
            set
            {
                this._classStudying = value;
            }
        }

        /// <summary>
        /// This is the property Exposing private member _totalMarks as Public
        /// </summary>
        
        public int totalMarks
        {
            get
            {
                return this._totalMarks;
            }
            set
            {
                this._totalMarks = value;
            }
        }


        /// <summary>
        /// This is the property Exposing private member _totalMarksObtained as Public
        /// </summary>

        public int totalMarksObtained
        {
            get
            {
                return this._totalMarksObtained;
            }
            set
            {
                this._totalMarksObtained = value;
            }
        }


        /// <summary>
        /// This is the property Exposing private member _percentage as Public
        /// </summary>

        public double percentage
        {
            get
            {
                return this._percentage;
            }
            set
            {
                this._percentage = value;
            }
        }
        #endregion

        
        #region Constructor

        /// <summary>
        /// Parameterless Constructor
        /// </summary>

        public SchoolStudent()
        {
            this.totalMarks = 100;
            this.totalMarksObtained = 0;
            this.classStudying = 0;
            Console.WriteLine("New School Student Created parameterless Constructor");
        }

        /// <summary>
        /// This is a parameterized Constructor which initializes the private members at the time of declaration
        /// </summary>
        /// <param name="rno"></param>
        /// <param name="name"></param>
        /// <param name="dob"></param>
        /// <param name="tm"></param>
        /// <param name="tmo"></param>
        /// <param name="classS"></param>

        public SchoolStudent(int rno, string name, DateTime dob, int tm, int tmo, int classS)
            : base(rno, name, dob)
        {
            this.totalMarks = tm;
            this.totalMarksObtained = tmo;
            this.classStudying = classS;
            Console.WriteLine("New School Student Created parameterized Constructor");
        }
        #endregion


        #region Public Method

        /// <summary>
        /// This is a Public Method calculating the Percentage of a student;
        /// </summary>
        /// <returns></returns>
        
        public double GetPercentage()
        {
            this.percentage = (double)totalMarksObtained * 100 / totalMarks;
            return this.percentage;
        }
        #endregion
    } 
    #endregion

    
    #region Inherited Class College Student

    /// <summary>
    /// This is a Real Time Example of College Student which inherits the properties from Base Class Student
    /// </summary>

    class CollegeStudent : Student
    {
        #region Private Member Variables
        int _totalMarks;
        int _semesterStudying;
        int _totalMarksObtained;
        double _percentage;
        #endregion

        
        #region properties exposing private variables

        /// <summary>
        /// This is the property Exposing private member _semesterStudying as Public
        /// </summary>

        public int semesterStudying
        {
            get
            {
                return this._semesterStudying;
            }
            set
            {
                this._semesterStudying = value;
            }
        }

        /// <summary>
        /// This is the property Exposing private member _totalMarks as Public
        /// </summary>

        public int totalMarks
        {
            get
            {
                return this._totalMarks;
            }
            set
            {
                this._totalMarks = value;
            }
        }

        /// <summary>
        /// This is the property Exposing private member _totalMarksObtained as Public
        /// </summary>

        public int totalMarksObtained
        {
            get
            {
                return this._totalMarksObtained;
            }
            set
            {
                this._totalMarksObtained = value;
            }
        }

        /// <summary>
        /// This is the property Exposing private member _percentage as Public
        /// </summary>

        public double percentage
        {
            get
            {
                return this._percentage;
            }
            set
            {
                this._percentage = value;
            }
        }
        #endregion

       
        #region Constructor

        /// <summary>
        /// Parameterless Constructor
        /// </summary>


        public CollegeStudent()
        {
            this.totalMarks = 100;
            this.totalMarksObtained = 0;
            this.semesterStudying = 0;
            Console.WriteLine("New College Student Created parameterless Constructor");
        }

        /// <summary>
        /// This is a parameterized Constructor which initializes the private members at the time of declaration
        /// </summary>
        /// <param name="rno"></param>
        /// <param name="name"></param>
        /// <param name="dob"></param>
        /// <param name="tm"></param>
        /// <param name="tmo"></param>
        /// <param name="sem"></param>

        public CollegeStudent(int rno, string name, DateTime dob, int tm, int tmo, int sem)
            : base(rno, name, dob)
        {
            this.totalMarks = tm;
            this.semesterStudying = sem;
            this.totalMarksObtained = tmo;
            Console.WriteLine("New College Student Created parameterized Constructor");
        }
        #endregion

        
        #region Public Method

        /// <summary>
        /// This is a Public Method calculating the Percentage of a student;
        /// </summary>
        /// <returns></returns>

        public double GetPercentage()
        {
            this.percentage = (double)totalMarksObtained * 100 / totalMarks;
            return this.percentage;
        }
        #endregion
    }
    #endregion

    /// <summary>
    /// This is Class test in which the main function is executed.
    /// </summary>

    class Test
    {
        #region Main Function
        /// <summary>
        /// This is the main function where Objects of Base class and derived class are invoking member variables and member functions to implement the concept of Inheritance.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            // objects of inherited class School Student invoking member variables and member functions of base and its own class
            SchoolStudent sc1 = new SchoolStudent();
            SchoolStudent sc2 = new SchoolStudent(100, "Sandeep", new DateTime(1990, 08, 04), 100, 94, 12);

            Console.WriteLine("Age of {0} Studying in {3} is {1} and percentage is {2}", sc1.name, sc1.GetAge(), sc1.GetPercentage(), sc1.classStudying);
            Console.WriteLine("Age of {0} Studying in {3} is {1} and percentage is {2}", sc2.name, sc2.GetAge(), sc2.GetPercentage(), sc2.classStudying);

            Console.ReadKey();


            // // objects of inherited class School Student invoking member variables and member functions of base and its own class
            CollegeStudent c1 = new CollegeStudent();
            CollegeStudent c2 = new CollegeStudent(100, "rajesh", new DateTime(1994, 8, 6), 150, 90, 6);
            Console.WriteLine("Age of {0} is {1} Studying in {2} and percentage is {3}", c1.name, c1.GetAge(), c1.GetPercentage(), c1.semesterStudying);
            Console.WriteLine("Age of {0} is {1} Studying in {2} and percentage is {3}", c2.name, c2.GetAge(), c2.GetPercentage(), c2.semesterStudying);

            Console.ReadKey(); 
            
        } 
        #endregion
    }
}

