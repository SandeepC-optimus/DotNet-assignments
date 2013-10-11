#region Name Space
using System;

#endregion

namespace SingletonDesignPattern
{
    /// <summary>
    /// This is the Class Created to Use the Functionalities of Singleton Design Pattern
    /// </summary>
    public class Singleton
    {
        // This is to make sure that there is only one instance of Singleton Class
        private static Singleton _instance = null;

        // Private members of Singleton Class
        private string _name { get; set; }
        private int _age { get; set; }

        /// <summary>
        /// Default constructor of Singleton Class
        /// </summary>
        private Singleton()   
        {
            Console.WriteLine("Singleton Instance");
            _name = "Sandeep";
            _age = 23;
        }

        // Lock synchronization object
        private static readonly object SyncLock = new object();

        // Property of exposing _instance to use the methods Singleton Class
        public static Singleton Instance
        {
            get
            {
                lock (SyncLock)
                {
                    return Singleton._instance ?? (Singleton._instance = new Singleton());
                }
            }
        }

        /// <summary>
        /// This is the public non static method of Singleton Class.
        /// This method which displays the non static private member of class
        /// </summary>
        public void Show()
        {
            Console.WriteLine("Information is : Name={0} & Age={1}",  _name, _age);
        }
    }
}
