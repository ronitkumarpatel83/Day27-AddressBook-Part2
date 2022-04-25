using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day27_AddressBook_Part_2.FileIO;

namespace Day27_AddressBook_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ronit\source\repos\Day27 AddressBook Part 2\Day27 AddressBook Part 2\MyFile\TextFile1.txt";

            CreatePerson input = new CreatePerson();
            //Getting details from user
            Console.WriteLine("\nEnter your First Name : ");
            input.fName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            input.lName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            input.address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            input.city = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            input.state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            input.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            input.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            input.email = Console.ReadLine();

            FileIOperation.WriteRecordsInFile(path, input); // Writing records into file
            Console.WriteLine("\n\nRecords present in file are : ");
            FileIOperation.ReadRecordsFromFile(path); // Reading all records from file 
            Console.ReadLine();
        }
    }
}
