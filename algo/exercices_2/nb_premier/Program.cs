using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nb_premier
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n = 2, reste;
            bool diviseur = false; 
            bool test = false;

            do
            {
                Console.WriteLine(" valeur a :");
                test = int.TryParse(Console.ReadLine(), out a);

            } while (test == false);
            if (a > 1)
            {

                do
                { // rechercher de diviseur
                    reste = a % n;
                    if (reste == 0)
                    {
                        diviseur = true;
                        break;
                    }
                    n++;

                } while (diviseur == false && n < a);
                if (diviseur == true)
                {
                    Console.WriteLine(" Le nombre n'est pas premier, il a pour diviseur {0:##,###}", n);
                }
                else
                {
                    Console.WriteLine("C'est un nombre premier !");

                }
            }
            else
            {
                Console.WriteLine("Le nombre 1 n'est pas premier par definition");

            }
            Console.ReadKey();
        }
    }
}
