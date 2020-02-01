using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jour_de_la_semaine
{
    class Program
    {
        static void Main(string[] args)
        {

            int jours;
            int mois;
            int annee;
            int resultat4;
            int valeurMois;
            int reste7;


            do
            {
                Console.WriteLine(" introduisez un jour entre 1 et 30/31 : ");
                jours = int.Parse(Console.ReadLine());
            } while (jours < 1 || jours > 31);

            do
            {
                Console.WriteLine(" introduisez un mois entre 1 et 12: ");
                mois = int.Parse(Console.ReadLine());
            } while (mois < 1 || mois > 12);

            do
            {
                Console.WriteLine();
                annee = int.Parse(Console.ReadLine());
            } while (annee < 1900 || annee > 2019);


            resultat4 = annee / 4;

            valeurMois = mois;

            switch (mois)
            {
                case 1:
                    if (annee % 4 == 0)
                    {
                        valeurMois = 0;
                    }
                    else
                    {
                        valeurMois = 1;
                    }
                    break;
                case 2:
                    if (annee % 4 == 0)
                    {
                        valeurMois = 3;
                    }
                    else
                    {
                        valeurMois = 4;
                    }
                    break;
                case 3:
                    valeurMois = 4;
                    break;
                case 4:
                    valeurMois = 0;
                    break;
                case 5:
                    valeurMois = 2;
                    break;
                case 6:
                    valeurMois = 5;
                    break;
                case 7:
                    valeurMois = 0;
                    break;
                case 8:
                    valeurMois = 3;
                    break;
                case 9:
                    valeurMois = 6;

                    break;
                case 10:
                    valeurMois = 1;
                    break;
                case 11:
                    valeurMois = 4;
                    break;
                case 12:
                    valeurMois = 6;
                    break;
            }
            reste7 = (annee + resultat4 + valeurMois + jours) % 7;

            Console.WriteLine(" Le resultat du reste est :" + reste7);

            switch (reste7)
            {
                case 1:
                    Console.WriteLine(" C'est dimanche !");
                    break;
                case 2:
                    Console.WriteLine(" C'est lundi !");
                    break;
                case 3:
                    Console.WriteLine(" C'est mardi !");
                    break;
                case 4:
                    Console.WriteLine(" C'est mercredi !");
                    break;
                case 5:
                    Console.WriteLine(" C'est jeudi !");
                    break;
                case 6:
                    Console.WriteLine(" C'est vendredi !");
                    break;
                case 7:
                    Console.WriteLine(" C'est samedi !");
                    break;
            }
            Console.ReadKey();

        }
    }
}
