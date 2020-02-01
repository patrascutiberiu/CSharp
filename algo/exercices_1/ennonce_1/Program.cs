using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ennonce_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;

            Console.WriteLine("Lecture de l'énnonce");
            Console.WriteLine("Avez-vous compris l'énnoncé ?o/n");
            reponse = Console.ReadLine();
            if (reponse == "n")
            {
                Console.WriteLine("Relecture de l'énnonce");
                Console.WriteLine("Avez-vous compris l'énnonce ?o/n");
                reponse = Console.ReadLine();

                if (reponse == "n")
                {
                    Console.WriteLine("Appel du formateur");
                    Console.WriteLine("Avez vous compris l'ennonce? o/n"); //sortie 1 form
                    Console.WriteLine("Passer à l'énnoncé suivant ! sortie 1 form"); 

                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Passer à l'énnocé suivant ! sortie 2 relecture"); //sortie 2 relecture

                    Console.ReadKey();

                }


            }
            else
            {
                Console.WriteLine("Passer à l'énnocé suivant ! sortie 3 comprehension"); //sortie 3 compréhension
                Console.ReadKey();

            }
        }
    }
}
