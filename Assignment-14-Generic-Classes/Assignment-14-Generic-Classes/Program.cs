using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_14_Generic_Classes
{




    #region Base Class Vehicle

    /// <summary>
    /// This is the base class from which various derived classes are inherited
    /// </summary>

    class Vehicle<T> :IComparable<Vehicle<T>>, IEquatable<Vehicle<T>>
    {
        #region Private Member Varibles
        string _make;
        int _yearOfManufacture;
        string _model;
        float _speed;
        T _details;
        #endregion

        #region Properties accessing private members
        /// <summary>
        /// This is the property Exposing private member _details as public
        /// </summary>
        public T details
        {
            get
            {
                return _details;
            }
            set
            {
                this._details = value;
            }
        }



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

        public Vehicle(string make1, int yom, string model1, float speed1,T detail)
        {
            this.make = make1;
            this.yearOfManufacture = yom;
            this.model = model1;
            this.speed = speed1;
            this.details = detail;
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

        #region Over Ridden Method of IComparable

        /// <summary>
        /// This is the Public method which is basically of class IComparable and is overridden in this class
        /// This method basically comapares two Objects of this class on basis of Public Property.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        public int CompareTo(Vehicle<T> obj)
        {

            if (String.Compare(this.make, obj.make) != 0)
            {
                Console.WriteLine("Not Same");
                return String.Compare(this.make, obj.make);
            }

            else
            {
                Console.WriteLine("Same");
                return String.Compare(this.make, obj.make);
            }

        }
        #endregion

        #region Over Ridden Method Equals
        /// <summary>
        /// This is the Public method which is basically of namespace System and is overridden in this class
        /// This method basically comapares two Objects of this class on basis of Public Property.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        public bool Equals(Vehicle<T> obj)
        {

            if ((String.Compare(this.make, obj.make) == 0) && this.yearOfManufacture == obj.yearOfManufacture && (string.Compare(this.model, obj.model) == 0))
            {
                return true;
            }

            else
            {
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

    class Bicycle<T> : Vehicle<T>
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


        public Bicycle(string make, int year, string model, float speed, T details)
            : base(make, year, model, speed, details)
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

    class Bike<T> : Vehicle<T>
    {
        int no_of_tyres;


        #region Constructor_bike

        /// <summary>
        /// This is a parameterized Constructor which initializes the private members at the time of declaration
        /// </summary>

        public Bike(string make, int year, string model, float speed, T details)
            : base(make, year, model, speed, details)
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

    class Car<T> : Vehicle<T>
    {
        int no_of_tyres;

        #region Constructor_Car

        /// <summary>
        /// This is a parameterized Constructor which initializes the private members at the time of declaration
        /// </summary>

        public Car(string make, int year, string model, float speed, T details)
            : base(make, year, model, speed, details)
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

    class Truck<T> : Vehicle<T>
    {
        int no_of_tyres;

        #region Constructor_Truck

        /// <summary>
        /// This is a parameterized Constructor which initializes the private members at the time of declaration
        /// </summary>

        public Truck(string make, int year, string model, float speed,T details)
            : base(make, year, model, speed, details)
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



    #region Sorting on make
    /// <summary>
    /// It is Class derived from IComparer and its method Compare is over ridden.
    /// It sorts the objects on make in aphabetical order.
    /// </summary>
    class Vehicle_SortByMakeInAlphabeticalOrder<T> : IComparer<Vehicle<T>>
    {
        public int Compare(Vehicle<T> x, Vehicle<T> y)
        {
            return string.Compare(x.make, y.make);
        }

    }


    #endregion



    #region Sorting By Speed
    /// <summary>
    /// It is Class derived from IComparer and its method Compare is over ridden.
    /// It sorts the objects on speed.
    /// </summary>

    class Vehicle_SortBySpeed<T> : IComparer<Vehicle<T>>
    {

        public int Compare(Vehicle<T> x, Vehicle<T> y)
        {
            if (x.speed < y.speed) return 1;
            else if (x.speed > y.speed) return -1;
            else return 0;
        }

    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            // Creating array List of Vehicle Objects and sorting them

            List<Vehicle<int>> VehicleList = new List<Vehicle<int>>
                {
                    new Car<int>("Merc",2012,"c201",250,4),
                    new Bike<int>("Yamaha",2013,"FZ-S",180,3),
                    new Bicycle<int>("BMW",2010,"320d",300,2),
                    new Truck<int>("AUDI",2011,"A4",270,1)
                };

            Vehicle<int> v1 = new Car<int>("Audi", 2011, "Q5", 270, 6);
            Vehicle<int> v2 = new Car<int>("Audi", 2011, "Q3", 270, 5);


            // Testing of over ridden method of IComparable.CompareTo in vehicle

            v1.CompareTo(v2);





            // Testing of over ridden method of Equals in vehicle

            if (v1.Equals(v2))
                Console.WriteLine("Both the vehicles are equal");
            else
                Console.WriteLine("Both the vehicles are not equal");






            // Adding objects to lists.

            VehicleList.Add(v1);
            VehicleList.Add(v2);





            // Creating objects of Sorting Class derived from IComparer<Vehicle>

            Vehicle_SortByMakeInAlphabeticalOrder<int> makeSort = new Vehicle_SortByMakeInAlphabeticalOrder<int>();
            Vehicle_SortBySpeed<int> speedSort = new Vehicle_SortBySpeed<int>();





            // Sorting on make of class
            
            VehicleList.Sort(makeSort);
            Console.WriteLine("Sorted Vehicle List on make");
            foreach (Vehicle<int> v3 in VehicleList)
            {
                Console.WriteLine("make is {0}, Model is {1} and Speed is {2}", v3.make, v3.model, v3.speed);
            }

            Console.ReadKey();


            // Sorting on speed of car

            VehicleList.Sort(speedSort);
            Console.WriteLine("Sorted Vehicle List on Speed");
            foreach (Vehicle<int> v3 in VehicleList)
            {
                Console.WriteLine("make is {0}, Model is {1} and Speed is {2}", v3.make, v3.model, v3.speed);
            }



            ///Sorting doesnot depends on the functionality of IComparable.CompareTo(Object obj) method rather it depends on IComparer.Compare(Object obj1, object obj2)

            Console.ReadKey();

        }
    }
}
