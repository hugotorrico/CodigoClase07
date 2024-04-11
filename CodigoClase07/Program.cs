using CodigoClase07;
using System;

struct PuntoStruct
{
    public int X;
    public int Y;
}

class PuntoClase
{
    public int X;
    public int Y;
}

class Program
{
    static void Main()
    {
        Triangulo triangulo = new Triangulo
        {
            Punto1 = new Punto(0, 0),
            Punto2 = new Punto(3, 0),
            Punto3 = new Punto(0, 4)
        };

        Console.WriteLine("AREA TRIANGULO");
        Console.WriteLine(triangulo.CalcularArea());



        #region PrimeraForma
        //Constructor por defecto
        Punto punto1 = new Punto(0, 0);
        Punto punto2 = new Punto(8, 0);
        Punto punto3 = new Punto(8, 4);
        Punto punto4 = new Punto(0, 4);
        Rectangulo rectangulo = new Rectangulo( );

        rectangulo.Punto1 = punto1;
        rectangulo.Punto2 = punto2;
        rectangulo.Punto3 = punto3;
        rectangulo.Punto4 = punto4;

        Console.WriteLine("PRIMERA FORMA");
        Console.WriteLine(rectangulo.CalcularArea());
        Console.WriteLine(rectangulo.CalcularPerimetro());
        #endregion


        #region SegundForma

        Punto punto1a = new Punto(0, 0);
        Punto punto2a = new Punto(8, 0);
        Punto punto3a = new Punto(8, 4);
        Punto punto4a = new Punto(0, 4);

        Rectangulo rectanguloa = new Rectangulo(punto1a,punto2a,punto3a,punto4a);
        Console.WriteLine("SEGUNDA FORMA");
        Console.WriteLine(rectanguloa.CalcularArea());
        Console.WriteLine(rectanguloa.CalcularPerimetro());
        #endregion

        #region TerceraForma
        Rectangulo rectangulob = new Rectangulo
        {
            Punto1 = new Punto(0, 0),
            Punto2 = new Punto(8, 0),
            Punto3 = new Punto(8, 4),
            Punto4 = new Punto(0, 4)
        };
        Console.WriteLine("TERCERA FORMA");
        Console.WriteLine(rectanguloa.CalcularArea());
        Console.WriteLine(rectanguloa.CalcularPerimetro());

        #endregion




        Console.Read();



    }

    static void ValorReferencia()
    {
        // Ejemplo con estructura
        PuntoStruct puntoStruct1 = new PuntoStruct();
        puntoStruct1.X = 10;
        puntoStruct1.Y = 20;

        PuntoStruct puntoStruct2 = puntoStruct1; // Se copia por valor
        puntoStruct2.X = 30;

        Console.WriteLine("Estructura:");
        Console.WriteLine("Punto 1: X = " + puntoStruct1.X + ", Y = " + puntoStruct1.Y);
        Console.WriteLine("Punto 2: X = " + puntoStruct2.X + ", Y = " + puntoStruct2.Y);
        Console.WriteLine();

        // Ejemplo con clase
        PuntoClase puntoClase1 = new PuntoClase();
        puntoClase1.X = 10;
        puntoClase1.Y = 20;

        PuntoClase puntoClase2 = puntoClase1; // Se copia la referencia
        puntoClase2.X = 30;

        Console.WriteLine("Clase:");
        Console.WriteLine("Punto 1: X = " + puntoClase1.X + ", Y = " + puntoClase1.Y);
        Console.WriteLine("Punto 2: X = " + puntoClase2.X + ", Y = " + puntoClase2.Y);
    }
}
