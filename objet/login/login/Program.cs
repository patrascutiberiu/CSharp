using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom;
            string motDePasse;

            Console.WriteLine("Veuillez saisir votre nom : ");
            nom = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre mot de passe : ");
            motDePasse = Console.ReadLine();
         
            if (nom == "user" && motDePasse == "")
            {
                nom = nom.ToUpper();
                AffichageBienvenueUser(nom);                
            }
            else if (nom == "adelon" && motDePasse == "leclandessiciliens")
            {
                nom = nom.ToUpper();
                AffichageBienvenueUser(nom);                
            }
            else if (nom == "jbelmondo" && motDePasse == "leprofessionnel")
            {
                nom = nom.ToUpper();
                AffichageBienvenueUser(nom);              
            }
            else
            {
                Console.WriteLine("Login incorrect");
                Console.WriteLine("Vous n'êtes pas autorisé à vous connecter");
                Console.WriteLine("Contactez votre administrateur système");
            }

            Console.ReadKey();
        }
        private static void AffichageBienvenueUser(string nom)
        {
            Console.WriteLine("La connexion est réussie!");
            Console.WriteLine("Bienvenue " + nom + " !");
            Console.WriteLine("Maintenant tu peux utiliser ton poste !");
        }
    }
}
