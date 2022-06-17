using System;

namespace AreaPerimetro_RectanguloCirculo
{
    //Programa que pide el los datos de un rectangulo y un disco y calcula sus areas y perimetros
    //Este programa hace uso de los metodos para realizar los calculos.
    class Program
    {
        const double PI = 3.1416;

        static void Main(string[] args)
        {
            //Titulo del programa
            Console.Title = ("CALCULO DE PERIMETRO, AREA DE UN CIRCULO Y RECTANGULO");
            Console.WriteLine("CALCULO DE PERIMETRO, AREA DE UN CIRCULO Y RECTANGULO");
            Console.WriteLine("Autor: Kenet Ortiz");

            //Declaracion de las variables a usar en el programa 
            double radioDisco, baseRectangulo, alturaRectangulo, Pdisco, Adisco, Prectangulo, Arectangulo;

            //Ingreso de datos: base y altura del rectangulo, radio del disco. 
            Console.WriteLine("\nIngrese el valor del radio del disco:");
            radioDisco = IngresarDato();

            Console.WriteLine("\nIngrese el valor del la base del rectangulo:");
            baseRectangulo = IngresarDato();

            Console.WriteLine("\nIngrese el valor del la altura del rectangulo:");
            alturaRectangulo = IngresarDato();

            //Retornando a main los valores del Area y Perimetro del Disco y Rectangulo.
            Pdisco = PerimetroDisco(radioDisco, PI);

            Adisco = AreaDisco(radioDisco, PI);

            Prectangulo = PerimetroRectangulo(baseRectangulo, alturaRectangulo);

            Arectangulo = AreaRectangulo(baseRectangulo, alturaRectangulo);

            //Llamada al metodo que imprime los resultados de los calculos para encontrar
            //el Area y Perimetro Del disco y rectangulo
            ImprimirDatos(Pdisco, Adisco, Prectangulo, Arectangulo);
        }
        //Pide un dato y lo retona
        public static double IngresarDato()
        {
            double dato = double.Parse(Console.ReadLine());
            return dato;
        }
        //Calcula el perimetro del disco
        public static double PerimetroDisco(double radioDisco, double PI)
        {
            double Pdisco = 2 * PI * radioDisco;
            return Pdisco;
        }
        //Calcula el area del disco
        public static double AreaDisco(double radioDisco, double PI)
        {
            double Adisco = PI * Math.Pow(radioDisco, 2);
            return Adisco;
        }
        //Calcula el perimetro del rectangulo
        public static double PerimetroRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            double Prectangulo = 2 * (baseRectangulo + alturaRectangulo);
            return Prectangulo;
        }
        //Calcula el area del rectangulo
        public static double AreaRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            double Arectangulo = baseRectangulo * alturaRectangulo;
            return Arectangulo;
        }
        //Metodo que tiene como parametros el area y perimetro del disco y rectangulo, y muestra en pantalla
        //el resultado de estos
        public static void ImprimirDatos(double Pdisco, double Adisco, double Prectangulo, double Arectangulo)
        {
            Console.Write("\n\nEl perimetro del disco es:  {0:####.##} cm \n\nEl area del disco es: {1:####.##} cm^2 " +
                "\n\nEl Perimetro del rectangulo es: {2:####.##} cm \n\nEl area del rectangulo es: {3:####.##} cm",
                Pdisco, Adisco, Prectangulo, Arectangulo);
        }
    }
}