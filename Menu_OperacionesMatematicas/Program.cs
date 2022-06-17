using System;

namespace Menu_OperacionesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            //la variable resultado sirve para almacenar el valor resultante de las operaciones matematicas 
            double resultado;

            //la variable opcionSeleccionada llama al meto do IngresoDeOpcion, este muestra las indicaciones del programa
            //y en la variable opcionSeleccionada se almacena el numero que continene la operacion a realizar
            int opcionSeleccionada = IngresoDeOpcion();

            Console.WriteLine("\nIngrese el primer numero: ");
            double numeroIngresado1 = IngresoDeNumero();

            Console.WriteLine("\nIngrese el segundo numero: ");
            double numeroIngresado2 = IngresoDeNumero();

            //En el Switch si la variable opcionSeleccionada es 1, 2, 3, 4 en los 4 casos entonces dependiendo de que opcion eligera el usuario al principio
            //Se ejecuta la suma, resta, multiplicacion o division respectivamente.
            //Ademas por default si el usuario al inicio del programa ingreso un valor dirente de 1, 2, 3 o 4, el programa solo le mostrara que 
            //No eligio una opcion correcta y el programa finalizara.
            //La variable numeroIngresado1 y numeroIngresado2 almacenan los valores del primer y segundo numero ingresado por el usuario respectivamente

            switch (opcionSeleccionada)
            {
                case 1:
                    resultado = numeroIngresado1 + numeroIngresado2;
                    Console.WriteLine("\nLa suma de los numero ingresados es: suma = {0: ####.####} ", resultado);
                    break;

                case 2:
                    resultado = numeroIngresado1 - numeroIngresado2;
                    Console.WriteLine("\nLa resta de los numero ingresados es: resta = {0: ####.####} ", resultado);
                    break;

                case 3:
                    resultado = numeroIngresado1 * numeroIngresado2;
                    Console.WriteLine(
                        "\nLa multiplicacion de los numero ingresados es: multiplicacion = {0: ####.####} ", resultado);
                    break;
                case 4:
                    resultado = numeroIngresado1 / numeroIngresado2;
                    Console.WriteLine("\nLa division de los numero ingresados es: division = {0: ####.####} ",
                        resultado);
                    break;

                default:
                    Console.WriteLine("\nUsted no eligio ninguna opcion para realizar una de las operaciones");
                    break;
            }

        }
        //El metodo IngresoDeOpcion sirve para describir el programa y para solicitar y almacenar que operacion matematica el usuario quiere ralizar
        public static int IngresoDeOpcion()
        {
            Console.WriteLine("Bienvenido, este programa realiza sumas, restas, multiplicaciones y divisiones entre dos numeros");
            Console.WriteLine("A continuacion ingrese una de las opciones siguientes");
            Console.WriteLine("\npresione 1 para sumar\nPresione 2 para restar\nPresione 3 para multiplicar\nPresione 4 para dividir");
            Console.WriteLine("\n\nNota: Para dividir sin tener errores evite hacer el denominador = 0");
            Console.WriteLine("En este caso el SEGUNDO numero ingresado es el denominador");
            Console.WriteLine("\nOpcion:");
            int opcion = int.Parse(Console.ReadLine());

            return opcion;
        }
        //El metodo IngresoDeNumero nos sirve para poder solicitar los dos numeros requerido para realizar cualquiera de las operaciones matematicas
        public static double IngresoDeNumero()
        {
            double numero = double.Parse(Console.ReadLine());
            return numero;
        }
    }
}