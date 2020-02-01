using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_nombre_a_b
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Veuillez saisir la valeur de nombre A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir la valeur de nombre B");
            b = double.Parse(Console.ReadLine());
            
            c = a;
            a = b;
            b = c;

            Console.WriteLine("La valeur de A est :" + a);
            Console.WriteLine("La valeur de B est :" + b);

            Console.ReadKey();
        }
    }
}
