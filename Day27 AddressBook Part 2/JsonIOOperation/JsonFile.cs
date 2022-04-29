using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27_AddressBook_Part_2.JsonIOOperation
{
    internal class JsonFile
    {
        /// <summary>
        /// Writing User's Details In JSON Files
        /// </summary>
        /// <param name="path"></param>
        /// <param name="input"></param>
        public static void WriteRecordsInJSONFile(string path, CreatePerson input)
        {
                string jsonData = JsonConvert.SerializeObject(input);                
                File.WriteAllText(path, jsonData);
                Console.WriteLine("\nData added in JSON File Successfully\n");
        }
        /// <summary>
        /// Reading data from JSON Files
        /// </summary>
        /// <param name="path"></param>
        public static void ReadRecordsInJSONFile(string path)
        {
            if (Program.IsFileExists(path))
            {
                StreamReader reader = new StreamReader(path);
                string jsonData = reader.ReadToEnd();
                CreatePerson person = JsonConvert.DeserializeObject<CreatePerson>(jsonData);
                Console.WriteLine(person);
            }
        }
    }
}
