using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_du_pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            string motChoisi;
            char saisiJoueur;
            int compteur = 6;
            int compteur2 = 0;
            bool lettretrouve = false;

            // joueur 1;
            do
            {
                Console.WriteLine("Joueur 1, veuillez choisir un mot d'au moins 5 caractères : ");
                motChoisi = Console.ReadLine();
            } while (motChoisi.Length < 5);

            
            //Console.WriteLine("mot choisi :" + motChoisi);
            //Console.ReadKey();

            motChoisi = motChoisi.ToLower();
            char[] motSecret = motChoisi.ToCharArray(); // chain de caractère transforme en tableau de caractère (toCharArray)
            char[] motTrouve = motChoisi.ToCharArray();

            for (int i = 1; i < motChoisi.Length - 1; i++)
            {
                motSecret[i] = '_';
            }
            //for (int i = 0; i < motSecret.Length; i++)
            //{
            //    Console.Write(motSecret[i]);
            //}
            //Console.ReadKey();

            //joueur 2;
            do
            {
                Console.Clear();
                for (int i = 0; i < motSecret.Length; i++)
                {
                    Console.Write(motSecret[i]);
                }
                Console.WriteLine("\n Veuillez saisir une lettre : ");
                saisiJoueur = char.Parse(Console.ReadLine());

                for (int i = 0; i < motChoisi.Length; i++)
                {
                    if (saisiJoueur == motChoisi[i])
                    {
                        motSecret[i] = saisiJoueur;
                        lettretrouve = true;
                    }
                }
                if (!lettretrouve)
                {
                    compteur--;
                }
                compteur2 = 0;
                for (int i = 0; i < motTrouve.Length; i++)
                {
                    if (motTrouve[i] == motSecret[i])
                    {
                        compteur2++;
                    }
                }

            } while (compteur > 0 && compteur2 < motSecret.Length);
            if (compteur2 == motSecret.Length)
            {
                Console.WriteLine(" Vous avez trouvé le mot secret : " + motChoisi);
            }
            else
            {
                Console.WriteLine(" Vous avez perdu !");

            }
            Console.ReadKey();


        }
    }
}
