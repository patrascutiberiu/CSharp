using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class AppFraction
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(12, 7);
            Fraction f1 = new Fraction(9);
            Fraction f2 = new Fraction();
            Ecran.Affiche(f);
            Ecran.Affiche(f1);
            Ecran.Affiche(f2);

            Ecran.Affiche();
            Fraction f4 = new Fraction(4, 7);
            Ecran.Affiche(f4);
            f4.Oppose();
            Ecran.Affiche(f4);

            Ecran.Affiche();
            Fraction f5 = new Fraction(0, 7);
            Ecran.Affiche(f5);
            f5.Inverse().Inferieur(f4);
            Ecran.Affiche(f5);


            Ecran.Affiche();
            Fraction f6 = new Fraction(11, 7);
            Fraction f7 = new Fraction(5, 4);
            f6.Superieur(f7);
            Ecran.Affiche(f6.Superieur(f7));
            Ecran.Affiche(f6.Inferieur(f7));
            Ecran.Affiche(f6.Egal(f7));

            Ecran.Affiche();
            Ecran.Affiche(f7.Reduire());

            
            Fraction f8 = new Fraction(1250, 2500);
            Ecran.Affiche(f8.Reduire());

            Ecran.Affiche();
            Fraction f9 = f7.Puissance(3);
            Ecran.Affiche(f9);


















            Console.ReadKey();
        }
    }
}
