///////////////////////////////////////////////////////////////////////////////////////////////////////
////Make a web form with a textbox and a button. 
////In Textbox ask user to enter the path of the specified folder. And on clicking ‘Delete’ 
////button first check if the size of file in folder is greater than 100 bytes delete it else 
////append a line to each file ‘Size less than 100 bytes’. 
////Send a mail to user containing name of files that are deleted. 
////Subject line should be ‘Deleted Files’.
////Body should contain name of the files deleted. 
////Folder should have at least 4 files with two greater than 100 bytes in size.
///////////////////////////////////////////////////////////////////////////////////////////////////////

#region Namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.IO;
using System.IO.Compression;

#endregion
namespace WebApplication4
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = TextBox1.Text;
            
            // Creating the object of DirectoryInfo
            DirectoryInfo info = new DirectoryInfo(path);
            
            string body = " ";
            
            // Creating an object to send email
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("chawlasandip88@gmail.com");
            mail.To.Add("chawlasandip88@gmail.com");
            mail.Subject = "Deleted Files";
            
            SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential("chawlasandip88@gmail.com", "rocking@007");
            SmtpServer.EnableSsl = true;

            // add all the files as attachment whose size is less than 100 bytes
            foreach (FileInfo file in info.GetFiles())
            {
                if (file.Length >= 100)
                {
                    Attachment attachment = new Attachment(file.FullName);
                    mail.Attachments.Add(attachment);
                    body = body + "  " + file.Name;

                }
            }

            // Sending e-mail
            mail.Body = body;
            SmtpServer.Send(mail);
            mail.Dispose();

            // Deleting all the files whose size is less than 100 bytes
            foreach (FileInfo file in info.GetFiles())
            {
                if (file.Length >= 100)
                {
                    
                    file.Delete();
                }
                else
                {
                    using (StreamWriter sw = file.AppendText())
                    {
                        sw.WriteLine("Size less than 100 bytes");
                    }
                }
                



            }
        }
    }
}
