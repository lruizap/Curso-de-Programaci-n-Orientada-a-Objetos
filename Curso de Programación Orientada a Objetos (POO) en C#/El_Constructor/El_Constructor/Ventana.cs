using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Constructor
{
    internal class Ventana
    {
        // Atributos

        private int ancho;
        private int altura;
        private string color;

        public Ventana(int ancho, int altura, string color)
        {
            this.ancho = ancho;
            this.altura = altura;
            this.color = color;
        }

        public void Mostrar()
        {
            Console.WriteLine($"El ancho de la ventana es : {ancho}");
            Console.WriteLine($"El alto de la ventana es : {altura}");
            Console.WriteLine($"El color de la ventana es : {color}");
            Console.ReadLine();
        }
    }
}
