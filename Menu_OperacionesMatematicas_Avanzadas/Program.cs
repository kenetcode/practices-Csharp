using System;

namespace Menu_OperacionesMatematicas_Avanzadas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de las variables 
            double eleccion, x, y, seno, coseno, tangente, raiz, potencia;

            //Declarando y asignando bool a la variable entrarYsalir = true, para hacer uso de ella en el ciclo while.
            bool entrarYsalir = true;

            //Este ciclo repetitivo esta activo mientras la variables entrarYsalir == true, si el usuario quiere salir del programa debe simplemente
            //digitar el numero 7, que es la opcion para salir del menu, al ingresar el numero 7 el switch que esta dentro del while ejecuta el caso donde la
            //eleccion del usuario es 7 y las intrucciones de que en caso la eleccion sea 7 es cambiar el valor de la variable entrarYsalir y le asigna
            //entrarYsalir == false, para que cuando el while realice otra iteracion salga del programa.

            while (entrarYsalir == true)
            {
                //Llamada al metod EleccionEnMenu para que muestre los datos del programa y las opciones que el usuario tiene a disposicion para seleccionar
                //y este metod pide al usuario que digite el numero asociado a la operacion que desea realizar. 
                eleccion = EleccionEnMenu();

                //El switch contiene las acciones que se pueden realizar en el programa, son las operaciones que se indican como mensaje principal, para dar
                //contexto de lo que el programa realiza.
                //Consta de 7 opciones, al ingresar el numero 1 calcula el seno, 2 el coseno, 3 la tangente, 4 la raiz cuadrada, 5 la potencia de y elevado a x,
                //6 si un numero ingresado es par o impar y 7 la opcion para salir del progrma.

                switch (eleccion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el valor de x");
                        x = double.Parse(Console.ReadLine());

                        seno = Math.Sin(x);

                        Console.WriteLine("El seno de x es: " + seno);

                        break;

                    case 2:
                        Console.WriteLine("Ingrese el valor de x");
                        x = double.Parse(Console.ReadLine());

                        coseno = Math.Cos(x);
                        Console.WriteLine("El coseno de x es: " + coseno);

                        break;

                    case 3:

                        Console.WriteLine("Ingrese el valor de x");
                        x = double.Parse(Console.ReadLine());

                        tangente = Math.Tan(x);
                        Console.WriteLine("La Tangente de x es: " + tangente);

                        break;

                    case 4:

                        Console.WriteLine("Ingrese el valor de x");
                        x = double.Parse(Console.ReadLine());

                        if (x >= 0)
                        {
                            raiz = Math.Sqrt(x);
                            Console.WriteLine("La Raiz cuadrada de x es: " + raiz);
                        }

                        else
                        {
                            Console.WriteLine("Ingreso un numero negativo, es imposible operar con raices pares y numero negativos");
                        }

                        break;

                    case 5:

                        Console.WriteLine("Ingrese el valor de la potencia x");
                        x = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el valor de la base y");

                        y = double.Parse(Console.ReadLine());


                        potencia = Math.Pow(y, x);
                        Console.WriteLine("La potencia de y elevado a x es: " + potencia);

                        break;

                    case 6:

                        Console.WriteLine("Ingrese el valor de x");
                        x = double.Parse(Console.ReadLine());

                        if (x % 2 == 0)
                        {
                            Console.WriteLine("El numero ingresado es par");
                        }
                        else
                        {
                            Console.WriteLine("El numero ingresado es impar");

                        }

                        break;

                    case 7:

                        Console.WriteLine("Saliendo del programa");

                        entrarYsalir = false;

                        break;

                    default:

                        Console.WriteLine("\nPor favor ingrese una opcion valida, las opciones validas son las que se muestran en el menu.");

                        break;

                }

                Console.WriteLine("\nPrecione la tecla Enter o Return para continuar");
                Console.ReadLine();

                //Limpia la pantalla antes de realizar la siguiente iteracion. 
                Console.Clear();
            }
        }
        //El metod EleccionEnMenu muestra la informacion de las opciones que puede realiza el programa, y tambien solicita que el usuario ingrese la opcion que
        //desea realizar y este retorna la eleccion del usuario.
        public static double EleccionEnMenu()
        {
            double eleccion;

            Console.WriteLine("Autor: Kenet Ortiz");
            Console.WriteLine("\nEl programa realiza las diferentes operaciones que se muestran a continuacion.");
            Console.WriteLine("\nSeleccione una de las diferentes operaciones del menu para realizar.");
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1 [Seno de x]");
            Console.WriteLine("2 [Coseno de x]");
            Console.WriteLine("3 [Tangente de x]");
            Console.WriteLine("4 [Raiz cuadrada de x]");
            Console.WriteLine("5 [Potencia de Y elevado a x]");
            Console.WriteLine("6 [Verificar si un numero es par o impar]");
            Console.WriteLine("7 [Salir del programa]");

            Console.WriteLine("\nEleccion: ");
            eleccion = double.Parse(Console.ReadLine());

            return eleccion;
        }
    }
}