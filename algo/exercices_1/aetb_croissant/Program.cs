using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aetb_croissant
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c=0, t = 0;



            Console.WriteLine("Saisir le premier numero a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir le premier numero b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir le premier numero c:");
            c = int.Parse(Console.ReadLine());

            while (a > c || a > b || b > c)
            {
                if (a > b)
                {
                    t = a;
                    a = b;
                    b = t;

                }
               if (b > c)
               {
                   t = b;
                   b = c;
                   
                   c = t;
               }
            }

            Console.WriteLine("L'ordre exact est le suivant : {0:##,###.##}, {1:##,###.#}, {2:##,###.#} ", a, b, c);
            Console.ReadKey();


        }
    }
}
