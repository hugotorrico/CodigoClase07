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
        public Rectangulo()
        {

        }

        public Rectangulo(Punto punto1, Punto punto2, Punto punto3, Punto punto4)
        {
            Punto1 = punto1;
            Punto2 = punto2;
            Punto3 = punto3;
            Punto4 = punto4;
        }

        #endregion
        #region FuncionesPrivadas
       
        private double ObtenerAltura()
        {
            double result;        
            result = Helper.CalcularDistancia(Punto1.X, Punto1.Y, Punto2.X, Punto2.Y);
            return result;
        }
        private double ObtenerBase()
        {
            double result;
          
            result = Helper.CalcularDistancia(Punto2.X, Punto2.Y, Punto3.X, Punto3.Y);
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
