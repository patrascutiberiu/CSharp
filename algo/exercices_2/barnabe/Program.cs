using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barnabe
{
    class Program
    {
        static void Main(string[] args)
        {
            double S;
            int nrMag = 0;


            Console.WriteLine(" La somme initiele est de : ");
            S = double.Parse(Console.ReadLine());

            do
            {
                S = S / 2 - 1;
                nrMag++;
            } while (S > 1);

            Console.WriteLine("Le nombre de magasins dans lesquels il a acheté est : {0:0}", nrMag );
            Console.ReadKey();

        }
    }
}
