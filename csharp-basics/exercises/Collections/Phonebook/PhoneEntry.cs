using System;
using System.Collections.Specialized;

namespace PhoneBook
{
    public class PhoneEntry
    {
        public string name;
        public string number;

        public PhoneEntry(string name, string number)
        { 
            this.number = number;
            this.name = name;
        }
    }
}