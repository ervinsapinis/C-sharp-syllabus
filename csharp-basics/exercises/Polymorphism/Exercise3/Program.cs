using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var john = new Employee("Smith");
            var poraclys = new Student(3.54);

            john.FirstName = "John";
            john.LastName = "Habbadist";
            john.Address = "Lower street of Bag End";
            john.ID = 0506391989;

            poraclys.FirstName = "Poraclys";
            poraclys.LastName = "Varagos";
            poraclys.Address = "Lower eastern coast, fishing village of Phasos";
            poraclys.ID = 556671263;

            john.Dispay();
            poraclys.Dispay();
        }
    }
}
