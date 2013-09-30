using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Assignment_13_Collection_and_list_2
{

    #region Class Vehicle

    /// <summary>
    /// This is the base class from which various derived classes are inherited
    /// </summary>

    class Vehicle : IComparable<Vehicle>
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

        #region Over Ridden Method of IComparable

        /// <summary>
        /// This is the Public method which is basically of class IComparable and is overridden in this class
        /// This method basically comapares two Objects of this class on basis of Public Property.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        public int CompareTo(Vehicle obj)
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

        public bool Equals(Vehicle obj)
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

    class Program
    {
                
        static void Main(string[] args)
        {
            var VehicleList = new ArrayList()            //Initializing the arrayLists element
                {
                    new Vehicle("Merc",2012,"c201",250),
                    new Vehicle("Yamaha",2013,"FZ-S",180),
                    new Vehicle("BMW",2010,"320d",300),
                    new Vehicle("AUDI",2011,"A4",270)
                };


            // Adding Derived List to the ArrayList
            VehicleList.Add(new Vehicle("Audi", 2011, "Q5", 270));
            VehicleList.Add(new Vehicle("Audi", 2011, "Q3", 230));


            //Enumerating through the list content

            foreach (Vehicle v1 in VehicleList)
            {
                Console.WriteLine("Make is {0}, Model is {1}, Year of Manufacture is {2}, Speed id{3}", v1.make, v1.model, v1.yearOfManufacture, v1.speed);
                Console.ReadKey();
            }


            // Getting the list of elements using 


            Console.WriteLine("Make , Model , Year of Manufacture , Speed respectively using Indexes are");

            for (int i = 0; i < VehicleList.Count; i++)
            {
                Console.WriteLine(((Vehicle)VehicleList[i]).make.ToString() + "   " + ((Vehicle)VehicleList[i]).model.ToString() + "   " + ((Vehicle)VehicleList[i]).yearOfManufacture.ToString() + "   " + ((Vehicle)VehicleList[i]).speed.ToString());
                Console.ReadKey();
            }
        }
    }
}
