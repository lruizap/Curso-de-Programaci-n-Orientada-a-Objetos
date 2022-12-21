using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Herencia
{
    internal class Personal
    {
        private int id;
        private string name;
        private string surname;
        private int age;

        public Personal(int id, string name, string surname, int age)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void ToString()
        {
            Console.WriteLine("      Clase Profesor");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("      DATOS  =>");
            Console.WriteLine();
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Nombre : {name}");
            Console.WriteLine($"Apellidos : {surname}");
            Console.WriteLine($"Edad : {age}");
        }
    }
}
