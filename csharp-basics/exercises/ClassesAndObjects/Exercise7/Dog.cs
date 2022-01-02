using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Dog
    {
        //fields
        private string _name;
        private string _sex;
        private Dog _motherDog;
        private Dog _fatherDog;

        //ctor
        public Dog(string name, string sex, Dog motherDog, Dog fatherDog)
        {
            _name = name;
            _sex = sex;
            _motherDog = motherDog;
            _fatherDog = fatherDog;
        }
        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
            _motherDog = null;
            _fatherDog = null;
        }
        //properties
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Sex
        {
            get => _sex;
            set => _sex = value;
        }

        public Dog MotherDog
        {
            get => _motherDog;
            set => _motherDog = value;
        }

        public Dog FatherDog
        {
            get => _fatherDog;
            set => _fatherDog = value;
        }

        //methods
        public string FathersName()
        {
            if (FatherDog == null)
                return "Unknown";
            else
                return $"{FatherDog.Name}";
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            if (otherDog.MotherDog == this.MotherDog) return true;
            else return false;
        }
    }
}
