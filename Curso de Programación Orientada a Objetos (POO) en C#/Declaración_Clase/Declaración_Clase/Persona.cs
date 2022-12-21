using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaración_Clase
{
    internal class Persona
    {
        // Atributos 

        public string nombre;
        public int edad;
        public string profesion;
        public string genero;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese el nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el edad:");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el profesión:");
            profesion = Console.ReadLine();

            Console.WriteLine("Ingrese el género:");
            genero = Console.ReadLine();
        }

        public void ToString()
        {
            Console.WriteLine("Los atributos del objeto son:");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(nombre + " " + edad + " " + profesion + " " + genero);
        }

        public void EsMayorDeEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }
        } 
    }
}
