using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace annee_bissextile
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine(" Introduisez l'année que vous voulez souhaitez compris entre 1900 et 2018 : ");
            a = int.Parse(Console.ReadLine());

            if (a % 4 == 0)
            {
                Console.WriteLine(" l'année est bissextile . ");
            }
            else
            {
                Console.WriteLine(" l'année est Non bissextile . ");

            }
            Console.ReadKey();

        }
    }
}
