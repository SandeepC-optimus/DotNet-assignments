////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the Name space which implements the concept of Adapter Design Pattern and Test it by taking an example of Shape Class.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


#region Name space
using System; 
#endregion

namespace AdapterDesignPattern
{
    /// <summary>
    /// This is the class created to Test the Adapter Design Pattern using class shape
    /// </summary>
    class Implementation
    {
        /// <summary>
        /// This is the method which Interacts with end user and responds according to adapter design pattern
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Create an object of class Text View
            TextView View = new TextView();

            // Assign Some Text Value
            View.Text = "Hello Test";

            // Now Shape Class acts as adapter which Draws the Text from TextView Class which is Adaptee
            TextShape Shape = new TextShape(View);
            Shape.Draw();

            Console.ReadKey();
        }

    }
}
