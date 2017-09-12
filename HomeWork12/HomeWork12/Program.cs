using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWork12
{
    class Program
    {
        static void Main(string[] args)
        {
            Myreflexion reflex = new Myreflexion();
            reflex.Name = "Nurtleu";
            reflex.Surname = "Omirzhanov";
            reflex.Expert = "Programmist";
            reflex.Age = 16;
            Type type = typeof(Myreflexion);
            foreach (var reflexion in type.GetProperties())
            {
                Write(reflexion.ToString() + " " + reflexion.GetValue(reflex));
                ReadLine();
            }
        }
    }
}
