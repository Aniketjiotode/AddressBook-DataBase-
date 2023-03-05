using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_System
{
    public class Contact
    {
       public string FirstName;
       public string LastName;
       public string Address;
       public string City;
       public int ZipCode;
       public int PhoneNumber;
       public string State;
       public string Email;

        public override string ToString()
        {
            var st = $"FirstName: {FirstName}\nLastName: {LastName}\nAddress: {Address}\nCity: {City}\nState: {State}\nZipcode: {ZipCode}\nEmail: {Email}\nPhoneNumber: {PhoneNumber}  \n-----------------\n";
            return st;
        }
    }
}
