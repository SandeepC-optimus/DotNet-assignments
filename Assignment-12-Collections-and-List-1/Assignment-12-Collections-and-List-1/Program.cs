/////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is Assignment_12_Collections_and_List_1.
//// This project implements the various functionalities of IComparable, IComparer and IEnumerable
//////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Namespace
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
#endregion

namespace Assignment_12_Collections_and_List_1
{
    #region Class Vehicle

    /// <summary>
    /// This is the base class from which various derived classes are inherited
    /// </summary>

    class Vehicle :IComparable<Vehicle>
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
        public Vehicle()
        {
            this.make = "Unknown";
            this.yearOfManufacture = 1900;
            this.model = "Unknown";
            this.speed = 0;
        }


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


    #region Sorting on make
    /// <summary>
    /// It is Class derived from IComparer and its method Compare is over ridden.
    /// It sorts the objects on make in aphabetical order.
    /// </summary>
    class Vehicle_SortByMakeInAlphabeticalOrder : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
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

    class Vehicle_SortBySpeed : IComparer<Vehicle>
    {

        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.speed < y.speed) return 1;
            else if (x.speed > y.speed) return -1;
            else return 0;
        }

    } 
    #endregion


    /// <summary>
    /// This is the Class Implementing
    /// </summary>
    public class VehicleCollection : IEnumerable
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            var vh = new Vehicle[3]                                   //Initializing the elements of vehicle array object
            {
                 
                    new Vehicle("Merc",2012,"c201",250),
                    new Vehicle("Yamaha",2013,"FZ-S",180),
                    new Vehicle("BMW",2010,"320d",300),
            };
            foreach (Vehicle vOb in vh)
            {
                if (vOb != null)
                {
                    yield return vOb.make;               //returning make of vaehicle
                }
                else
                    break;
            }
        }
    }
    

    /// <summary>
    /// This is Class Compare vehicle which contains main function to execute and test the various functionalities.
    /// </summary>

    class CompareVehicle
    {
        static void Main(string[] args)
        {
            // Creating array List of Vehicle Objects and sorting them

            List<Vehicle> VehicleList = new List<Vehicle>
                {
                    new Vehicle("Merc",2012,"c201",250),
                    new Vehicle("Yamaha",2013,"FZ-S",180),
                    new Vehicle("BMW",2010,"320d",300),
                    new Vehicle("AUDI",2011,"A4",270)
                };

            Vehicle v1 = new Vehicle("Audi", 2011, "Q5", 270);
            Vehicle v2 = new Vehicle("Audi", 2011, "Q5", 270);



            
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

            Vehicle_SortByMakeInAlphabeticalOrder makeSort = new Vehicle_SortByMakeInAlphabeticalOrder();
            Vehicle_SortBySpeed speedSort = new Vehicle_SortBySpeed();

            
            
            
            
            // Sorting on make of class

            VehicleList.Sort(makeSort);
            Console.WriteLine("Sorted Vehicle List on make");
            foreach (Vehicle v3 in VehicleList)
            {
                Console.WriteLine("make is {0}, Model is {1} and Speed is {2}",v3.make,v3.model,v3.speed);
            }

            Console.ReadKey();
            
            
            // Sorting on speed of car

            VehicleList.Sort(speedSort);
            Console.WriteLine("Sorted Vehicle List on Speed");
            foreach (Vehicle v3 in VehicleList)
            {
                Console.WriteLine("make is {0}, Model is {1} and Speed is {2}", v3.make, v3.model, v3.speed);
            }

            Console.ReadKey();






            // Implementation of IEnumerable
            Console.WriteLine("\n\nIteration of Vehicle Collection Class using Foreach loop ");
            Console.ReadKey();
            VehicleCollection vObj = new VehicleCollection();                            //Creating of vehiclecollection class's object
            foreach (Object s in vObj)
            {
                Console.ReadKey();
                Console.WriteLine(s);
            }
             Console.ReadKey();
        }
    }
}
