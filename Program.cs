using System;
//Una tienda ofrece un descuento del 15% sobre el total de la compra y un cliente
//desea saber cuánto deberá pagar finalmente por su compra.
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double Costo_1, Costo_2, Costo_3, Costo_4, Descuento, Precio_Final;
            double Total;
            Console.WriteLine("Ingrese el costo del Primer producto: ");
            Costo_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el costo del Segundo producto: ");
            Costo_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el costo del Tercer producto: ");
            Costo_3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el costo del Cuarto producto: ");
            Costo_4 = double.Parse(Console.ReadLine());
            Total = Costo_1 + Costo_2 + Costo_3 + Costo_4;
            Descuento = Total > 1000 ? Total * 0.15 : 0;
            Precio_Final = Total - Descuento;
            Console.WriteLine("Valor de descuento: " + Descuento);
            Console.WriteLine("Valor del precio final: " + Precio_Final);
            Console.WriteLine("Valor de total de la compra: " + Total);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
