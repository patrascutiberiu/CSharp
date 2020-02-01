using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tri_minima
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int longueur;
            int[] tableau;
            string resultat ="";
            int compteur = 1;
            
            Console.WriteLine(" Combien des nombres voulez-vous ranger ?");
            longueur = int.Parse(Console.ReadLine());

            tableau = new int[longueur];

            Console.WriteLine("Entrez les nombres : ");
            for (i = 0; i != longueur; i++)
            {
                Console.Write("n°"+ compteur++ +" : ");
                tableau[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(tableau);

            for (i = 0; i != longueur; i++)
            {
                Console.Write(tableau[i] + ", ");
            }

            //for (i = 0; i != longueur; i++)
            //{
            //    resultat += ", " + tableau[i];
            //}
            //resultat = resultat.Substring(1, resultat.Length - 1);
            //Console.WriteLine(" Voici le tableau trié par ordre croissant :" + resultat +".");

            Console.ReadKey();
        }
    }
}
