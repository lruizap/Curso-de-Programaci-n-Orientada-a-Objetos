using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Comisiones
    {
        // Atributos

        private string nombreVendedor;
        private int sueldoBase;
        private int ventas;
        private int comision;
        private int totalSueldo;
        
        // Constructor

        public Comisiones(string NomVendedor, int SueldoBase)
        {
            this.nombreVendedor = NomVendedor;
            this.sueldoBase = SueldoBase;
        }
        
        // Propiedades

        public string NombreVendedor { get => nombreVendedor; set => nombreVendedor = value; }
        public int SueldoBase { get => sueldoBase; set => sueldoBase = value; }
        public int Ventas { get => ventas; set => ventas = value; }
        public int Comision { get => comision; set => comision = value; }
        public int TotalSueldo { get => totalSueldo; set => totalSueldo = value; }

        // Métodos

        public void IngresarVentas()
        {
            int v1, v2, v3;

            Console.WriteLine("Ingrese la primera venta: ");
            v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda venta: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera venta: ");
            v3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Ventas = v1 + v2 + v3;
            Console.WriteLine("La suma de las ventas es de: " + Ventas);
        }

        public void CalculoComision()
        {
            if (Ventas >= 2000 && Ventas <= 4000)
            {
                Comision = (SueldoBase * 10) / 100;
                TotalSueldo = SueldoBase + Comision;
                Console.WriteLine("Ventas: " + Ventas);
                Console.WriteLine("Comisión Percibida: 10% = " + Comision);
                Console.WriteLine("Total Sueldo + Comisión: " + TotalSueldo);
            }
            else
            {
                if (Ventas > 4000 && Ventas < 7000)
                {
                    Comision = (SueldoBase * 20) / 100;
                    TotalSueldo = SueldoBase + Comision;
                    Console.WriteLine("Ventas: " + Ventas);
                    Console.WriteLine("Comisión Percibida: 20% = " + Comision);
                    Console.WriteLine("Total Sueldo + Comisión: " + TotalSueldo);
                }
                else
                {
                    if (Ventas >= 7000)
                    {
                        Comision = (SueldoBase * 30) / 100;
                        TotalSueldo = SueldoBase + Comision;
                        Console.WriteLine("Ventas: " + Ventas);
                        Console.WriteLine("Comisión Percibida: 30% = " + Comision);
                        Console.WriteLine("Total Sueldo + Comisión: " + TotalSueldo);
                    }
                    else
                    {
                        Console.WriteLine("Ventas por debajo de lo requerido no tiene comisión ASIGNADA\nTotal Sueldo: " + SueldoBase);
                    }
                }
            }
        }

    }
}
