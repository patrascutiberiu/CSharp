using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equation
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
            x = resolution_equation(a, b);
            Console.WriteLine(" La valeur du x est = {0:##,##0.00} ", x);
            Console.ReadKey();

        }
        static public double resolution_equation(double _a, double _b)
        {
            double x;

            if (_a == 0 && _b == 0)
            {
                Console.WriteLine(" L'équation est indéterminée !  ");
                x = double.NaN;
            }

            else if (_a == 0 && _b != 0)
            {
                Console.WriteLine(" L'équation est imposible ! ");
                x = double.NaN;
            }

            else
            {
                x = -_b / _a;
            }
            return x;

        }
    }
}
