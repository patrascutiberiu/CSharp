using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_point
{
    class Program
    {
        static void Main(string[] args)
        {
            float valX = 0;
            float valY = 0;
            float dep1;
            float dep2;


            Console.WriteLine("Veuillez saisir la valeur de X :");
            valX = float.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir la valeur de Y :");
            valY = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduisez la valeur pour deplacer le X :");
            dep1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduisez la valeur pour deplacer le Y :");
            dep2 = float.Parse(Console.ReadLine());

            Point lePoint = new Point(valX, valY);
            lePoint.affichage();
            lePoint.deplacer(dep1, dep2);
            lePoint.affichage();


            Point lePoint2 = lePoint.symX();
            lePoint2.affichage();

            Point lePoint3 = lePoint.symY();
            lePoint3.affichage();

            Point lePoint4 = lePoint.symOrigine();
            lePoint4.affichage();

            lePoint.permuteXY();
            lePoint.affichage();




            Console.ReadKey();

        }
    }
}
