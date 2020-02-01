using ClassLibraryBanque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque b = new Banque();
            b.Init();
            b.AjouteCompte(1245, "dutronc", 4500, -500);
            b.AjouteCompte(1, "tib", 999999, -1000000);
            b.AjouteCompte(111, "pula", 100, 100);

            Console.WriteLine(b.AfficherComptes());
            
            b.SortTableauDesc();
            
            Console.WriteLine(b.AfficherComptes());

            
            b.AfficherComptes();
            Console.WriteLine("Le compte au solde maximum est : \n");
            Console.WriteLine(b.CompteSup());
            
            
            Console.WriteLine("---------------------------------------------------------------------------------------------");


            Console.WriteLine("Le compte trouve en fonction de son numéro est : \n");
            Compte c = b.RendCompte(1245);
            if (c != null)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("Le compte n'est pas trouvé !");

            }
            Console.WriteLine("---------------------------------------------------------------------------------------------");



            bool ok=b.Transfer(11633, 32345, 10000);
            if (!ok)
            {
                Console.WriteLine("Le transfert ne peut pas s'effectuer");
            }
            else
            {
                Console.WriteLine("Transfert effectué");
            }


            Console.WriteLine("\n\n----------------------------------------GAME OVER--------------------------------------------");


            Console.ReadKey();
        }
    }
}
