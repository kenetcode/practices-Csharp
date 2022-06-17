using System;

//El objetivo del programa es calcular la cuota universitaria, que sera asignada en base al ingreso del salario familiar del papa sumado al de la mama.
//Luego se mostrara en pantalla el carnet del estudiante, el ingreso familiar y la cuota asignada a pagar
namespace Cuota_Universitaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAutor: Kenet Ortiz");
            Console.WriteLine("\n\nBienvenido, este programa calculara su cuota universitaria en base al ingreso salarial familiar");

            //Aca se solicita al usuario el carnet del estudiante llamando al metodo
            //CarnetEstudiante y almacenandolo en la variable carnetEstudiante
            Console.WriteLine("\nPor favor ingrese su carnet");
            string carnetEstudiante = CarnetEstudiante();

            //Se solicita al usuario ingresar el salario de la mama
            //Llamando al metodo IngresoSalario y almacenandolo en la variable salarioMama
            Console.WriteLine("\nPor favor ingrese el salario mensual de su mamá: ");
            double salarioMama = IngresoSalario();

            //Se solicita al usuario ingresar el salario del papa
            //Llamando al metodo IngresoSalario y almacenandolo en la variable salarioPapa
            Console.WriteLine("\nPor favor ingrese el salario mensual de su Papá: ");
            double salarioPapa = IngresoSalario();

            //Se suma el salario de la mama y el papa y se almacena en la variable salarioFamiliar
            double salarioFamiliar = salarioMama + salarioPapa;

            //Se muestra el carnet del estudiante en pantalla
            Console.WriteLine("\nSu numero de carnet es: {0}", carnetEstudiante);

            //Se muestra en pantalla el ingreso mensual familiar, Es decir el salario del papa sumado al de la mama
            Console.WriteLine("\nSu ingreso familiar mensual es de ${0:####.####}", salarioFamiliar);

            //Se utilizan las selectivas para determinar la cuota que el estudiante debera pagar a la universidad.
            if (salarioFamiliar > 3000)
            {
                Console.WriteLine("\nCuota a pagar: $150");
            }
            else if (salarioFamiliar > 2000 && salarioFamiliar < 3000)
            {
                Console.WriteLine("\nCuota a pagar: $100");
            }
            else if (salarioFamiliar > 1000 && salarioFamiliar < 2000)
            {
                Console.WriteLine("\nCuota a pagar: $50");
            }
            else if (salarioFamiliar < 1000)
            {
                Console.WriteLine("\nCuota a pagar: $10");
            }
            else
            {
                Console.WriteLine();
            }

        }

        //El metodo IngresoSalario Sirve para llamarlo en Main y solicita que 
        //el usuario ingrese la cantidad de salario de sus padres.
        public static double IngresoSalario()
        {
            double ingresoIndividual = double.Parse(Console.ReadLine());
            return ingresoIndividual;
        }

        //El metodo CarnetEstudiante Sirve para llamarlo en Main y solicitar que el 
        //Usuario ingrese su numero de Carnet
        public static string CarnetEstudiante()
        {
            string carnet = Console.ReadLine();
            return carnet;
        }
    }
}