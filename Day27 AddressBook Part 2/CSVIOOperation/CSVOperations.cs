using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Day27_AddressBook_Part_2.CSVIOOperation
{
    internal class CSVOperations
    {
        /// <summary>
        /// Writing user's details in CSV File
        /// </summary>
        /// <param name="path"></param>
        /// <param name="input"></param>
        public static void WriteRecordsInCSVFile(string path, CreatePerson input)
        {
            if (Program.IsFileExists(path))
            {
                List<CreatePerson> list = new List<CreatePerson>();
                list.Add(input);
                StreamWriter stream = new StreamWriter(path);
                CsvWriter csv = new CsvWriter(stream, CultureInfo.InvariantCulture);
                csv.WriteRecords<CreatePerson>(list);
                stream.Flush();
            }
        }
        /// <summary>
        /// User's Details from CSV Files
        /// </summary>
        /// <param name="path"></param>
        public static void ReadRecordsInCSVFile(string path)
        {
            if (Program.IsFileExists(path))
            {
                StreamReader stream = new StreamReader(path);
                CsvReader csv = new CsvReader(stream, CultureInfo.InvariantCulture);
                List<CreatePerson> list = csv.GetRecords<CreatePerson>().ToList();
                foreach (CreatePerson record in list)
                {
                    Console.WriteLine(record);
                }
            }
        }
    }
}
