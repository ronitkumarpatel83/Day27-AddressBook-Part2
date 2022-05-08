using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day27_AddressBook_Part_2.CSVIOOperation;
using Day27_AddressBook_Part_2.FileIO;
using Day27_AddressBook_Part_2.JsonIOOperation;

namespace Day27_AddressBook_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\Ronit\source\repos\Day27 AddressBook Part 2\Day27 AddressBook Part 2\MyFile\TextFile1.txt";
            // string path = @"C:\Users\Ronit\source\repos\Day27 AddressBook Part 2\Day27 AddressBook Part 2\MyFile\CSVFile.csv";
            string path = @"C:\Users\Ronit\source\repos\Day27 AddressBook Part 2\Day27 AddressBook Part 2\MyFile\FileJson.json";

            //CreatePerson input = new CreatePerson();
            //Getting details from user
            //Console.WriteLine("\nEnter your First Name : ");
            //input.fName = Console.ReadLine();
            //Console.WriteLine("Enter your Last Name : ");
            //input.lName = Console.ReadLine();
            //Console.WriteLine("Enter your Address : ");
            //input.address = Console.ReadLine();
            //Console.WriteLine("Enter your City Name : ");
            //input.city = Console.ReadLine();
            //Console.WriteLine("Enter your State Name : ");
            //input.state = Console.ReadLine();
            //Console.WriteLine("Enter your Zip Code : ");
            //input.zip = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your Phone Number : ");
            //input.phoneNumber = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("Enter your Email Address: ");
            //input.email = Console.ReadLine();

            //FileIOperation.WriteRecordsInFile(path, input); // Writing records into file
            //Console.WriteLine("\n<<<<<<<<<<<< Records >>>>>>>>>>>>>>");
            //FileIOperation.ReadRecordsFromFile(path); // Reading all records from file 
            //Console.ReadLine();

            //CSVOperations.WriteRecordsInCSVFile(path, input);
            //Console.WriteLine("\n\nRecords present in CSV file are : \n");
            //CSVOperations.ReadRecordsInCSVFile(path);
            //Console.ReadLine();

            //Read and Write Operation in JSON Files
            //JsonFile.WriteRecordsInJSONFile(path, input);
            //JsonFile.ReadRecordsInJSONFile(path);
            //Console.ReadLine();

            //<<<<<<<<<<<<<<<<<<<<<< SQL DATABASE>>>>>>>>>>>>>>>>>>>>>>>>>>
            Console.WriteLine("Welcome to Addressbook ADO.NET");

            CreatePerson create = new CreatePerson();
            //create.First_Name = "Ritu";
            //create.Last_Name = "Patel";
            //create.Phone = 1236547890;
            create.First_Name = "Sabitri";
            create.Last_Name = "Patel";
            create.Address = "KLB";
            create.Type = "Family";
            create.City = "SBD";
            create.State = "Telengana";
            create.Email = "sabitri@gmail.com";
            create.Zip = 456987;
            create.Phone = 7854632165;
            AddressBookRepository book = new AddressBookRepository();
            book.AddressBookSystem();
           // book.UpdateContactInformation(create);
           book.AddContact(create);
            Console.ReadLine();


        }
        /// <summary>
        /// Checking that File is Present or not
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool IsFileExists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                Console.WriteLine("File Not Found");
                return false;
            }
        }
    }

}
