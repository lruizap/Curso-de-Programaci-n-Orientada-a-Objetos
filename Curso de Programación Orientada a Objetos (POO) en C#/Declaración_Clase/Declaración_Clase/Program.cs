using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaración_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objeto 1
            
            Persona person = new Persona();

            person.nombre = "lruizap";
            person.edad = 20;
            person.profesion = "Estudiante";
            person.genero = "Masculino";

            // Objeto 2 

            Persona person2 = new Persona();

            person2.nombre = "Paco";
            person2.edad = 60;
            person2.profesion = "Comediante";
            person2.genero = "Masculino";

            // Mostrar por pantalla

            Console.WriteLine("El nombre es: " + person.nombre + " \n" + 
                              "La edad es: " + person.edad + " \n" + 
                              "La profesión es: " + person.profesion + " \n" + 
                              "El género es: " + person.genero + "\n");

            Console.WriteLine($"El nombre es: {person2.nombre} \nLa edad es: {person2.edad} \nLa profesión es: {person2.profesion} \nEl género es: {person2.genero} \n");

            person.ToString();

            // Iniciando la idea de constructor

            Console.Clear();

            Persona person3 = new Persona();

            person3.Inicializar();

            Console.WriteLine();

            person3.ToString();

            Console.WriteLine();

            person3.EsMayorDeEdad();
        }
    }
}