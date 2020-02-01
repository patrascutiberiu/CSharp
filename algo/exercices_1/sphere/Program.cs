using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sphere
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double aire;
            double volume;

            Console.WriteLine(" Veuillez saisir le rayon de la sphère !");
            r=double.Parse(Console.ReadLine());
            //calcul de l'aire 
            aire = 4 * Math.PI * Math.Pow(r, 2);
            volume = (double)4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine(" L'aire de la sphère est : {0:###,###.00} km2 est son volume {1:#,###.###} km3 ", aire,volume);
            Console.ReadKey();
        }
    }
}
