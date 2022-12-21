using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comisiones com1 = new Comisiones("Marco Jimenez Lopez", 2500);
            Console.WriteLine(">>>> Inicialice el nombre del empleado y el sueldo base usando un constructor... \n");

            Console.WriteLine("Nombre del empleado: " + com1.NombreVendedor);
            Console.WriteLine("Sueldo Base: " + com1.SueldoBase);

            Console.WriteLine();
            com1.IngresarVentas();
            Console.WriteLine();
            com1.CalculoComision();
        }
    }
}