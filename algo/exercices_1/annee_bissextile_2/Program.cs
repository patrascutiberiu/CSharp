using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace annee_bissextile_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;

            Console.WriteLine(" Introduisez l'année que vous voulez souhaitez : ");
            a = int.Parse(Console.ReadLine());

            if (a % 4 != 0)
            {
                Console.WriteLine(" l'année est non bissextile . ");
            }
            else
            {
                if (a % 100 != 0)
                {
                    Console.WriteLine(" l'année est bissextile . ");
                }
                else
                {
                    if (a % 400 == 0)
                    {
                        Console.WriteLine(" l'année est non bissextile . ");
                    }
                    else
                    {
                        Console.WriteLine(" l'année est bissextile . ");
                    }

                }


            }

            Console.ReadKey();

        }
    }
}
