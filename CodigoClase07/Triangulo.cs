using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase07
{
     class Triangulo
    {
        public Punto Punto1 { get; set; }
        public Punto Punto2 { get; set; }
        public Punto Punto3 { get; set; }

      

        private double ObtenerBase()
        {
            double result;
            result = Helper.CalcularDistancia(Punto1.X, Punto1.Y, Punto2.X, Punto2.Y);
            return result;
        }
        private double ObtenerAltura()
        {
            double result;
            result = Helper.CalcularDistancia(Punto1.X, Punto1.Y, Punto3.X, Punto3.Y);
            return result;
        }

        public double CalcularArea()
        {
            double result;
            result = (ObtenerBase() * ObtenerAltura())/2;
            return result;
        }
    }
}
