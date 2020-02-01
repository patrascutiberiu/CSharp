using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equation_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double x;

            Console.WriteLine(" Introduisez la valeur de a :");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine(" Introduisez la valeur de b :");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine(" Nous allons recherche la valeur de x solution de l'equation ax+b=0");
            Console.ReadKey();


            if (a == 0 && b == 0)
            {
                Console.WriteLine(" L'équation est indéterminée !  ");
            }

            else if (a == 0 && b != 0)
            {
                Console.WriteLine(" L'équation est imposible ! ");
            }

            else
            {
                x = -b / a;
                Console.WriteLine(" La valeur du x est = {0:##,##0.00} ", x);
            }



            Console.ReadKey();
        }
    }
}
