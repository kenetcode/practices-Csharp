using System;

namespace UsoDeMatriz
{
    //Desplegar una matriz de 4x4 con la diagonal llena de 1 y lo demas en 0
    class Program
    {
        static void Main(string[] args)
        {

            //Declaracion de la matriz
            int[,] matriz = new int[4, 4];

            for (int filas = 0; filas < 4; filas++)
            {
                for (int columnas = 0; columnas < 4; columnas++)
                {
                    ValidarCeros(matriz, filas, columnas);
                }
            }

            Console.Write("\n\nDespliegue de Matriz 4x4\n\n\n");
            Imprimir(matriz);
        }

        // Metodo para valida los ceros y llenar la matriz
        public static void ValidarCeros(int[,] matriz, int filas, int columnas)
        {
            do
            {
                Console.Write("Llene la matriz con ceros | Celda [" + (filas + 1) + "," + (columnas + 1) + "]:");
                matriz[filas, columnas] = int.Parse(Console.ReadLine());

            } while (matriz[filas, columnas] != 0);

            return;
        }

        // Metodo que muestra la matriz con la diagonal en unos(1)
        public static void Imprimir(int[,] matriz)
        {
            for (int filas = 0; filas < 4; filas++)
            {
                Console.WriteLine("\n");
                for (int columnas = 0; columnas < 4; columnas++)
                {
                    if (filas == columnas)
                    {
                        matriz[filas, columnas] = 1;
                    }

                    else

                        matriz[filas, columnas] = 0;

                    Console.Write("\t[" + matriz[filas, columnas] + "]\t");
                }
            }

            return;
        }
    }
}