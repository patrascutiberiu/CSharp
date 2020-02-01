using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte_bancaire_test
{
    class AppCompte
    {
        static void Main(string[] args)
        {
            string numero;
            string nom;
            double solde;
            double crediter;
            double debiter;
            double transfer;
            int compteur = 0;
            int decouvertAutorise;


            compteur++;
            Console.WriteLine("Compte n° "+compteur);
            Console.WriteLine("Veuillez saisir le nom du proprietaire du compte :");
            nom = Console.ReadLine();
            Console.WriteLine("Veuillez saisir le numero du compte qu'a " + nom + " :");
            numero = Console.ReadLine();
            Console.WriteLine("veuillez saisir le montant de votre compte : ");
            solde = double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Veuillez saisir le montant du découvert (montant inférieur à 1) : ");
                decouvertAutorise = int.Parse(Console.ReadLine());
            } while (decouvertAutorise >= 1);

            Compte Compte = new Compte(numero, nom, solde,decouvertAutorise);
            Compte.Afficher();


            Console.WriteLine("Veuillez saisir le montant crediter : ");
            crediter = double.Parse(Console.ReadLine());
            Compte.Crediter(crediter);
            Compte.Afficher();


            Console.WriteLine("Veuillez saisir le montant debiter : ");
            debiter = double.Parse(Console.ReadLine());

            Compte.Debiter(debiter);
            Compte.Afficher();

            Console.WriteLine();
            compteur++;
            Console.WriteLine("Compte n° "+compteur);
            Console.WriteLine("Veuillez saisir le nom du proprietaire du compte :");
            nom = Console.ReadLine();
            Console.WriteLine("Veuillez saisir le numero du compte qu'a " + nom + " :");
            numero = Console.ReadLine();
            Console.WriteLine("veuillez saisir le montant de votre compte : ");
            solde = double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Veuillez saisir le montant du découvert (montant inférieur à 1) : ");
                decouvertAutorise = int.Parse(Console.ReadLine());
            } while (decouvertAutorise >= 1);
            Console.WriteLine("Combien euros voulez-vous transferer depuis le premiere compte ? ");
            transfer = double.Parse(Console.ReadLine());



            Compte Compte2 = new Compte(numero, nom, solde, decouvertAutorise);
            Compte2.Afficher();
            Compte.Transferer(transfer, Compte2);
            Compte2.Afficher();
            Compte.Afficher();


            Console.ReadKey();

        }
    }
}
