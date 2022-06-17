using System;

namespace AreaDeUnCubo
{
    //Programa de consola que calcula el area de un cubo
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Calculo de area de un cubo");
            Console.WriteLine("Calculo de area de un cubo");
            Console.WriteLine("Autor: Kenet Ortiz");

            //Declaracion de Variables
            double area, aristas;

            //Descripcion del programa. 
            Console.WriteLine("\nPrograma que calcula el area de un cubo");
            Console.WriteLine("\nA continuacion se le solicitaran los datos para realizar la operacion. ");

            //Entrada de datos
            Console.WriteLine("\nIngrese el valor de las aristas: ");
            aristas = double.Parse(Console.ReadLine());

            //Proceso para calcular el area del cubo
            area = 6 * Math.Pow(aristas, 2);

            //Salida de datos que muestran el area del cubo
            Console.WriteLine("\nEl area del cubo es: area = {0:####.##}", area);
            Console.ReadKey();
        }
    }
}
