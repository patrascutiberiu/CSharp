using ClassLibraryPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int valX;
            int valY;
            int deplacement1;
            int deplacement2;

            Console.Write("Le point x : ");
            valX = int.Parse(Console.ReadLine());
            Console.Write("Le point y : ");
            valY = int.Parse(Console.ReadLine());

            Console.Write("Le deplacement de x : ");
            deplacement1 = int.Parse(Console.ReadLine());
            Console.Write("Le deplacement de y : ");
            deplacement2 = int.Parse(Console.ReadLine());

            Point monPoint = new Point(valX, valY);

            Console.WriteLine("Les points avant deplacement :"+monPoint.ToString());

            monPoint.Deplacer(deplacement1, deplacement2);

            Console.WriteLine("Les points aprés deplacement : " + monPoint.ToString());

            Point point2 = monPoint.symetriqueX();
            Console.WriteLine("Points symetrique x :"+point2.ToString());

            Point point3 = monPoint.symetriqueY();
            Console.WriteLine("Points symetrique y :" + point3.ToString());

            Point point4 = monPoint.symetriqueOrigine();
            Console.WriteLine("Points symetrique origine :" + point4.ToString());

            monPoint.PermuterXY();
            Console.WriteLine("Permutation x,y :"+monPoint.ToString());

            Console.ReadKey();
        }
    }
}
