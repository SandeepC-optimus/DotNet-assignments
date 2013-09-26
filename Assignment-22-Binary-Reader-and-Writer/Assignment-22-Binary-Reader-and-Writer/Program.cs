///////////////////////////////////////////////////////////////////////////////////////////////////
//// Create a binary file and add some data (int, string, char etc.) to it using Binary Writer. 
//// Read the contents back from the file using the BinaryReader and display on console. 
//// Handles all the exceptions esp. I/O exceptions.
///////////////////////////////////////////////////////////////////////////////////////////////////



#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#endregion
namespace Assignment_22_Binary_Reader_and_Writer
{
    /// <summary>
    /// This is the class created to Implement Binary reader and Binary Writer Classes.
    /// </summary>
    class TestBinary
    {
        /// <summary>
        /// This is the main method where all the execution takes place.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BinaryWriter bw;
            BinaryReader br;
            int i = 25;
            double d = 3.14157;
            Char c='x';
            bool b = true;
            string s = "Hello All";



            //create the file
            try
            {
                bw = new BinaryWriter(new FileStream("BinaryTest",
				FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }



            //writing into the file
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(c);
                bw.Write(s);

                Console.WriteLine("Data is written in Binary File");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }

            bw.Close();
            
            
            
            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream("BinaryTest",
				FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
            }
            try
            {
                Console.WriteLine("\n Reading Data from Binary File \n");
                i = br.ReadInt32();
                Console.WriteLine("Integer data: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                c = br.ReadChar();
                Console.WriteLine("Character data: {0}", c);
                s = br.ReadString();
                Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            br.Close();
            Console.ReadKey();
        }
    }
}
