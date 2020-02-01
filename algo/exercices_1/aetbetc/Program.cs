using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aetbetc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, t = 0;

            Console.WriteLine("Saisir le premier numero a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir le premier numero b:");
            b = int.Parse(Console.ReadLine());


            while (a > b || b < a)
            {
                if (a > b)
                {
                    t = a;
                    a = b;
                    b = t;

                }
                if (b < a)
                {
                    t = b;
                    b = a;

                    a = t;
                }
            }

            Console.WriteLine("L'ordre exact est le suivant : {0:##,###} , {1:##,###} ", a, b);
            Console.ReadKey();
        }
    }
}
