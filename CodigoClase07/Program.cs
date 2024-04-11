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
        //No se modifique el primer punto
        //Si se muestre el primer punto

        Rectangulo rectangulo = new Rectangulo(0,0,3,4,5,6,7,8);
        //C#
   
        Console.WriteLine(rectangulo.X1);

        //JAVA
        //rectangulo.SetX1(20);
        //rectangulo.SetX1(1);
        //rectangulo.SetY1(1);
        //Console.WriteLine(rectangulo.GetX1());
        //Console.WriteLine(rectangulo.GetY1());


        //rectangulo.X1 = 20; No se puede 
        rectangulo.X2 = 8;
        rectangulo.Y2 = 0;
        rectangulo.X3 = 8;
        rectangulo.Y3 = 8;
        rectangulo.X4 = 0;
        rectangulo.Y4 = 8;



        Console.WriteLine(rectangulo.X1);
        Console.WriteLine(rectangulo.Y1);
        Console.WriteLine(rectangulo.X2);
        Console.WriteLine(rectangulo.Y2);
        Console.WriteLine(rectangulo.X3);
        Console.WriteLine(rectangulo.Y3);
        Console.WriteLine(rectangulo.X4);
        Console.WriteLine(rectangulo.Y4);

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
