using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase07
{
     static class Helper
    {
        public static double CalcularDistancia(double a1, double b1, double a2, double b2)
        {
            double result;
            result = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            return result;
        }
    }
}
