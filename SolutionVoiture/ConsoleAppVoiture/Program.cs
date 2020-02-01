using ClassLibraryVoiture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture maVoiture = new Voiture("VW", "Golf 7", 0, 60, 120, 
                "Pirelli", 15, "été",
                "Pirelli", 15, "été",
                "Goodyear", 15, "été",
                "Goodyear", 15, "été");

            Voiture maVoitureClone = new Voiture(maVoiture);


            Console.WriteLine("GetHashCode pour la voiture " + maVoiture.GetHashCode());
            Console.WriteLine("GetHashCode pour la cloneVoiture " + maVoitureClone.GetHashCode());

            Console.WriteLine(maVoiture.ToString());

            bool op1 = maVoiture.DemarrerVoiture();

            Console.WriteLine(op1 ? "Le moteur est demarré !" : "Le moteur ne peux pas être demarré");

            bool op2 = maVoiture.AjouterLEssence(59);
            Console.WriteLine(op2 ? "Remplisage réussi" : "Beaucoup d'essence !");

            Console.WriteLine(maVoiture.ToString());

            Console.WriteLine("Vous avez à payer : " + maVoiture.FaireLePlain() + " l");

            bool a = maVoiture.AvancerVoiture();

            if (!a)
            {
                Console.WriteLine("La voiture est arretée !");

            }
            else
            {
                Console.WriteLine("La voiture avance !");
            }

            bool b = maVoiture.ArreterVoiture();

            if (!b)
            {
                Console.WriteLine("La voiture est arretée !");
            }
            else
            {
                Console.WriteLine("La voiture avance !");
            }

            Console.WriteLine("GetHashCode pour le moteur " + maVoiture.SonMoteur.GetHashCode());
            Console.WriteLine("GetHashCode pour la voiture " + maVoiture.GetHashCode());

            Voiture c = new Voiture(maVoiture);

            Console.WriteLine("GetHashCode pour copie moteur " + c.SonMoteur.GetHashCode());
            Console.WriteLine("GetHashCode pour la cloneVoiture " + c.GetHashCode());


            Console.ReadKey();
        }

    }
}
