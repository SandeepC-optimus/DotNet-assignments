using System;
using Model;

namespace Presenter
{
    public class StudentPresent
    {
        readonly SearchStudent _table;
        public StudentPresent(SearchStudent searchValue) 
        {
            searchValue.Search += new VoidHandler(search);
            _table = searchValue;
        }
        private void search()
        {
            List<Student> students = Operations.Operation.GetStudent(_table.Name);
            _table.Students = students;
        }
    }
}
