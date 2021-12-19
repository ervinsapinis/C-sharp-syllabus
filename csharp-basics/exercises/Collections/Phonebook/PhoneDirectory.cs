using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public SortedDictionary<string, string> PhoneEntryDictionary = new SortedDictionary<string, string>();

        public string Find(string number)
        {
            for (int i = 0; i < PhoneEntryDictionary.Count; i++)
            {
                if (PhoneEntryDictionary.ContainsValue(number))
                {
                    var index = PhoneEntryDictionary[number];
                    return $"The number {number} is under the name {index}";
                }
            }
            return "No such number was found in the Phonebook";
        }

        public string GetNumber(string name)
        {
            for (int i = 0; i < PhoneEntryDictionary.Count; i++)
            {
                if (PhoneEntryDictionary.ContainsValue(name))
                {
                    var index = PhoneEntryDictionary[name];
                    return $"The name {name} is under the Phonebook entry {index}";
                }
            }
            return "No such name was found in the Phonebook";
        }

        public void AddEntry(string name, string number) //es nezinu, vai te bija japielieto PhoneEntry klase, pagaidam darîts ðâdi.
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }
            PhoneEntryDictionary.Add(name, number);
        }
    }
}