////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the Name space which implements the concept of Factory Design Pattern and Test it by taking an example of Areoplane Factory
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Name Space
using System; 
#endregion


namespace FactoryDesignPattern
{
    /// <summary>
    /// Abstract Class aeroplane which is the main product Requested by client
    /// </summary> 
    abstract class aeroplane
    {
        public abstract string type { get; }
    }

    /// <summary>
    /// Abstract class aeroplane factory which gets the aeroplane to the client
    /// </summary> 
    abstract class aeroplaneFactory
    {
        public abstract aeroplane getAeroplane();
    }

    /// <summary>
    /// A type of aeroplane which can be requested by client
    /// </summary> 
    class aeroplaneProductMustangP51 : aeroplane
    {
        // Name of the type of aeroplane
        string _type = "mustang";

        /// <summary>
        /// This is the property which returns the name of the type of areoplane 
        /// </summary>
        public override string type
        {
            get { return _type; }
        }
    }

    /// <summary>
    /// This is the production factory of aeroplane of type Mustang P51
    /// The request for production comes to this factory
    /// </summary>
    class concreteNorthAmericaFactory : aeroplaneFactory
    {
        /// <summary>
        /// The method of class aeroplane is over-ridden by this class which takes the request and return the object of requested type
        /// </summary>
        /// <returns>Object of type areoplane</returns>
        public override aeroplane getAeroplane()
        {
            return new aeroplaneProductMustangP51();
        }
    }
        
    /// <summary>
    /// TA type of aeroplane which can be requested by client
    /// </summary>
    class aeroplaneProductFW190 : aeroplane
    {
        // Name of the type of aeroplane
        string _type = "Foker-Wulf 190";

        /// <summary>
        /// This is the Property which returns the name of the type of areoplane 
        /// </summary>
        public override string type
        {
            get { return _type; }
        }
    }

    /// <summary>
    /// This is the production factory of aeroplane of type Foker-Wulf 190
    /// The request for production comes to this factory
    /// </summary>
    class concreteFokerWulfFactory : aeroplaneFactory
    {
        /// <summary>
        /// The method of class aeroplane is over-ridden by this class which takes the request and return the object of requested type
        /// </summary>
        /// <returns>Object of type areoplane</returns>
        public override aeroplane getAeroplane()
        {
            return new aeroplaneProductFW190();
        }
    }

    /// <summary>
    /// This is the Test pilot which places the request of an aeroplane of particular type
    /// </summary>
    class testpilot
    {
        /// <summary>
        /// This Method takes aeroplane factory as an argument which is decided by the choice entered by pilot.
        /// This method allows the pilot to ask for a moled of particular type of aeroplane
        /// </summary>
        /// <param name="factory"></param>
        public void askformodel(aeroplaneFactory factory)
        {
            aeroplane aircraft = factory.getAeroplane();
            Console.WriteLine("Plane model {0}", aircraft.type);
        }
    }
}
