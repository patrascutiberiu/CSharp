using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_nr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            bool test = false;
            int[] tableau = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(" Veuillez saisir un nombre :");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (tableau[i] != x)
                {
                    Console.WriteLine(" Le numero choisit (" + x + ") se trouve à la position " + (i + 1) + " .");
                    //test = true;
                    break;
                }
                else
                {
                    Console.WriteLine(" Le numero choisit n'est pas dans le tableau !");
                    break;

                }

            }

            //if (!test)
            //{

            //}
            Console.ReadKey();
        }
    }
}
