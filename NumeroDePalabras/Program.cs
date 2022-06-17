using System;

namespace NumeroDePalabras
{
    class Program
    {
        static void Main(string[] args)
        {
            IdentificacionPrograma();
            Proceso();
        }

        //Identifica el programa
        public static void IdentificacionPrograma()
        {
            Console.WriteLine("Autor: kenet Ortiz");
            Console.WriteLine("Programa: Escribir una solución que lea una frase del teclado y que despliegue el número de palabras que contiene la frase.");
        }

        //Metodo que verifica cuantas palabras tiene la frase
        public static void Proceso()
        {

            string frase, frasefinal = "";
            int palabras = 0;
            string punto = ".";

            frase = LeerFrase();

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == '.')
                {
                    frasefinal = frase;
                }
                else
                {
                    frasefinal = frase + punto;
                }
            }

            for (int i = 0; i < frasefinal.Length; i++)
            {
                if (frasefinal[i] == ' ' || frasefinal[i] == '.')
                {
                    palabras++;
                }
            }

            Console.WriteLine("\n\nLa frase tiene: " + "[" + palabras + "]" + " Palabras.");
        }

        //Lee la frase y la guarda en la variable frase.
        public static string LeerFrase()
        {
            string frase;

            Console.WriteLine("\nIngrese una frase por favor y al final agrega un " + "'.' Seguido de la ultima palabra\n");

            frase = Console.ReadLine();

            return frase;
        }
    }
}