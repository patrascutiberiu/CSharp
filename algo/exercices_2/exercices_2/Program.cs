using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercices_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int chiffres;
            int compteur = 0;
            int compteur2 = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write(" Veuillez donner l'âge de la personne numero {0:0} s'il vous plaît :",i+1);
                chiffres = int.Parse(Console.ReadLine());

                if (chiffres < 20)
                {
                    //Console.WriteLine(" La PERSONNE a MOINS DE 20 ANS ! " );
                    compteur++;
                }
                else
                {
                    //Console.WriteLine(" La PERSONNE a PLUS DE 20 ANS ! " );
                    compteur2++;
                }
            }
            if (compteur== 20 )
            {
                Console.WriteLine("TOUTES LES PERSONNES ONT MOINS DE 20 ANS !");
            }
            else if (compteur == 0)
            {
                Console.WriteLine(" Toutes les personnes ont 20 ans ou plus.");
            
            }
            else
            {
                Console.WriteLine("Les nombres de jeunes est : {0:0} ", compteur);
            }

            Console.ReadKey();

        }
    }
}
