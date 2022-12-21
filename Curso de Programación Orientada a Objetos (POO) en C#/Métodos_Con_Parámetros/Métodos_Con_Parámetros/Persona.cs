using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_Con_Parámetros
{
    internal class Persona
    {
        public string nombre;
        public int edad;
        public string genero;
        public string oficio;

        public void InicializarParametros(string nombr, int ed, string gener, string ofic)
        {
            nombre = nombr;
            edad = ed;
            genero = gener;
            oficio = ofic;

            Console.WriteLine(nombre + " " + edad + " " + genero + " " + oficio);
        }

        public void Inicializar()
        {
            nombre = "Rafael";
            Console.WriteLine(nombre);
        }
    }
}
