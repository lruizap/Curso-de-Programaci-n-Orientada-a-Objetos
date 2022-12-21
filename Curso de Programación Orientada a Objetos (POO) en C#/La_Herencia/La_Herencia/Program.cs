using System;

namespace La_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profesor prof = new Profesor(1, "Paco", "Ávila", 50);
            prof.ToString();
        }
    }
}