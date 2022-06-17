using System;

namespace ComparacionDeVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Identificación del programa.
            Console.WriteLine("Programa que compara dos vectores que se ingresan, imprime cada uno y muestra un mensaje si los vectores son iguales o no");
            Console.WriteLine("Autor: Kenet Ortiz");

            //Declarando los vectores
            //Se declaran 4 posiciones en ambos vectores con 0 cada una para luego cambiar el valor 0 en su respectivo vector.
            int[] vector1 = new int[4];
            int[] vector2 = new int[4];

            //Ingresando los valores del primer vector
            Console.WriteLine("\nIngrese 4 valores para el primer vector");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\nIngrese el valor en la posicion {0}", i);
                vector1[i] = LeerNum();
            }

            //Ingresando los valores del segundo vector
            Console.WriteLine("\nIngrese 4 valores para el segundo vector");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\nIngrese el valor en la posicion {0}", i);
                vector2[i] = LeerNum();
            }

            //Imprimir ambos vectores
            Console.Clear();

            Console.WriteLine("\nEl primer vector es: ");
            Console.WriteLine("\nVector 1 ----> [{0}], [{1}], [{2}], [{3}]", vector1[0], vector1[1], vector1[2], vector1[3]);
            Console.WriteLine("\nEl segundo vector es: ");
            Console.WriteLine("\nVector 2 ----> [{0}], [{1}], [{2}], [{3}]", vector2[0], vector2[1], vector2[2], vector2[3]);

            //Comparacion para saber si los vectores son iguales o no
            if (vector1[0] == vector2[0] && vector1[1] == vector2[1] && vector1[2] == vector2[2] && vector1[3] == vector2[3])
            {
                Console.WriteLine("\nLos dos vectores SI son iguales");
            }
            else
            {
                Console.WriteLine("\nLos dos vectores NO son iguales");
            }
        }
        //Metodo para leer valores
        public static int LeerNum()
        {
            int num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}