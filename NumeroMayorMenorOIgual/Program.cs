using System;

namespace NumeroMayorMenorOIgual
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaración de las variables a usar.
            double NUMERO1, NUMERO2;

            //Identificación del programa.
            Console.WriteLine("Dados dos números, se identificará que número es: <, > ó == a otro");
            Console.WriteLine("\nAutor: Kenet Ortiz");

            Console.WriteLine("\nIngrese el primer numero: ");
            NUMERO1 = Numero();

            Console.WriteLine("\nIngrese el segundo numero: ");
            NUMERO2 = Numero();

            //Proceso.
            //Identificación de que número es: >, < ó == a otro.
            //USANDO ESTRUCTURAS SELECTIVAS SIMPLES Y DOBLES.
            if (NUMERO1 > NUMERO2)
            {
                Console.WriteLine("\nEl número {0:####.####} es mayor que el número {1:####.####}", NUMERO1, NUMERO2);
            }
            else if (NUMERO1 < NUMERO2)
            {
                Console.WriteLine("\nEl número {0:####.####} es menor que el número {1:####.####}", NUMERO1, NUMERO2);
            }
            else
            {
                Console.WriteLine("\nEl número {0:####.####} es igual al número {1:####.####}", NUMERO1, NUMERO2);
            }
        }

        public static double Numero() // La función de este método es solicitar que el usuario ingrese un numero
        {
            double numero = double.Parse(Console.ReadLine());
            return numero;
        }
    }
}