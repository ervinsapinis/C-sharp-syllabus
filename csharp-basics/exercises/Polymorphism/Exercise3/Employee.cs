using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Employee : Person
    {
        private string _jobTitle;

        public Employee(string jobTitle)
        {
            _jobTitle = jobTitle;
        }

        public string JobTitle
        {
            get => _jobTitle;
            set => _jobTitle = value;
        }

        public override void Dispay()
        {
            Console.WriteLine($"First Name: {FirstName} \n Last Name: {LastName} \n Address: {Address} \n ID#: {ID} \n Profession: {JobTitle}");
        }
    }
}
