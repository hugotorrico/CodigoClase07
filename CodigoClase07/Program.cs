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


        #region PrimeraForma
        Punto punto1 = new Punto(0, 0);
        Punto punto2 = new Punto(8, 0);
        Punto punto3 = new Punto(8, 4);
        Punto punto4 = new Punto(0, 4);
        Rectangulo rectangulo = new Rectangulo( );

        rectangulo.Punto1 = punto1;
        rectangulo.Punto2 = punto2;
        rectangulo.Punto3 = punto3;
        rectangulo.Punto4 = punto4;


        Console.WriteLine(rectangulo.CalcularArea());
        Console.WriteLine(rectangulo.CalcularPerimetro());
        #endregion

        //Rectangulo rectangulo = new Rectangulo(punto1, punto2, punto3, punto4);



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
