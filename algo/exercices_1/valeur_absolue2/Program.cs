using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valeur_absolue2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine(" Introduisez la valeur de x :");
            x = int.Parse(Console.ReadLine());
            y = Math.Abs(x);
            Console.WriteLine(" La valeur absolue est = {0:##,##0}", y);
            Console.ReadKey();
        }
    }
}
