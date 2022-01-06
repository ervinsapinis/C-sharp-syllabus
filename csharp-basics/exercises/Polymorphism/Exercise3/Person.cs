using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Person
    {
        //fields
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        //ctor
        public Person()
        {

        }
        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        //properties
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public int ID
        {
            get => _id;
            set => _id = value;
        }

        //methods
        public virtual void Dispay()
        {
            Console.WriteLine($"First Name: {FirstName} \n Last Name: {LastName} \n Address: {Address} \n ID#: {ID}");
        }
    }
}
