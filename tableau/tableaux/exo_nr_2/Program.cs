using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_nr_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase;
            int compteur = 0;
            char caractere;
            bool test = false;

            do
            {
                Console.WriteLine(" Veuillez saisir une phrase terminée par un point : ");
                phrase = Console.ReadLine();

                if (phrase[phrase.Length - 1] == '.')
                {
                    test = true;
                }
                else
                {
                    Console.WriteLine(" Vous vous êtes trompé, la phrase ne contient pas un point ! ");
                }


            } while (!test);

            Console.WriteLine(" Veuillez saisir une lettre  ");
            caractere = char.Parse(Console.ReadLine());

            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == caractere)
                {
                    compteur++;
                    Console.WriteLine(" Le caractère se trouve à la position {0} ;", i + 1);
                }
            }
            if (compteur > 0)
            {
                Console.WriteLine(" La lettre (" + caractere + ") est présente " + compteur + " fois .");

            }
            else
            {
                Console.WriteLine("La lettre n'est pas présente");
            }
            Console.ReadKey();
        }
    }
}
