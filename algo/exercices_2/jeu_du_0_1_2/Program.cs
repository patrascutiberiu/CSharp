using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_du_0_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choixOrdi;
            int choixJoueur;
            int dif;
            int pointOrdi = 0;
            int pointJoueur = 0;
            int nbManches = 0;

            Random aleas = new Random();  // random = numero aleatoir 

            do
            {
                Console.WriteLine("Veuillez choisir un nombre entre 0,1 et 2 ou tapper un nombre negatif pour arreter le jeux :");
                choixJoueur = int.Parse(Console.ReadLine());
                choixOrdi = aleas.Next(0, 3);
                nbManches++;

                dif = Math.Abs(choixOrdi - choixJoueur);
                if (dif == 2)
                {
                    if (choixJoueur > choixOrdi)
                    {
                        choixJoueur++;

                    }
                    else
                    {
                        choixOrdi++;
                    }
                }
                else if (dif == 1)
                {
                    if (choixJoueur < choixOrdi)
                    {
                        pointJoueur++;
                    }
                    else
                    {
                        pointOrdi++;
                    }
                }
                else
                {
                    Console.WriteLine(" Egalitée, aucun point n'est pas marqué !");

                }
                Console.WriteLine("votre score est de : " + pointJoueur + " score machine est de : " + pointOrdi + " manche numero : " + nbManches);

            }
            while (pointOrdi < 10 && pointJoueur < 10 && choixJoueur >= 0);

            if (pointJoueur == 10)
            {
                Console.WriteLine("Bravo vous avez gagné  en : {0:0} manches ", nbManches);

            }
            else if (pointOrdi == 10)
            {
                Console.WriteLine("Désole vous avez perdu, la machine gagne en {0:0} manches", nbManches);
            }
            else
            {
                Console.WriteLine("Vous avez arreter le jeux  au bout de : {0:0} manches, votre score est : {1:0} points et le score de la machine est : {2:0} points", nbManches, pointJoueur, pointOrdi);
            }

            Console.ReadKey();
        }
    }
}
