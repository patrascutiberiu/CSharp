using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte_liste
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque b = new Banque();
            b.Init();
            b.AjouteCompte(1245, "dutronc", 4500, -500);

            b.AfficherComptes();


            b.AjouteCompte(1, "tib", 999999, -999999);
            b.AfficherComptes();


            b.CompteSup();

            b.RendCompte(1245);


            //b.Transfert(1, 1245, 1000);

            Console.ReadLine();
        }
    }
}
