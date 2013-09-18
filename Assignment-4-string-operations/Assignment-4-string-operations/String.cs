//////////////////////
// This is Assignment-4 Covering the concepts and various Methods of String class
//////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
#endregion

namespace Assignment_4_string_operations
{
    /// <summary>
    /// This is the class created to test the working of String class methods
    /// </summary>
    class TestStrings
    {
        /// <summary>
        /// This is the Main() Method, responsible for the execution of the Program.
        /// </summary>
        /// <param name="args"></param>
        #region Main Function
        static void Main(string[] args)
        {
            #region String Class Methods
            // Declaring Variables
            string text, str;

            // Input a string from user to perform operations
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            text = str;

            // Compare 2 Strings using String Function Compare
            Console.WriteLine("\nCompare 2 Strings using String Function Compare\n");
            Console.WriteLine(text.CompareTo(str));

            //Check for a Sub-String in a String using String Function Contains
            Console.WriteLine("\nCheck for a Sub-String in a String using String Function Contains\n");
            Console.WriteLine(text.Contains("and"));

            //Check for a ending character of a String using String Function EndsWith
            Console.WriteLine("\nCheck for a ending character of a String using String Function EndsWith\n");
            Console.WriteLine(text.EndsWith("d"));

            //Check if string 1 is equals to string 2 using String Function Equals
            Console.WriteLine("\nCheck if string 1 is equals to string 2 using String Function Equals\n");
            Console.WriteLine(text.Equals(str));

            //fetch the Hash Code of string using String Function GetHashCode
            Console.WriteLine("\nfetch the Hash Code of string using String Function GetHashCode\n");
            Console.WriteLine(text.GetHashCode());

            //fetch the Type of string using String Function GetType
            Console.WriteLine("\nfetch the Type of string using String Function GetType\n");
            Console.WriteLine(text.GetType());

            //fetch the Type of string using String Function GetTypeCode
            Console.WriteLine("\nfetch the Type of string using String Function GetTypeCode\n");
            Console.WriteLine(text.GetTypeCode());

            //fetch the First Index Position of string using String Function IndexOf
            Console.WriteLine("\nfetch the First Index Position of string using String Function IndexOf\n");
            Console.WriteLine(text.IndexOf('a'));

            //fetch the string in lower case using String Function ToLower
            Console.WriteLine("\nfetch the string in lower case using String Function ToLower\n");
            Console.WriteLine(text.ToLower());

            //fetch the string in upper case using String Function ToUpper
            Console.WriteLine("\nfetch the string in upper case using String Function ToUpper\n");
            Console.WriteLine(text.ToUpper());

            //Insert the sub string at a particular index into a string using String Function Insert
            Console.WriteLine("\nInsert the sub string at a particular index into a string using String Function Insert\n");
            Console.WriteLine(text.Insert(0, "an"));

            //fetch the Last Index Position of string using String Function LastIndexOf
            Console.WriteLine("\nfetch the Last Index Position of string using String Function LastIndexOf\n");
            Console.WriteLine(text.LastIndexOf('a'));

            //Fetch the length of a string using String Function Length
            Console.WriteLine("\nFetch the length of a string using String Function Length\n");
            Console.WriteLine(text.Length);

            //Deletes all the characters from begining to specified index using String Function Remove
            Console.WriteLine("\nDeletes all the characters from begining to specified index using String Function Remove\n");
            Console.WriteLine(text.Remove(10));

            //Replace the character in a string using String Function Replace
            Console.WriteLine("\nReplace the character in a string using String Function Replace\n");
            Console.WriteLine(text.Replace('a', '&'));

            //checks wether the starting character in a string is same as a particular sub string using String Function StartWith
            Console.WriteLine("\nchecks wether the starting character in a string is same as a particular sub string using String Function StartWith\n");
            Console.WriteLine(text.StartsWith("s"));

            //fetch the sub string from a string using String Function Substring
            Console.WriteLine("\nfetch the sub string from a string using String Function Substring\n");
            Console.WriteLine(text.Substring(5, 10));

            //Trims the white spaces from a string using String Function Trim
            Console.WriteLine("\nTrims the white spaces from a string using String Function Trim\n");
            Console.WriteLine(text.Trim());

            //Converts the string to char Array using String Function Replace
            Console.WriteLine("\nConverts the string to char Array using String Function Replace\n");
            Console.WriteLine(text.ToCharArray());
            #endregion


            Console.ReadKey();
        } 
        #endregion
    }
}
