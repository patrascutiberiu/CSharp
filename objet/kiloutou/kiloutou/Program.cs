using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiloutou
{
    class Program
    {
        static void Main(string[] args)
        {
            int choixUtilisateur;
            bool test = false;
            bool test2 = false;

            //creation de la liste
            //1
            List<voiture> listeVoiture = new List<voiture>();
            voiture maVoiture1 = new voiture("Peugeot", "307", 2098);
            voiture maVoiture2 = new voiture("Renault", "Espace", 1987);
            voiture maVoiture3 = new voiture("Lancia", "Dadra", 1203);
            voiture maVoiture4 = new voiture("BMW", "324d", 3049);
            voiture maVoiture5 = new voiture("Peugeot", "406", 1500);
            voiture maVoiture6 = new voiture("Ford", "Mondeo", 2500);

            // ajouter mes voitures dans la liste
            listeVoiture.Add(maVoiture1);
            listeVoiture.Add(maVoiture2);
            listeVoiture.Add(maVoiture3);
            listeVoiture.Add(maVoiture4);
            listeVoiture.Add(maVoiture5);
            listeVoiture.Add(maVoiture6);

            Console.WriteLine("Liste voiture 1 non trier :");
            Console.WriteLine();

            //recouperer les voitures non trier
            foreach (voiture item in listeVoiture)
            {
                item.Affichage();
            }
            do
            {

                Console.WriteLine();

                do
                {
                    Console.WriteLine("Veuillez taper par quel ordre voulez-vous trier vos voitures :");
                    Console.WriteLine("[1] par la marque :");
                    Console.WriteLine("[2] par le modèle :");
                    Console.WriteLine("[3] par le numéro du série :");
                    test = int.TryParse(Console.ReadLine(), out choixUtilisateur);
                } while (!test);


                switch (choixUtilisateur)
                {
                    case 1:
                        listeVoiture = listeVoiture.OrderBy(n => n.Marque).ToList();
                        test2 = true;
                        break;
                    case 2:
                        listeVoiture = listeVoiture.OrderBy(n => n.Modele).ToList();
                        test2 = true;
                        break;
                    case 3:
                        listeVoiture = listeVoiture.OrderBy(n => n.NumSerie).ToList();
                        test2 = true;
                        break;
                    default:
                        Console.WriteLine("Tu es trop con pour ce siecle, veuillez tapper 1,2 ou 3!");
                        break;

                }

            } while (!test2); //choixUtilisateur != 1 && choixUtilisateur != 2 && choixUtilisateur != 3

            // afficher les voitures trier
            Console.WriteLine();
            Console.WriteLine("Liste voiture 1 trier :");
            Console.WriteLine();

            foreach (voiture item in listeVoiture)
            {
                item.Affichage();
            }
            Console.ReadKey();
            Console.Clear();

            //2
            

            List<voiture2> listeVoiture2 = new List<voiture2>();
            voiture2 maVoiture;
            DateTime d1 = new DateTime(1988, 12, 10);
            maVoiture = new voiture2("Peugeot", "307", 2098, d1);
            listeVoiture2.Add(maVoiture);
            DateTime d2 = new DateTime(1990, 08, 25);
            maVoiture = new voiture2("Renault", "Espace", 1987, d2);
            listeVoiture2.Add(maVoiture);
            DateTime d3 = new DateTime(1995, 05, 11);
            maVoiture = new voiture2("Lancia", "Dadra", 1203, d3);
            listeVoiture2.Add(maVoiture);
            DateTime d4 = new DateTime(1993, 02, 01);
            maVoiture = new voiture2("BMW", "324d", 3049, d4);
            listeVoiture2.Add(maVoiture);
            DateTime d5 = new DateTime(1988, 06, 22);
            maVoiture = new voiture2("Peugeot", "406", 1500, d5);
            listeVoiture2.Add(maVoiture);
            DateTime d6 = new DateTime(1985, 04, 23);
            maVoiture = new voiture2("Ford", "Mondeo", 2500, d6);
            listeVoiture2.Add(maVoiture);

            Console.WriteLine("Liste voiture 2 non trier:");
            Console.WriteLine();

            foreach (voiture2 item in listeVoiture2)
            {

                item.Affichage2();
            }
            

            test = false;
            test2 = false;
            do
            {
                Console.WriteLine();
                do
                {
                    Console.WriteLine("Veuillez taper par quelle ordre voulez-vous trier vos voitures :");
                    Console.WriteLine("[1] par la marque :");
                    Console.WriteLine("[2] par le modèle :");
                    Console.WriteLine("[3] par le numéro du série :");
                    Console.WriteLine("[4] par sa date de mise en circulation : ");
                    test = int.TryParse(Console.ReadLine(), out choixUtilisateur);
                } while (!test);



                switch (choixUtilisateur)
                {
                    case 1:
                        listeVoiture2 = listeVoiture2.OrderBy(n => n.Marque).ToList();
                        test2 = true;
                        break;
                    case 2:
                        listeVoiture2 = listeVoiture2.OrderBy(n => n.Modele).ToList();
                        test2 = true;
                        break;
                    case 3:
                        listeVoiture2 = listeVoiture2.OrderBy(n => n.NumSerie).ToList();
                        test2 = true;
                        break;
                    case 4:
                        listeVoiture2 = listeVoiture2.OrderBy(n => n.MiseEnCirculation).ToList();
                        test2 = true;
                        break;
                    default:
                        Console.WriteLine("Tu es trop con pour ce siecle, veuillez tapper 1, 2, 3 ou 4 !");
                        break;
                }

            } while (!test2);
            Console.WriteLine();
            Console.WriteLine("Liste voiture 2 trier:");
            Console.WriteLine();

            foreach (voiture2 item in listeVoiture2)
            {

                item.Affichage2();
            }

            Console.ReadKey();
        }
    }
}
