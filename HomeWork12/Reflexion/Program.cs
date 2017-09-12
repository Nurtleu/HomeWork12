using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Reflexion
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Console);
            foreach (var reflexMethod in myType.GetMethods());
            {
                WriteLine(myType);
                ReadLine();
            }
            ReadLine();
        }
    }
}
