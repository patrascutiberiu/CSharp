using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objet_fraction
{
    class AppFraction
    {
        static void Main(string[] args)
        {
            int div;


            Fraction f = new Fraction(6, 2);
            Fraction f2 = new Fraction();
            Fraction f3 = new Fraction(9);
            Ecran.Afficher(f);

            f.Reduce();
            Ecran.Afficher(f);
            Ecran.Afficher(f2);
            Ecran.Afficher(f3);

            Ecran.Afficher();
            Fraction frOppose = new Fraction(4, 7);
            frOppose.Oppose();
            Ecran.Afficher(frOppose);

            Ecran.Afficher();
            Fraction frInvers = new Fraction(4, 7);
            frInvers.inverse();
            Ecran.Afficher(frInvers);

            Ecran.Afficher();
            Fraction f4 = new Fraction(11, 7);
            Fraction f5 = new Fraction(5, 4);
            //Console.WriteLine(f4.sup(f4, f5) ? "Vrai", "Non"); //trenaire 
            
            Ecran.Afficher(f4.Sup(f4, f5));
            Ecran.Afficher(f4.Inf(f4, f5));

            
            Fraction f6 = new Fraction(11, 7);
            Fraction f7 = new Fraction(22, 14);
            Ecran.Afficher(f6.Egal(f6, f7));
            

            Ecran.Afficher();
            Fraction f8 = new Fraction(-75, 90);
            div = f8.GetPgcd();
            Ecran.Afficher(div);

            Ecran.Afficher();
            Fraction f9 = new Fraction(120, -150);
            f9.Reduce();
            Ecran.Afficher(f9);

            Ecran.Afficher();
            Fraction f10 = new Fraction(2, 15);
            Fraction f11 = new Fraction(11, 2);
            Ecran.Afficher(f10.Addition(f10, f11));
            Ecran.Afficher(f10.Soustraction(f10, f11));
            Ecran.Afficher(f10.Produit(f10, f11));
            Ecran.Afficher(f10.Division(f10, f11));









            Console.ReadKey();


        }
    }
}
