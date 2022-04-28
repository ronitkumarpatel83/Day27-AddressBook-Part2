using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27_AddressBook_Part_2
{
    public class CreatePerson
    {
        // Declaring class variable to get the all the details from user
        public string fName { get; set; }
        public string lName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string email { get; set; }
        public int zip { get; set; }
        public long phoneNumber { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"First Name : {fName}\nLast Name : {lName}\nAddress : {address}\nCity : {city}\nState : {state}\nEmail : {email}\nZip Code : {zip}\nPhone Number : {phoneNumber}";
        }
    }
    
}
