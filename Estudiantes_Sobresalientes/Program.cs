using System;
using System.IO;
using System.Diagnostics;

//Programa que escribe en un archivo el carnet, la estatura en cm y la nota final de los estudiantes que tiene una nota
//Mayor a 7, a partir de los datos ingresados por teclado
namespace Estudiantes_Sobresalientes
{
    public struct Estudiante
    {
        public string carnet;
        public double estatura;
        public double notaFinal;
    }

    class Program
    {
        static StreamWriter Escribir;
        static StreamReader Leer;

        static void Main(string[] args)
        {
            Estudiante[] estudiantes = new Estudiante[5];
            Console.WriteLine("Programa que Escribe en un archivo los datos de los estudiantes con nota final mayor a 7");
            Console.WriteLine("Autor: Kenet Ortiz | OP20001");

            Proceso(estudiantes);

            Leer = new StreamReader("archivo.txt", true);

            string datosDelArchivo = Leer.ReadToEnd();

            Console.WriteLine("\nLos datos leidos son: \n");
            Console.WriteLine(datosDelArchivo);

            Leer.Close();
        }

        //metodo que Pide los datos y los escribe en el archivo
        public static void Proceso(Estudiante[] estudiantes)
        {
            //Instancia de nuevo objeto del tipo Estudiante 
            Estudiante estudiante = new Estudiante();

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("\nIngrese los datos del estudiante {0}: ", i + 1);

                do
                {
                    Console.WriteLine("\nIngrese el carnet: ");
                    estudiante.carnet = Console.ReadLine();

                } while (estudiante.carnet == "");

                do
                {
                    Console.WriteLine("\nIngrese la estatura en metros: ");
                    estudiante.estatura = LeerDato();

                } while (estudiante.estatura < 0.70 || estudiante.estatura > 2.30);

                do
                {
                    Console.WriteLine("\nIngrese la nota final: ");
                    estudiante.notaFinal = LeerDato();

                } while (estudiante.notaFinal < 0 || estudiante.notaFinal > 10);

                //Asignando los datos del carnet, la estatura y la nota final de cada estudiante en cada posicion i del vector
                estudiantes[i] = estudiante;
            }

            Console.WriteLine("\nEscribiendo en el archivo los datos de los estudiantes con notas mayores a 7");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                if (estudiantes[i].notaFinal > 7)
                {
                    Escribir = new StreamWriter("archivo.txt", true);

                    string mayusculas = estudiantes[i].carnet.ToUpper();

                    double estaturacm = estudiantes[i].estatura * 100;

                    Escribir.WriteLine("\nEstudiante con los datos: ");

                    Escribir.WriteLine("\nCarnet : {0}", mayusculas);

                    Escribir.WriteLine("\nEstatura en cm: {0}cm", estaturacm);

                    Escribir.WriteLine("\nNota final: {0}", estudiantes[i].notaFinal);

                    Escribir.Close();
                }
            }

            Console.WriteLine("\nEscritura exitosa\n");
        }
        //Metodo que es llamado para leer datos sobre la estatura y la nota
        public static double LeerDato()
        {
            double dato = double.Parse(Console.ReadLine());
            return dato;
        }
    }
}