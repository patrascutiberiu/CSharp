using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int N = 0;
            bool saisieN = false;
            int compteur = 0;
            bool recherche = false;
            int nombresaisi;

            do
            {
                Console.WriteLine(" Combien de nombre suhaitez vous saisir ? ");
                try
                {
                    N = int.Parse(Console.ReadLine());
                    saisieN = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);

                }
            } while (!saisieN);

            int[] tableau = new int[N];

            for (int i = 0; i < N; i++)
            {
                try
                {
                    Console.Write(" veuillez saisir la valeur de la cellule n° {0} : ", i+1);
                    tableau[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }

            Array.Sort(tableau);
            Console.Write(" Veuillez saisir un nombre : ");
            nombresaisi = int.Parse(Console.ReadLine());
            for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i].Equals(nombresaisi))
                {
                    compteur++;
                    Console.WriteLine("L'occurence numéro {2} du nommbre {0} a été trouvé dans le tableau, à la position {1}", nombresaisi ,i+1, compteur);
                    recherche = true;

                }
            }
            if (!recherche)
            {
                Console.WriteLine(" Le nombre n'a pas été trouvé dans le tableau ");
            }

            Console.ReadKey();
        }
    }
}
