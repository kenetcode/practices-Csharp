using System;

namespace SumaResta_Arrays
{
    //Suma y resta de vectores
    class Program
    {
        static void Main(string[] args)
        {

            int[] vector1 = new int[2];
            int[] vector2 = new int[2];
            int[] resta = new int[2];
            int[] suma = new int[2];

            Console.WriteLine("\nIngrese los datos del vector1");

            for (int i = 0; i < vector1.Length; i++)
            {
                Console.WriteLine("En la posicion {0}", i);
                vector1[i] = Dato();
            }

            Console.WriteLine("\nIngrese los datos del vector2");

            for (int i = 0; i < vector2.Length; i++)
            {
                Console.WriteLine("En la posicion {0}", i);
                vector2[i] = Dato();
            }

            Console.WriteLine("\nLos vectores son: ");

            Console.WriteLine("\nVector 1 ---> [{0}], [{1}]", vector1[0], vector1[1]);

            Console.WriteLine("\nVector 2 ---> [{0}], [{1}]", vector2[0], vector2[1]);

            for (int i = 0; i < resta.Length; i++)
            {
                resta[i] = vector2[i] - vector1[i];
            }
            Console.WriteLine("\nEl vector resultante de la resta de vector2 - vector1 es:");
            Console.WriteLine("\nresta ---> [{0}], [{1}]", resta[0], resta[1]);

            for (int i = 0; i < suma.Length; i++)
            {
                suma[i] = vector1[i] + vector2[i];
            }
            Console.WriteLine("\nEl vector resultante de la suma de vector1 + vector2 es:");

            Console.WriteLine("\nSuma ---> [{0}], [{1}]", suma[0], suma[1]);
        }

        public static int Dato()
        {
            int dato = int.Parse(Console.ReadLine());
            return dato;
        }
    }
}