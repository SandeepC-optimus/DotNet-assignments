///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the name space containing a Class Student which over here acts as the Model containing the The Database.
//// Here it represents a Model layer of Model View Presenter design pattern.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Name Space
using System; 
#endregion

namespace Model1
{
    /// <summary>
    /// This is the Class Student which keeps the basic data of a student.
    /// </summary>
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
