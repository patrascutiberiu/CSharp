using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_liste_maison
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom;
            string prenom;
            string mail;
            int choixUtilisateur;
            bool test = false;
            string repons;
            DateTime dateNaissance;

            List<Administration> listeAdmin = new List<Administration>();
            Administration nomPersonel;

            do
            {
                nomPersonel = new Administration();

                Console.WriteLine("Veuillez saisir votre nom svp : ");
                nom = Console.ReadLine();
                nomPersonel.Nom = nom;
                Console.WriteLine("Veuillez saisir votre prenom svp : ");
                prenom = Console.ReadLine();
                nomPersonel.Prenom = prenom;
                Console.WriteLine("Veuillez saisir votre mail svp : ");
                mail = Console.ReadLine();
                nomPersonel.Mail = mail;
                do
                {
                    Console.WriteLine("Veuillez saisir votre date de naissance en format (jj/mm/aaaa) svp : ");
                    test = DateTime.TryParse(Console.ReadLine(), out dateNaissance);
                    nomPersonel.DateNaissance = dateNaissance;
                } while (!test);


                Console.WriteLine("Avez-vous finir ? (o/n) ");
                repons = Console.ReadLine();
                //nomPersonel = new administration(nom,prenom,mail,dateNaissance);
                listeAdmin.Add(nomPersonel);
            } while (repons != "o");

            foreach (Administration item in listeAdmin)
            {
                item.affichage();
            }

            do
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Veuillez taper par quelle ordre voulez-vous trier les noms ");
                Console.WriteLine("[1] par la nom : ");
                Console.WriteLine("[2] par le prénom :");
                Console.WriteLine("[3] par le mail : ");

                test = false;
                do
                {
                    Console.WriteLine("[4] par la date de naissance :");
                    test = int.TryParse(Console.ReadLine(), out choixUtilisateur);
                } while (!test);
                switch (choixUtilisateur)
                {
                    case 1:
                        listeAdmin = listeAdmin.OrderBy(n => n.Nom).ToList();
                        break;
                    case 2:
                        listeAdmin = listeAdmin.OrderBy(n => n.Prenom).ToList();
                        break;
                    case 3:
                        listeAdmin = listeAdmin.OrderBy(n => n.Mail).ToList();
                        break;
                    case 4:
                        listeAdmin = listeAdmin.OrderBy(n => n.DateNaissance).ToList();
                        break;
                    default:
                        Console.WriteLine("Tu es trop con pour ce siecle, veuillez tapper 1,2,3 ou 4");
                        break;
                }
            } while (choixUtilisateur != 1 && choixUtilisateur != 2 && choixUtilisateur != 3 && choixUtilisateur != 4);

            foreach (Administration item in listeAdmin)
            {
                item.affichage();
            }
            Console.ReadKey();
        }
    }
}
