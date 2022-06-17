using System;

namespace DistanciaEntreDosPuntos
{
    //Programa que calcula la distancia entre dos punto
    //de una linea recta
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Distancia entre dos puntos");
            Console.WriteLine("Distancia entre dos puntos");
            Console.WriteLine("Autor: Kenet Ortiz");

            //Declaracion de Variables
            double x1, y1, x2, y2, distancia;
            string unidades;

            //Descripcion del programa.
            Console.WriteLine("\nBienvenido al programa para calcular distancias entre dos puntos.");
            Console.WriteLine("\nA continuacion se le solicitaran los datos para realizar la operacion.");

            //Entrada de datos
            Console.WriteLine("\nIngrese la unidad con la que usted desea trabajar, ml, cm, m, etc");
            unidades = Console.ReadLine();

            Console.WriteLine("\nIngrese el valor de x1");
            x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese el valor de y1");
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese el valor de x2");
            x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese el valor de y2");
            y2 = double.Parse(Console.ReadLine());

            //Proceso para calcular la distancia entre los dos puntos
            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //Salida de datos
            Console.WriteLine("\n\nLa distancia entre ambos puntos es: Distancia = {0:####.##} {1}", distancia, unidades);
            Console.WriteLine("\nPresione Enter para salir");
            Console.ReadKey();
        }
    }
}