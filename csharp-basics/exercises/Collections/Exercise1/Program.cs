using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            var carList = array.ToList();
            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }
            var carHashtable = array.ToHashSet();
            foreach (var car in carHashtable)
            {
                Console.WriteLine(car);
            }

            var carDictionary = new Dictionary<string, string>();
            var distinctArr = array.Distinct().ToArray();
            for (int i = 0; i < distinctArr.Length; i++)
            {
                carDictionary.Add(distinctArr[i], CarCountry(distinctArr[i]));
            }

            foreach (var car in carDictionary)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();

        }

        public static string CarCountry(string car)
        {
            string country;
            if(car == "Tesla")
                return country = "USA";
            else if (car == "Honda")
                return country = "Japan";
            else
                return country = "Germany";
        }
    }
}
