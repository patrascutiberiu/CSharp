using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte_bancaire
{
    class AppCompte
    {
        static void Main(string[] args)
        {

            Compte c = new Compte();
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            c.Afficher();
            c1.Afficher();
            c1.Crediter(2000);
            c1.Debiter(5300);
            c1.Afficher();
            int n = Console.Read();

            Compte c2 = new Compte(12345, "toto", 1000, -500);
            Compte c3 = new Compte(45657, "titi", 2000, -1000);
            c2.Transferer(1300, c3);
            c2.Afficher();
            c3.Afficher();

            Compte c4 = new Compte(12345, "toto", 1000, -500);
            Compte c5 = new Compte(45657, "titi", 2000, -1000);
            c4.Transferer(3300, c5);
            c4.Afficher();
            c5.Afficher();


            Compte.Afficher(c4.Superieur(c5));



            Console.ReadKey();
        }
    }
}
