////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the Name space which implements the concept of Factory Design Pattern and Test it by taking an example of Areoplane Factory
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Name Space
using System; 
#endregion

namespace FactoryDesignPattern
{
    /// <summary>
    /// This is the Class which implements the the concept using aeroplane and areoplane factory
    /// </summary>
    class Implementation
    {
        /// <summary>
        /// This is the method which interacts with user and Sends request using objects of various classes.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Take the user choice
            Console.WriteLine("Enter 1 for  P51 and 2 for FW190");
            string enteredValue = Console.ReadLine();
            int choice = int.Parse(enteredValue);

            // Create an aeroplane factory object
            aeroplaneFactory factory = null;

            // Assign the factory according to the choice entered by user
            if (choice==1)
                factory = new concreteNorthAmericaFactory();
            else if (choice == 2)
                factory = new concreteFokerWulfFactory();

            // Ask for a model according to the user choice.
            new testpilot().askformodel(factory);
        }
    }
}
