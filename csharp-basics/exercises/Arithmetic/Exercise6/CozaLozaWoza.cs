using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public static class CozaLozaWoza
    {
        public static string Printer(int i)
        {
            if (i % 11 == 0 && i % 3 == 0)
                return "Coza \n";
            else if (i % 11 == 0)
                return $"{i} \n";
            else if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                return "CozaLozaWoza ";
            else if (i % 5 == 0 && i % 7 == 0)
                return "LozaWoza ";
            else if (i % 3 == 0 && i % 7 == 0)
                return "CozaWoza ";
            else if (i % 3 == 0 && i % 5 == 0)
                return "CozaLoza ";
            else if (i % 3 == 0)
                return "Coza ";
            else if (i % 5 == 0)
                return "Loza ";
            else if (i % 7 == 0)
                return "Woza ";
            else
                return $"{i} ";
        }
    }
}
