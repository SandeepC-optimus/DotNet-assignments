/////////////////////////////////////////////////////////////////////////////////////////////////////
//// This is the Namespace implemented to perform various file handling processes.
//// Using DriveInfo class properties to display attributes of C drive.
//// Using DirectoryInfo and File classes, display newly created directory and files attribute. 
//// Display Directory Path using path class
//// Using file security class set the access control of file FileRead to be read only 
//// Read the contents of FileRead and write it on FileWrite.
//// Compress FileWrite using GZip compression an save it with a name FileWriteZip
//// Name the project as ‘FileHandling’ and Namespace as ‘DirectoriesAndFiles’
//////////////////////////////////////////////////////////////////////////////////////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Security.AccessControl; 
#endregion

namespace DirectoriesAndFiles
{
    /// <summary>
    ///  This is the Class implemented to test various file handling processes
    /// </summary>
    class TestFileHandling
    {
        /// <summary>
        /// This is the main Method to execute the operation performed on files
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            string path1 = @"c:\assignment";
            String fileName1 = "FileWrite.txt";
            String fileName2 = "FileRead.txt";
            string pathString1 = Path.Combine(path1, fileName1);
            string pathString2 = Path.Combine(path1, fileName2);



            // Create Directory
            Directory.CreateDirectory(path1);



            // Create Files
            if (!File.Exists(pathString1))
            {
                FileStream fs1 = File.Create(pathString1);

            }

            if (!File.Exists(pathString2))
            {
                FileStream fs2 = File.Create(pathString2);
            }





            //Fetching Drive Information and Attributes
            DirectoryInfo info = new DirectoryInfo("c:\\");
            Console.WriteLine(info.Attributes.ToString());

            DirectoryInfo infoNewDirectory1 = new DirectoryInfo(path1);
            Console.WriteLine(infoNewDirectory1.Attributes.ToString());


            DirectoryInfo infoNewFile1 = new DirectoryInfo(pathString1);
            Console.WriteLine(infoNewFile1.Attributes.ToString());


            DirectoryInfo infoNewFile2 = new DirectoryInfo(pathString2);
            Console.WriteLine(infoNewFile2.Attributes.ToString());

            Console.ReadKey();







            // Get Full Path
            Console.WriteLine(Path.GetFullPath(path1));

            Console.ReadKey();








            // File Security is set and the file access mode is set to read only.

           // FileSecurity fs3 = new FileSecurity();
            //FileSystemAccessRule rule = new FileSystemAccessRule(pathString2, FileSystemRights..ReadData, AccessControlType.Allow);
            //AccessControlModification am= new AccessControlModification();







            // Copy the content of File FileRead to FileWrite

            string str;

            StreamReader Reader = new StreamReader(pathString2);
           
            str = Reader.ReadToEnd();
           
            Reader.Close();
            StreamWriter Writer = new StreamWriter(pathString1);
            Writer.WriteLine(str);
            Writer.Flush();
            Writer.Close();






            //Compress the file into zip using gzip
            DirectoryInfo directorySelected = new DirectoryInfo(path1);

            foreach (FileInfo fileToCompress in directorySelected.GetFiles("FileRead.txt"))
            {
                using (FileStream originalFileStream = fileToCompress.OpenRead())
                {
                    if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
                    {
                        using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
                        {
                            using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                            {
                                originalFileStream.CopyTo(compressionStream);
                                Console.WriteLine("Compressed {0} from {1} to {2} bytes.", fileToCompress.Name, fileToCompress.Length.ToString(), compressedFileStream.Length.ToString());
                            }
                        }
                    }
                }
            }

            Console.ReadKey();





        }
    }
}