using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belle_journee_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;

            Console.WriteLine("Est-ce qu'il fait beau aujourd'hui dehors ? (o/n) ");
            reponse = Console.ReadLine();

            if (reponse == "n")
            {
                Console.WriteLine(" Je consacrerai ma journée à la lecture ;");
                Console.WriteLine(" J'aimerais relire 'Madame Bovary' . ");
                Console.WriteLine(" Est-ce que je retrouverai ce livre dans la bibliothèque du salon ? (o/n)");
                reponse = Console.ReadLine();

                if (reponse == "n")
                    Console.WriteLine(" J'irai à la bibliothèque municipale .");


                if (reponse == "n")
                {
                    Console.WriteLine(" Est-ce que je retrouverai ce livre dans la bibliothèque municipale ? (o/n)");
                    reponse = Console.ReadLine();

                }
                if (reponse == "n")
                {
                    Console.WriteLine(" J'emprunterai un bouquin policier .");
                    Console.WriteLine(" Je rentrerai ensuite directement à la maison; ");
                    Console.WriteLine(" \t -Je m'installerai confortablement dans un fauteuil, ");
                    Console.WriteLine("\t -Je me plongerai dans la lecture. ");
                    reponse = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine(" Je rentrerai ensuite directement à la maison; ");
                    Console.WriteLine(" \t -Je m'installerai confortablement dans un fauteuil, ");
                    Console.WriteLine("\t -Je me plongerai dans la lecture. ");
                    Console.ReadKey();

                }

            }
            else
            {

                Console.WriteLine(" J'irai faire une balade à bicyclette .");
                Console.WriteLine(" Est-ce que ma bicyclette est-elle en parfait état ? (o/n)");
                reponse = (Console.ReadLine());

                if (reponse == "n")
                {

                    Console.WriteLine(" Je passerai chez le garagiste avant la balade");
                    Console.WriteLine(" Est-ce que les réparations seront immédiates ? (o/n)");
                    reponse = Console.ReadLine();

                    if (reponse == "o")
                    {
                        Console.WriteLine(" Je me balade avec ma bicyclette!");
                        Console.ReadKey();
                    }

                    if (reponse == "n")
                    {
                        Console.WriteLine(" Je devrai renoncer à la balade en bicyclette;");
                        Console.WriteLine(" J'irai à pied jusqu'à l'étang pour cueillir les joncs.");
                        Console.ReadKey();

                    }
                }
                else
                {
                    Console.WriteLine(" Je me balade avec ma bicyclette!");
                    Console.ReadKey();
                }

            }
        }
    }
}
