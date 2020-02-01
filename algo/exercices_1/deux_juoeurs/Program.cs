using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deux_juoeurs
{
    class Program
    {
        static void Main(string[] args)
        {
            float na, nb, reste;

            Console.WriteLine("Veuillez saisir la valeur de nombre A");
            na = float.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir la valeur de nombre B");
            nb = float.Parse(Console.ReadLine());

            reste = (na + nb) % 2;

            if (reste == 0)

                Console.WriteLine("Le joueur A a gagné.");

            else
                Console.WriteLine("Le joueur B a gagné.");

            Console.WriteLine("Bravo pour le gagnant!");

            Console.ReadKey();
        }
    }
}
