////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the Name space which implements the concept of Adapter Design Pattern and Test it by taking an example of Shape Class.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Name Space
using System; 
#endregion

namespace AdapterDesignPattern
{
    /// <summary>
    /// This is the Class Shape which draws the pattern requested by user
    /// </summary>
    class Shape
    {
        /// <summary>
        /// This is the virtual method draw whose definition is mandatory for all the class inheriting its properties
        /// </summary>
        public virtual void Draw()
        {
        }
    }

    /// <summary>
    /// This is the Class TextView which stores the text pattern requested by user
    /// </summary>
    class TextView
    {
        private string _text;
        public string Text
        {
            get
            {
                return this._text;
            }

            set
            {
                this._text=value;
            }
        }
        /// <summary>
        /// This Method Displays the text pattern asked by user
        /// </summary>
        public void DisplayText()
        {
            Console.WriteLine(_text);
        }
    }

    /// <summary>
    /// This is the class text shape which draws the text shape requested by user
    /// </summary>
    class TextShape: Shape
    {
        private TextView Text;
        /// <summary>
        /// It is the parameterized constructor which takes object of class text view as argument
        /// </summary>
        /// <param name="T"></param>
        public TextShape(TextView T)
        {
        this.Text = T;
        }

        /// <summary>
        /// This is the virtual method of base class over-ridden in derived class.
        /// This method draws the text shape requested by user
        /// </summary>
        public override void Draw()
        {
        this.Text.DisplayText();
        }
    }
}
