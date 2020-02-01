using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte_bancaire_2
{
    public class AppCompte
    {
        static void Main(string[] args)
        {

            Banque b = new Banque();
            b.Init();
            b.AjouteCompte(1245, "dutronc", 4500, -500);

             
            b.AfficherComptes();

            b.AjouteCompte(1, "tib", 999999, -1000000);
            b.AfficherComptes();
            Console.WriteLine("Le compte au solde maximum est : \n");
            b.CompteSup();
            b.SortArrayStatic();
            b.AfficherComptes();
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


            b.Transfer(11633, 32345, 2000);



            Console.WriteLine("\n\n----------------------------------------GAME OVER--------------------------------------------");


            Console.ReadKey();
        }
    }
}
