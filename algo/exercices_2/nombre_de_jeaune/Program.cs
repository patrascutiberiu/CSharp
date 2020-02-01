using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombre_de_jeaune
{
    class Program
    {
        static void Main(string[] args)
        {
            int chiffres;
            int compteur = 0;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("entrer votre age : ");
                chiffres = int.Parse(Console.ReadLine());
                if (chiffres < 20)
                {
                    compteur++;
                }

            }
            Console.WriteLine(" les personnes inferieures à vingt ans : {0:0} ", compteur);

            Console.ReadKey();
        }
    }
}
