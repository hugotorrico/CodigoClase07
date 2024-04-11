using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase07
{   

     //Clases y Entidades son los mismo!
     class Rectangulo
    {
        #region  Propiedades

        //Propiedades de Navegación: Propiedades que son de tipo objeto
        public Punto Punto1 { get; set; }
        public Punto Punto2 { get; set; }
        public Punto Punto3 { get; set; }
        public Punto Punto4 { get; set; }
       




        #endregion
        #region FuncionesPrivadas

        private double CalcularDistancia(double a1, double b1, double a2, double b2)
        {
            double result;
            result = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            return result;

        }
        private double ObtenerAltura()
        {
            double result;
            result = CalcularDistancia(Punto1.X, Punto1.Y, Punto2.X, Punto2.Y);
            return result;
        }
        private double ObtenerBase()
        {
            double result;
            result = CalcularDistancia(Punto2.X, Punto2.Y, Punto3.X, Punto3.Y);
            return result;
        }

        #endregion

        #region FuncionesPublicas

        public double CalcularArea()
        {
            double result;
            result = ObtenerBase() * ObtenerAltura();
            return result;
        }

        public double CalcularPerimetro()
        {
            double result;
            result = (ObtenerBase() + ObtenerAltura()) * 2;
            return result;
        }
        #endregion



    }
}
