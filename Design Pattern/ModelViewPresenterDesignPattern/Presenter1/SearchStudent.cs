///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the name space containing an Interface which represents a part of Presenter layer of Model View Presenter design pattern.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


#region Name space
using System;
using Model1;
using System.Collections.Generic; 
#endregion

// This is a function pointer which handle the void result from a search
public delegate void VoidHandler();
namespace Presenter1
{
    /// <summary>
    /// This is an Interface Search Student which lets the derived class Implements these properties.
    /// </summary>
    public interface SearchStudent
    {
        string Name { get; }        
        event VoidHandler Search;
        List<Student> Students {set;}
    }
}
