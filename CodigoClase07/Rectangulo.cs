using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase07
{   
     class Rectangulo
    {
        #region  Propiedades/ Getter and Setter/ Get Set      
        public double sueldo;//Variable

        public double X1 { get;  }//Propiedades
        public double Y1 { get; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }
        public double X4 { get; set; }
        public double Y4 { get; set; }
        public string color { get; set; }

        //private double X1;
        //public double GetX1()
        //{
        //    return X1;
        //}

        //public void SetX1(double X1)
        //{
        //    this.X1 = X1;
        //}

        //private double Y1;
        //public double GetY1()
        //{
        //    return Y1;
        //}

        //public void SetY1(double Y1)
        //{
        //    this.Y1 = Y1;
        //}


        //Constructor
        public Rectangulo(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {

            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            X4 = x4;
            Y4 = y4;

        }

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
            result = CalcularDistancia(X1, Y1, X2, Y2);
            return result;
        }
        private double ObtenerBase()
        {
            double result;
            result = CalcularDistancia(X2, Y2, X3, Y3);
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
