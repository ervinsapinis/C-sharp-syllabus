using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public SortedDictionary<string, string> PhoneEntryDictionary;

        public PhoneDirectory()
        {
            PhoneEntryDictionary = new SortedDictionary<string, string>();
        }

        public string FindNumber(string number)
        {
            for (int i = 0; i < PhoneEntryDictionary.Count; i++)
            {
                if (PhoneEntryDictionary.ContainsValue(number))
                {
                    var index = PhoneEntryDictionary.FirstOrDefault(val => val.Value == number).Key;
                    return $"The number {number} is under the name {index}";
                }
            }
            return "No such number was found in the Phonebook";
        }

        public string FindName(string name)
        {
            for (int i = 0; i < PhoneEntryDictionary.Count; i++)
            {
                if (PhoneEntryDictionary.ContainsKey(name))
                {
                    var index = PhoneEntryDictionary[name];
                    return $"The name {name} is under the Phonebook entry {index}";
                }
            }
            return "No such name was found in the Phonebook";
        }

        public void AddEntry(string name, string number)
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }
            PhoneEntryDictionary.Add(name, number);
        }
    }
}