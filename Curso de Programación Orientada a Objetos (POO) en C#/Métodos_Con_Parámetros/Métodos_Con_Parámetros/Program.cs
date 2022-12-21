using System;

namespace Métodos_Con_Parámetros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona person = new Persona();
            person.Inicializar();
            Persona person2 = new Persona();
            person2.InicializarParametros("Lucas", 20, "Masculino", "Estudiante");
        }
    }
}