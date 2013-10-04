#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Web.UI;
#endregion


namespace Assignment_28_Serialization_2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        #region Binary Serialization
        /// <summary>
        /// This is the method created to perform Binary Serialization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void BinarySer(Student[] st)
        {

            string path = "c:\\users\\shweta sharma\\documents\\visual studio 2010\\Projects\\Assignment-28-Serialization-2\\Assignment-28-Serialization-2\\SerializationData\\iCalibrator.dat";

            //Open file in open or create mode
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                //serialization of Object of Student Class to File stream using object of binary formatter
                formatter.Serialize(fs, st);

                Response.Write("Binary Serialization Done");
                for (int i = 0; i < 3; i++)
                    
                    Response.Write("Attributes after Serialization are " + st[i].name + " " + st[i].rollNo + " " + st[i].totalMarks);
            }
            catch (SerializationException exp)
            {
                Response.Write("Failed to serialize. Reason: " + exp.Message);
            }
            finally
            {
                //If Exception occurs close the File Stream Object
                fs.Close();
            }
        }
        #endregion

        #region Binary Deserialization
        /// <summary>
        /// This is the method created to perform Binary Deserialization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void BinaryDeser()
        {
            Student[] st= new Student[3];
            const string path = "c:\\users\\shweta sharma\\documents\\visual studio 2010\\Projects\\Assignment-28-Serialization-2\\Assignment-28-Serialization-2\\SerializationData\\iCalibrator.dat";


            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream(path, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the file stream and assign it to student object.
                st = (Student[])formatter.Deserialize(fs);
                Response.Write("Binary Deserialization Done\n");
                for(int i=0; i<3; i++)
                Response.Write("Attributes after Deserialization are " + st[i].name + " " + st[i].rollNo + " " + st[i].totalMarks);
            }
            catch (SerializationException exp)
            {
                Response.Write("Failed to Deserialize. Reason: " + exp.Message);
            }
            finally
            {
                //If Exception occurs close the File Stream Object
                fs.Close();
                
            }
        }

        #endregion

        #region XML Serialization
        /// <summary>
        /// This is the method created to perform XML Serialization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public  void XMLSerialize(Student[] st)
        {
            string name = "c:\\users\\shweta sharma\\documents\\visual studio 2010\\Projects\\Assignment-28-Serialization-2\\Assignment-28-Serialization-2\\SerializationData\\iCalibrator.xml";
                        
            //Open file in open or create mode
            FileStream fs = new FileStream(name, FileMode.OpenOrCreate);
            try
            {
                //Create the object of XML Serializer to serialize the student object
                XmlSerializer serializer = new XmlSerializer(typeof(Student));

                //Serialize the Student Object to the file Stream
                serializer.Serialize(fs, st);
                fs.Close();
                Response.Write("XML Serialization Done");
                for(int i=0; i<3; i++)
                Response.Write("Attributes after Serialization are " + st[i].name + " " + st[i].rollNo + " " + st[i].totalMarks);
            }

            catch (SerializationException exp)
            {
                Response.Write("Failed to serialize. Reason: " + exp.Message);
            }
            finally
            {
                //If Exception occurs close the File Stream Object
                fs.Close();
            }
        }
        #endregion

        #region XML Deserialization
        /// <summary>
        /// This is the method created to perform XML Deserialization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void XMLDeserialize()
        {

            string name = "c:\\users\\shweta sharma\\documents\\visual studio 2010\\Projects\\Assignment-28-Serialization-2\\Assignment-28-Serialization-2\\SerializationData\\iCalibrator.xml";

            // Create an object of Student to be Deseralized.
            Student[] st = new Student[3];
            FileStream fs = new FileStream(name, FileMode.Open); ;
            try
            {
                //Create the object of XML Serializer to Deserialize the student object
                XmlSerializer serializer = new XmlSerializer(typeof(Student));

                // XML Deserialization of Object of Student Class
                st = (Student[])serializer.Deserialize(fs);
                fs.Close();
                Response.Write("XML Deserialization Done\n");
                for(int i=0; i<3; i++)
                Response.Write("Attributes after Deserialization are " + st[i].name + " " + st[i].rollNo + " " + st[i].totalMarks);
            }

            catch (SerializationException exp)
            {

                Response.Write("Failed to serialize. Reason: " + exp.Message);
            }
            finally
            {
                //If Exception occurs close the File Stream Object
                //Response.Write("XML Deserialization Not Done");
                fs.Close();
            }
        }
        #endregion

        #region SOAP Serialization
        /// <summary>
        /// This is the method created to perform SOAP Serialization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SoapSerialize(Student[] st)
        {
            string name = "c:\\users\\shweta sharma\\documents\\visual studio 2010\\Projects\\Assignment-28-Serialization-2\\Assignment-28-Serialization-2\\SerializationData\\iCalibrator.soap";

            //Open file in open or create mode
            FileStream fs = new FileStream(name, FileMode.OpenOrCreate);
            try
            {
                //Create the object of SOAP Serializer to serialize the student object
                SoapFormatter soap = new SoapFormatter();

                // Serialization of Student Object using SOAP
                soap.Serialize(fs, st);
                fs.Close();
                Response.Write("SOAP Serialization Done");
                for (int i = 0; i < 3; i++)
                    Response.Write("Attributes after Serialization are " + st[i].name + " " + st[i].rollNo + " " + st[i].totalMarks);
            }

            catch (SerializationException ex)
            {
                Response.Write("Failed to serialize. Reason: " + ex.Message);
            }
            finally
            {
                //If Exception occurs close the File Stream Object                
                fs.Close(); 
            }
        }
        #endregion

        #region SOAP Deserialization
        /// <summary>
        /// This is the method created to perform SOAP Deserialization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public  void SoapDeserialize()
        {
            string name = "c:\\users\\shweta sharma\\documents\\visual studio 2010\\Projects\\Assignment-28-Serialization-2\\Assignment-28-Serialization-2\\SerializationData\\iCalibrator.soap";

            // Create an object of Student to be Deseralized.
            Student[] st = new Student[3];

            //Open file in open mode
            FileStream fs = new FileStream(name, FileMode.Open);
            try
            {
                //Create the object of SOAPFormatter to Deserialize the student object
                SoapFormatter soapFormatter = new SoapFormatter();

                // SOAP Deserialization of Object of Student Class
                st = (Student[])soapFormatter.Deserialize(fs);//DeSerialize the stream using soap serializer and return the deserialized object
                fs.Close();
                Response.Write("SOAP Deserialization Done\n");
                for (int i = 0; i < 3; i++)
                    Response.Write("Attributes after Deserialization are " + st[i].name + " " + st[i].rollNo + " " + st[i].totalMarks);
            }
            catch (SerializationException exp)
            {
                Response.Write("Failed to Deserialize. Reason: " + exp.Message);

            }
            finally
            {
                //Response.Write("SOAP Deserialization Not Done");
                fs.Close();
            }
        }
        #endregion

        protected void btn1_Click(object sender, EventArgs e)
        {
            Student[] st = new Student[3];
            st[0] = new Student("Sandeep",1,98);
            st[1] = new Student("Anmol", 2, 75);
            st[2] = new Student("Tarun", 3, 80);
            BinarySer(st);
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            BinaryDeser();
        }

        protected void XMLSer_Click(object sender, EventArgs e)
        {
            Student[] st = new Student[3];
            st[0] = new Student("Sandeep",1,98);
            st[1] = new Student("Anmol", 2, 75);
            st[2] = new Student("Tarun", 3, 80);
            XMLSerialize(st);
        }

        protected void XMLDeserialization_Click(object sender, EventArgs e)
        {
            XMLDeserialize();
        }

        protected void SoapSerialization_Click(object sender, EventArgs e)
        {
            Student[] st = new Student[3];
            st[0] = new Student("Sandeep", 1, 98);
            st[1] = new Student("Anmol", 2, 75);
            st[2] = new Student("Tarun", 3, 80);
            SoapSerialize(st);
        }

        protected void SoapDeSerialization_Click(object sender, EventArgs e)
        {
            SoapDeserialize();
        }

    }
}