using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Student : Person
    {
        private double _gpa;

        public Student(double gpa)
        {
            _gpa = gpa;
        }

        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }

        public override void Dispay()
        {
            Console.WriteLine($"First Name: {FirstName} \n Last Name: {LastName} \n Address: {Address} \n ID#: {ID} \n GPA: {Math.Round(Gpa, 2)}");
        }
    }
}
