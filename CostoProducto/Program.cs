using System;

namespace CostoProducto
{
    // Programa que calcula el costo de un producto (importado) y su ganancia, se aplica un impuesto de aduana
    // del 10% al precio del producto y una ganancia del 25% luego de aumentarle el impuesto de aduana.
    class Program
    {
        // Constantes que se implementaran en el programa
        const double gananciaArticulo = 0.25, impuestoAduana = 0.10;

        static void Main(string[] args)
        {
            //Titulo del programa
            Console.Title = ("COSTO, GANANCIA Y PRECIO TOTAL DE UN PRODUCTO");
            Console.WriteLine("COSTO, GANANCIA Y PRECIO TOTAL DE UN PRODUCTO");
            Console.WriteLine("Autor: Kenet Ortiz");

            //Variables a Usar
            double costoTotalProducto, gananciaVenta, precioVentaFinal, costoArticulo;
            string nombreProducto;

            //Ingreso de datos
            Console.WriteLine("Ingrese el nombre del producto: ");
            nombreProducto = Console.ReadLine();

            Console.WriteLine("Ingrese el costo del producto: ");
            costoArticulo = double.Parse(Console.ReadLine());

            //Haciendo los calculos.
            costoTotalProducto = costoArticulo + costoArticulo * impuestoAduana;
            gananciaVenta = costoTotalProducto * gananciaArticulo;
            precioVentaFinal = costoTotalProducto + gananciaVenta;

            //Salida de datos
            Console.WriteLine("\n\nNombre del producto: {0}.\n\nCosto total: " +
                "${1:####.##} \n\nGanancia: ${2:####.##} \n\nPrecio De Venta: ${3:####.##}",
                nombreProducto, costoTotalProducto, gananciaVenta, precioVentaFinal);

        }
    }
}