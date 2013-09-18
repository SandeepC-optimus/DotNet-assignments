//////////////////////
// This is Assignment_9_Inheritance covering the basic concepts of inheritance where Vehicle is the base class from which bicycle, bike, car, truck classes are inherited.
/////////////////////


#region NameSpace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
#endregion

namespace Assignment_9_Inheritance
{
    
    
    #region Base Class Vehicle

    /// <summary>
    /// This is the base class from which various derived classes are inherited
    /// </summary>

    class Vehicle
    {
        #region Private Member Varibles
        string _make;
        int _yearOfManufacture;
        string _model;
        float _speed;
        #endregion

        #region Properties accessing private members

        /// <summary>
        /// This is the property Exposing private member _make as Public
        /// </summary>

        public string make
        {
            get
            {
                return this._make;
            }
            set
            {
                this._make = value;
            }
        }

        /// <summary>
        /// This is the property Exposing private member _yearOfManufacture as Public
        /// </summary>

        public int yearOfManufacture
        {
            get
            {
                return this._yearOfManufacture;
            }
            set
            {
                this._yearOfManufacture = value;
            }
        }

        /// <summary>
        /// This is the property Exposing private member _model as Public
        /// </summary>

        public string model
        {
            get
            {
                return this._model;
            }
            set
            {
                this._model = value;
            }
        }

        /// <summary>
        /// This is the property Exposing private member _speed as Public
        /// </summary>

