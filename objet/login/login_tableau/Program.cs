using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom;
            string motDePasse;
            bool motDePasseEstValide = false;
            int niveau = 0;

            string[,] tabLogin = new string[3, 3];

            tabLogin[0, 0] = "user";
            tabLogin[0, 1] = "";
            tabLogin[0, 2] = "2";
            tabLogin[1, 0] = "adelon";
            tabLogin[1, 1] = "leclandessiciliens";
            tabLogin[1, 2] = "1";
            tabLogin[2, 0] = "jbelmondo";
            tabLogin[2, 1] = "leprofessionnel";
            tabLogin[2, 2] = "1";

            Console.WriteLine("Veuillez saisir votre nom : ");
            nom = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre mot de passe : ");
            motDePasse = Console.ReadLine();

            for (int i = 0; i < tabLogin.GetLength(0) && !motDePasseEstValide; i++)
            {
                if (tabLogin[i, 0] == nom && tabLogin[i, 1] == motDePasse)
                {
                    niveau = int.Parse(tabLogin[i, 2]);
                    motDePasseEstValide = true;
                }
            }
            nom = nom.ToUpper();

            if (motDePasseEstValide && niveau != 0)
            {
                Console.WriteLine("La connexion est réussie");
                Console.WriteLine("Bienvenue " + nom + " sur votre interface de gestion, \nVous êtes l'administrateur de niveau : " + niveau + " !");
            }
            else
            {
                Console.WriteLine("Login incorrect");
                Console.WriteLine("Vous n'êtes pas autorisé à vous connecter");
                Console.WriteLine("Contactez votre administrateur système");
            }
            Console.ReadKey();
        }

    }
}

