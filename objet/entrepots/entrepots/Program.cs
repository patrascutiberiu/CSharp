using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrepots
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomEntrepot;
            string nomPersonne;
            int colisH;
            bool test = false;
            string reponse;
            string choix;
            bool test2 = false;

            List<Entrepots> listeEntrepot = new List<Entrepots>();
            Entrepots nomPreparateur;

            do
            {
                nomPreparateur = new Entrepots();

                Console.WriteLine("Veuillez saisir le nom d'entrepôt : ");
                nomEntrepot = Console.ReadLine();
                Console.WriteLine("Veuillez saisir le nom de la personne : ");
                nomPersonne = Console.ReadLine();
                do
                {
                    Console.WriteLine("Veuillez saisir combiens des colis sont trier par heure pour chaque personne : ");
                    test = int.TryParse(Console.ReadLine(), out colisH);
                } while (!test);

                Console.WriteLine("Avez-vous finir ? (o/n) ");
                reponse = Console.ReadLine();

                nomPreparateur = new Entrepots(nomEntrepot, nomPersonne, colisH);
                listeEntrepot.Add(nomPreparateur);

            } while (reponse == "n");

            Console.WriteLine("--------------------------------------------------------------------------------");

            foreach (Entrepots item in listeEntrepot)
            {
                item.affichage();
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Dans quel entrepôt voulez-vous calculer la productivité ?");
            choix = Console.ReadLine();

            List<Entrepots> product = listeEntrepot.FindAll(monprod => monprod.entrepot == choix);

            Console.WriteLine("--------------------------------------------------------------------------------");
            int nombrePersonne = 0;
            int moyenne = 0;
            foreach (Entrepots item in listeEntrepot)
            {
                if (item.entrepot == choix)
                {
                    item.affichage2();
                    moyenne += item.colisH;
                    nombrePersonne++;
                    test2 = true;
                }
                else
                {
                    test2 = false;
                }
            }
            Console.WriteLine(Environment.NewLine);
            if (test2)
            {
                Console.WriteLine("La moyenne de productivité pour l'entrepôt est de : " + moyenne / nombrePersonne );
            }
            else
            {
                Console.WriteLine("Votre entrepôt tapez n'existe pas dans la liste !");               
            }


            Console.ReadKey();
        }
    }
}
