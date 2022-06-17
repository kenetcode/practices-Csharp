using System;
using System.IO;

namespace LeerArchivo
{
    class Program
    {
        //static StreamWriter EscribirListaDeNumero;
        static StreamReader LeerListaDeNumeros;
        static void Main(string[] args)
        {
            //Declaracion de variable y vector
            int i = 0;
            int[] vector = new int[50];

            //Llamada a los metodos
            Identificacion();

            LeerDeLista(vector, i);

            Mostrar(vector, i);
        }
        //Metodo para identificar el programa
        public static void Identificacion()
        {
            Console.WriteLine("Programa que Lee un archivo.txt que contiene numeros enteros de un digito, los almacena en un vector de 50 elementos y lo muestra");
            Console.WriteLine("\nAutor: Kenet Ortiz");
        }
        //Metodo que lee el arcivo y almacena los datos en el vector
        public static void LeerDeLista(int[] vector, int i)
        {
            LeerListaDeNumeros = new StreamReader("ListaDeNumeros.txt", true);

            do
            {
                vector[i] = int.Parse(LeerListaDeNumeros.ReadLine());
                i++;

            } while (i != 50);

            LeerListaDeNumeros.Close();
        }
        //Metodo que muestra el vector
        public static void Mostrar(int[] vector, int i)
        {
            Console.WriteLine("\nVector Resultante: \n");

            for (i = 0; i < 50; i++)
            {
                Console.WriteLine("En la Posicion: [{0}] --> " + "[" + vector[i] + "]", (i + 1));
            }
        }
    }
}