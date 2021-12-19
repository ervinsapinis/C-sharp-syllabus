using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory mydiDirectory = new PhoneDirectory();


            mydiDirectory.AddEntry("Janis Choplin", "654-234-4956");
            mydiDirectory.AddEntry("Humphrey Humphrey", "345-754-3456");
            mydiDirectory.AddEntry("Ahmed Attalay", "764-867-4956");
            mydiDirectory.AddEntry("Phil Biggs", "906-346-4956");
            mydiDirectory.AddEntry("Ann Damsel", "667-234-4956");

        }
    }
}
