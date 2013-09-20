/////////////////////////////////////////////////
////This is Assignment_16_Custom_Exceptions in which custom exceptions are tested in various scenarios.
////////////////////////////////////////////////


#region namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion
namespace Assignment_16_Custom_Exceptions
{
    
    

    #region Exception
    /// <summary>
    /// This is the user defined exeption which occurs when the the speed of car accelerated and Crosses the speed of 300;
    /// </summary>
    public class IsCarDeadException : ApplicationException
    {
        public IsCarDeadException()
        {
        }
        public IsCarDeadException(String message, float Speed)
            : base(message)
        {
            //Console.WriteLine("{0} on {1} km/hr at {2} ", message, Speed, DateTime.Now);
        }
    }

    #endregion

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
        /// This is a Public Method increasing the speed of vehicle;
        /// </summary>
        /// <returns></returns>
        public void Accelerate()
        {

            if (this.speed < 300)
            {
                this.speed = this.speed + 10;
                Console.WriteLine("Accelerating");
            }
            else
            {
                Console.WriteLine("Acheived Maximum Speed, cannot accelerate");
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

        /// <summary>
        /// This the overridden Method of base class;
        /// </summary>
        new public void Accelerate()
        {

            if (this.speed >= 100)
            {

                throw (new IsCarDeadException("Maximum Speed of Bicycle is reached ", this.speed));
            }
            else
            {
                this.speed = this.speed + 10;
            }
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

        /// <summary>
        /// This the overridden Method of base class;
        /// </summary>
        new public void Accelerate()
        {

            if (this.speed >= 200)
            {

                throw (new IsCarDeadException("Bike is overheated", this.speed));
            }
            else
            {
                this.speed = this.speed + 10;
            }
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
        /// <summary>
        /// This the overridden Method of base class;
        /// </summary>
        new public void Accelerate() 
        {

            if (this.speed >= 300)
            {
                
                throw (new IsCarDeadException("Car is overheated",this.speed));
            }
            else
            {
                this.speed = this.speed + 10;
            }
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
        /// <summary>
        /// This the overridden Method of base class;
        /// </summary>
        new public void Accelerate()
        {

            if (this.speed >= 300)
            {

                throw (new IsCarDeadException("Truck is overheated", this.speed));
            }
            else
            {
                this.speed = this.speed + 10;
            }
        }
    }
    #endregion

    /// <summary>
    /// This Class is created to test the user defined exceptions at various scenarios acting differently
    /// </summary>

    class TestException
    {

     

        /// <summary>
        /// This is the main function in which objects of classes are created and are check for custom exceptions.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // Exceptional handling of Car and logging the exception into Event Log.
            Car c1 = new Car("Merc", 2012, "slk", 280);
            try
            {
                c1.Accelerate();
                c1.Accelerate();
               c1.Accelerate();
            }

                
            catch (IsCarDeadException exp)
            {
                Console.WriteLine("{0} on {1} km/hr at {2} ", exp.Message, c1.speed, DateTime.Now);
                System.Diagnostics.EventLog appLog =new System.Diagnostics.EventLog();
                appLog.Source = "IsCarDeadException";
                appLog.WriteEntry(exp.Message);
            }

            Console.ReadKey();



            // Exceptional handling of Bike and logging the exception into Event Log.
            Bike b1=new Bike("Yahama",2011,"FZS",180);
            try
            {
                b1.Accelerate();
                b1.Accelerate();
                b1.Accelerate();
            }


            catch (IsCarDeadException exp)
            {
                Console.WriteLine("{0} on {1} km/hr at {2} ", exp.Message, b1.speed, DateTime.Now);
                System.Diagnostics.EventLog appLog = new System.Diagnostics.EventLog();
                appLog.Source = "IsCarDeadException";
                appLog.WriteEntry(exp.Message);
            }
            Console.ReadKey();


            // Exceptional handling of Bicycle and logging the exception into Event Log.
            Bicycle bc1 = new Bicycle("BMW", 2011, "20j", 80);
            try
            {
                bc1.Accelerate();
                bc1.Accelerate();
                bc1.Accelerate();
            }


            catch (IsCarDeadException exp)
            {
                Console.WriteLine("{0} on {1} km/hr at {2} ", exp.Message, bc1.speed, DateTime.Now);
                System.Diagnostics.EventLog appLog = new System.Diagnostics.EventLog();
                appLog.Source = "IsCarDeadException";
                appLog.WriteEntry(exp.Message);
            }
            Console.ReadKey();



            // Exceptional handling of truck and logging the exception into Event Log.
            Truck t1 = new Truck("Volvo", 2010, "x400", 280);
            
            try
            {
                t1.Accelerate();
                t1.Accelerate();
                t1.Accelerate();
            }


            catch (IsCarDeadException exp)
            {
                Console.WriteLine("{0} on {1} km/hr at {2} ", exp.Message, t1.speed, DateTime.Now);
                System.Diagnostics.EventLog appLog = new System.Diagnostics.EventLog();
                appLog.Source = "IsCarDeadException";
                appLog.WriteEntry(exp.Message);
            }
            Console.ReadKey();


        }
    }
}
