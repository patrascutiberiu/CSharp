using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_nr_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            char[] liste;
            bool test = false;
            int[] compteur = new int[26];
            
            //char[] alpha = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string alphabet = "abcdefghijklmnpqrstuvwxyz";
            //alphabet = alphabet.ToUpper();
            char[] alpha = alphabet.ToCharArray();

            do
            {
                Console.WriteLine(" Ecrivez une phrase d'au mois 20 caractères:");
                s = Console.ReadLine();
                liste = s.ToCharArray();   // copie les caractères vers un tableau
                if (liste.Length == 0)
                {
                    Console.WriteLine(" La phrase est vide!");

                }
                else if (liste.Length < 20)
                {
                    Console.WriteLine(" Phrase trop curte!");

                }
                else
                {
                    test = true;
                }
            } while (!test);

            s = s.ToLower(); // convertie en minuscules
            s = s.Replace('é', 'e'); // remplacer accentes par lettre
            s = s.Replace('è', 'e');
            s = s.Replace('ê', 'e');
            s = s.Replace('à', 'a');
            s = s.Replace('ù', 'u');
            s = s.Replace('ç', 'c');

            for (int i = 0; i < s.Length; i++) // Permet d'aller d'indice en indice.
            {
                for (int j = 0; j < alpha.Length; j++) // Permet de compter le nombre de fois que la lettre apparait.
                {
                    if (liste[i] == alpha[j])
                    {
                        compteur[j]++;
                    }
                }
            }

            Array.Sort(alpha);
            for (int k = 0; k != alpha.Length; k++) // Permet d'afficher le résultat pour chaque lettre.
            {
                if (compteur[k] != 0)
                {
                    Console.WriteLine("Dans la phrase : (" + s + ") la lettre : " + alpha[k] + " est presénte " + compteur[k] + " fois." );
                }
            }
            Console.ReadKey();
        }
    }
}
