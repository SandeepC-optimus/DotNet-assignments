using System;
using Model;

public delegate void VoidHandler();

namespace Presenter
{
    public interface SearchStudent
    {
        string Name;
        string Age;
        event VoidHandler Search;
        List<Student> Students;
    }
}
