using ClassLibraryCompte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCompte
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte a = new Compte("eu",123,1000,-500);

            //Compte cClone = (Compte)a.Clone();

            Console.WriteLine(a.ToString());

            a.Crediter(100);

            Console.WriteLine(a.ToString());

            bool ok=a.Debiter(2000);

            Console.WriteLine(ok);
            if (ok)
            {
                Console.WriteLine("Débit réussi !");
            }
            else
            {
                Console.WriteLine("impossible de faire le débit ");
            }

            Console.WriteLine(a.ToString());

            Compte b = new Compte("tib", 222, 2000, -2000);

            b.Transferer(a, 1000);

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());

            bool sup = b.Supperieur(a);

            Console.WriteLine("Le compte 1 est : "+(sup ? "superieur !" : "inferieur !"));


            Console.ReadKey();
        }
        
    }
}
