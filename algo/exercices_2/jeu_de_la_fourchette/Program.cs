using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_de_la_fourchette
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordi;
            int monChoix;
            int inf = 0;
            int sup = 100;
            bool test = false;
            int compteur = 0;

            Random aleas = new Random();
            ordi = aleas.Next(0, 101);
            Console.WriteLine(" Le numero choisit par l'ordi est : " + ordi);
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine(" Le numero à recherche se trouve entre 0 et 100 ");

            do
            {
                Console.WriteLine(" Veuillez saisir un nombre entre {0:0.#} et {1:0.#}", inf, sup);
                monChoix = int.Parse(Console.ReadLine());
                compteur++;
                if (monChoix == ordi)
                {
                    test = true;
                }
                else if (monChoix < ordi)
                {
                    inf = monChoix;
                }
                else
                {
                    sup = monChoix;
                }
               

            } while (test == false) ;
               
            Console.WriteLine(" Bravo! Vous avez trouvé le nombre : " + monChoix + " en " + compteur + " fois ");

            Console.ReadKey();
        }
    }
}
