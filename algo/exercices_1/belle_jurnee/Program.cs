using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belle_jurnee
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;

            Console.WriteLine(" Est-ce qu'il fait beau dehors (o/n)?");
            reponse = Console.ReadLine();

            if (reponse == "n")
            {
                Console.WriteLine(" Je téléphone à Pierre ");
                Console.WriteLine(" Est-ce que Pierre c'est chez lui (o/n) ?");
                reponse = Console.ReadLine();

                if (reponse == "n")
                {
                    Console.WriteLine(" J'écoute de la musique !");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine(" Je vais chez lui en voiture");
                    Console.ReadKey();

                }
            }
            else
            {
                Console.WriteLine(" Je plante les herbes;");
                Console.WriteLine(" J'enleve les mauvais herbes.");
                Console.ReadKey();

            }

        }
    }
}
