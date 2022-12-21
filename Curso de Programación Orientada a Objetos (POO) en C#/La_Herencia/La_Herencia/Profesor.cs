using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Herencia
{
    internal class Profesor : Personal
    {
        public Profesor(int id, string name, string surname, int age) : base(id, name, surname, age)
        {

        }
    }
}