        public float speed
        {
            get
            {
                return this._speed;
            }
            set
            {
                this._speed = value;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// This is a parameterized Constructor which initializes the private members at the time of declaration
        /// </summary>
        /// <param name="make1"></param>
        /// <param name="yom"></param>
        /// <param name="model1"></param>
        /// <param name="speed1"></param>
        
        public Vehicle(string make1, int yom, string model1, float speed1)
        {
            this.make = make1;
            this.yearOfManufacture = yom;
            this.model = model1;
            this.speed = speed1;
        }
        #endregion
               
        #region Public Methods

        /// <summary>
        /// This is a Public Method increasing the speed of vehicle;
        /// </summary>
        /// <returns></returns>
        public void Accelerate()
        {
            this.speed = this.speed + 10;
            Console.WriteLine("Accelerating");
        }


        /// <summary>
        /// This is a Public Method decreasing the speed of vehicle;
        /// </summary>
        /// <returns></returns>
        public void Deaccelerate()
        {
            if (this.speed > 10)
            {
                this.speed = this.speed - 10;
                Console.WriteLine("Deaccelerating");
            }
            else if (this.speed > 0 && this.speed < 10)
            {
                this.speed = 0;
            }
            else
            {
                Console.WriteLine("Vehicle is already Stop");
            }
        }


        /// <summary>
        /// This is a Public Method making the speed of vehicle as 0;
        /// </summary>
        /// <returns></returns>
        public void Stop()
        {
            this.speed = 0;
            Console.WriteLine("Stop");
        }


        /// <summary>
        /// This is a Public Method which tells the movement of vehicle;
        /// </summary>
        /// <returns></returns>
        public bool Moving()
        {
            if (this.speed > 0)
            {
                Console.WriteLine("Yes it is moving");
                return true;
            }
            else
            {
                Console.WriteLine("No it is not moving");
                return false;
            }
        }

        #endregion
    } 
    #endregion

    #region Inherited Class Bicycle

    /// <summary>
    /// This is the Derived class Inherited from base class Vehicle.
    /// </summary>

    class Bicycle : Vehicle
    {
        int no_of_tyres;

        
        #region Constructor_bicycle

        /// <summary>
        /// This is a parameterized Constructor which initializes the private members at the time of declaration
        /// </summary>
        /// <param name="make"></param>
        /// <param name="year"></param>
        /// <param name="model"></param>
        /// <param name="speed"></param>


        public Bicycle(string make, int year, string model, float speed)
            : base(make, year, model, speed)
        {
            this.no_of_tyres = 2;
        }
        #endregion

        /// <summary>
        /// This is the public method to fetch the number of tyres of a vehicle.
        /// </summary>
        /// <returns></returns>

        public int GetTyres()
        {
            return no_of_tyres;
        }
    } 
    #endregion

    #region Inherited Class Bike

    /// <summary>
    /// This is the Derived class Inherited from base class Vehicle
    /// </summary>
    
    class Bike : Vehicle
    {
        int no_of_tyres;

        
        #region Constructor_bike

        /// <summary>
        /// This is a parameterized Constructor which initializes the private members at the time of declaration
        /// </summary>

        public Bike(string make, int year, string model, float speed)
            : base(make, year, model, speed)
        {
            no_of_tyres = 2;
        }
        #endregion

        /// <summary>
        /// This is the public method to fetch the number of tyres of a vehicle.
        /// </summary>
        /// <returns></returns>

        public int GetTyres()
        {
            return no_of_tyres;
        }
    } 
    #endregion

    #region Inherited Class Car

    /// <summary>
    /// This is the Derived class Inherited from base class Vehicle
    /// </summary>

    class Car : Vehicle
    {
        int no_of_tyres;

        #region Constructor_Car

        /// <summary>
        /// This is a parameterized Constructor which initializes the private members at the time of declaration
        /// </summary>

        public Car(string make, int year, string model, float speed)
            : base(make, year, model, speed)
        {
            no_of_tyres = 4;
        }
        #endregion

        /// <summary>
        /// This is the public method to fetch the number of tyres of a vehicle.
        /// </summary>
        /// <returns></returns>

        public int GetTyres()
        {
            return no_of_tyres;
        }
    }
    
    #endregion

    #region Inherited Class Truck

    /// <summary>
    /// This is the Derived class Inherited from base class Vehicle
    /// </summary>

    class Truck : Vehicle
    {
        int no_of_tyres;

        #region Constructor_Truck

        /// <summary>
        /// This is a parameterized Constructor which initializes the private members at the time of declaration
        /// </summary>

        public Truck(string make, int year, string model, float speed)
            : base(make, year, model, speed)
        {
            no_of_tyres = 6;
        }
        #endregion

        /// <summary>
        /// This is the public method to fetch the number of tyres of a vehicle.
        /// </summary>
        /// <returns></returns>
        public int GetTyres()
        {
            return no_of_tyres;
        }
    } 
    #endregion


    /// <summary>
    /// This is Class TestInheritance in which the main function is executed.
    /// </summary>
    class TestInheritance
    {
        /// <summary>
        /// This is the main function where Objects of Base class and derived class are invoking member variables and member functions to implement the concept of Inheritance.
        /// </summary>
        /// <param name="args"></param>
        #region Main Function
        static void Main(string[] args)
        {


            // Object of Bicycle
            Bicycle b1 = new Bicycle("Merc", 2012, "x400", 50);
            b1.Accelerate();
            b1.Deaccelerate();
            b1.Moving();
            b1.Stop();
            b1.Moving();
            Console.WriteLine("\nBICYCLE\n\nMake is {0}\nModel is {1}\nSpeed is {2}\nYear of manufacture is {3}\nNo. of tyres are {4}\n", b1.make, b1.model, b1.speed, b1.yearOfManufacture, b1.GetTyres());
            Console.ReadKey(); 
            
            
            // Object of Bike
            Bike b2 = new Bike("Yamaha", 2010, "FZ-S", 200);
            b2.Accelerate();
            b2.Deaccelerate();
            b2.Moving();
            b2.Stop();
            b2.Moving();
            Console.WriteLine("\nBIKE\n\nMake is {0}\nModel is {1}\nSpeed is {2}\nYear of manufacture is {3}\nNo. of tyres are {4}\n", b2.make, b2.model, b2.speed, b2.yearOfManufacture, b2.GetTyres());
            Console.ReadKey(); 
           

            // Object of Car
            Car b3 = new Car("BMW", 2013, "320d", 300);
            b3.Accelerate();
            b3.Deaccelerate();
            b3.Moving();
            b3.Stop();
            b3.Moving();
            Console.WriteLine("\nCAR\n\nMake is {0}\nModel is {1}\nSpeed is {2}\nYear of manufacture is {3}\nNo. of tyres are {4}\n", b3.make, b3.model, b3.speed, b3.yearOfManufacture, b3.GetTyres());
            Console.ReadKey(); 
  

            // Object of Truck
            Truck b4 = new Truck("Volvo", 2012, "a223", 250);
            b4.Accelerate();
            b4.Deaccelerate();
            b4.Moving();
            b4.Stop();
            b4.Moving();
            Console.WriteLine("\nTRUCK\n\nMake is {0}\nModel is {1}\nSpeed is {2}\nYear of manufacture is {3}\nNo. of tyres are {4}\n", b4.make, b4.model, b4.speed, b4.yearOfManufacture, b4.GetTyres());
            Console.ReadKey(); 
            
        }

        #endregion
        
    }
}
