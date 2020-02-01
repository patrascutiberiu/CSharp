using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objet_fraction
{
    class Ecran
    {
        public   void Afficher(Fraction _fraction)
        {
            Console.WriteLine(_fraction.ToString());
        }
        public static void Afficher(int _a)
        {
            Console.WriteLine(_a.ToString());
        }
        public static void Afficher(bool _a)
        {
            Console.WriteLine(_a.ToString());
        }
        public static void Afficher()
        {
            Console.WriteLine(Environment.NewLine);
        }
    }
}
