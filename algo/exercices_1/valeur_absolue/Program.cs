using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valeur_absolue
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
                                                                // int y;

            Console.WriteLine(" Introduisez la valeur de x :");
            x=int.Parse(Console.ReadLine());
            //y=Math.Abs(x);
            //Console.WriteLine("La valeur absolue est = " +y);
            if (x > 0)
            {
                Console.WriteLine(" La valeur absolue est = {0:##,###}", x);
            }
            else if (x == 0)
            {
                Console.WriteLine(" La valeur absolue est = {0:##,##0}", 0);
            }
            else
            {
                Console.WriteLine(" La valeur absolue est = {0:##,###}", -x);
            }

            Console.ReadKey();
        }
    }
}
