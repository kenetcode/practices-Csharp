using System;

namespace Edades_De_Estudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de las variables
            int edadPromedio = 0;
            int edad;
            int numeroEstudiantes;
            int menoresEdad = 0;
            int mayoresEdad = 0;

            Console.WriteLine("Digite el numero de estudiantes encuestados a los que le ingresara la edad");
            Console.WriteLine("Debe ingresar el numero de estudiantes con numero enteros");


            numeroEstudiantes = int.Parse(Console.ReadLine());


            for (int i = 1; i <= numeroEstudiantes; i++)
            {
                Console.WriteLine("Ingrese la edad del estudiante {0}", i);

                edad = IngresoDeEdad();

                //Acumulador para el promedio de la edad
                edadPromedio += edad;

                //Contadores en una estructura selectiva para saber cuantos estudiantes son menores y mayores de edad
                if (edad >= 14 && edad < 18)
                {
                    menoresEdad++;
                }

                else if (edad == 18)
                {
                    mayoresEdad++;
                }

                else
                {

                    Console.WriteLine("Ingrese una edad entre el rango de 14 a 18 años");

                }

            }
            //Mostrar datos en pantalla
            Console.WriteLine("\nLa edad promedio es: " + edadPromedio / numeroEstudiantes);
            Console.WriteLine("\nEl numero de estudiantes menores de edad son: " + menoresEdad);
            Console.WriteLine("\nEl numero de estudiantes mayores de edad son: " + mayoresEdad);

        }
        //Este Metodo se usa para que el usuario ingrese la edad, cuando el metodo es llamado a Main.
        public static int IngresoDeEdad()
        {
            int edad = int.Parse(Console.ReadLine());

            return edad;
        }
    }
}