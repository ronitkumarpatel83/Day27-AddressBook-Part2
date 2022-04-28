using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27_AddressBook_Part_2.FileIO
{
    public class FileIOperation
    {
        /// <summary>
        /// Write all the details in File
        /// </summary>
        public static void WriteRecordsInFile(string path, CreatePerson person)
        {

            if (File.Exists(path))
            {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine("\nFirst Name : " + person.fName);
                sw.WriteLine("Last Name : " + person.lName);
                sw.WriteLine("Address : " + person.address);
                sw.WriteLine("City : " + person.city);
                sw.WriteLine("State : " + person.state);
                sw.WriteLine("Email : " + person.email);
                sw.WriteLine("Zip code : " + person.zip);
                sw.WriteLine();
                sw.Close();
                Console.WriteLine("\nDeatils added successfully");
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
        }
        /// <summary>
        /// Read all records from which are present in Files
        /// </summary>
        public static void ReadRecordsFromFile(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
        }
    }
}
