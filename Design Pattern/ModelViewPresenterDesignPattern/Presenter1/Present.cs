///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the name space containing a Class Student Present which Process the data attributes from model to display it to view layer.
//// Here it represents a part of Presenter layer of Model View Presenter design pattern.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Name Space
using System;
using Model1;
using Operations1;
using System.Collections.Generic; 
#endregion

namespace Presenter1
{
    /// <summary>
    /// This is the Class Which Takes user request check for its validation and then request it from Model
    /// </summary>
    public class StudentPresent
    {
        // Read only object of Interface Search Student
        readonly SearchStudent _table;

        /// <summary>
        /// Constructor which takes the object of Search student interface as Argument and takes the search query of  User
        /// </summary>
        /// <param name="searchValue"></param>
        public StudentPresent(SearchStudent searchValue) 
        {
            searchValue.Search += new VoidHandler(search);
            _table = searchValue;
        }

        /// <summary>
        /// This Method sends the Search query to Model and gets the list of students satisfying the search criteria
        /// </summary>
        private void search()
        {
            List<Student> students = Operations1.Operation.GetStudent(_table.Name);
            _table.Students = students;
        }
    }
}
