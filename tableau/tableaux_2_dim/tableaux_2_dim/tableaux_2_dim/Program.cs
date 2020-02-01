using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableaux_2_dim
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int n = 0;
            bool formatage = false;
           
            do
            {
                Console.WriteLine("Indiquez le nombre de formation : ");

                try
                {
                    n = int.Parse(Console.ReadLine());
                    formatage = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Votre saisie est erronée, veuillez recommencer . \n " + ex.Message);

                }

            } while (!formatage);

            string[,] tabF = new string[n, 2];

            SaisieFormation(ref tabF);
            SaisieNbreStag(ref tabF);
            Console.Clear();

            Afficher(ref tabF);
            Trie(ref tabF);
            Console.WriteLine("Le tableau des formations trié par ordre croissant est :" + Environment.NewLine);
            Afficher(ref tabF);

            Console.ReadKey();

        }
        private static void Afficher(ref string[,] _tabF)
        {
            for (int i = 0; i < _tabF.GetLength(0); i++)
            {
                Console.WriteLine("\nLa formation : (" + _tabF[i, 0] + ") a " + _tabF[i, 1] + " stagiaire(s) .\n");
            }
        }
        private static void Trie(ref string[,] _tabF)
        {
            string temp;
            bool test = false;
            do
            {
                test = false;
                for (int i = 0; i < _tabF.GetLength(0) - 1; i++)
                {
                    if (Convert.ToInt32(_tabF[i, 1]) > Convert.ToInt32(_tabF[i + 1, 1]))
                    {
                        temp = _tabF[i, 1];
                        _tabF[i, 1] = _tabF[i + 1, 1];
                        _tabF[i + 1, 1] = temp;
                        temp = _tabF[i, 0];
                        _tabF[i, 0] = _tabF[i + 1, 0];
                        _tabF[i + 1, 0] = temp;
                        test = true;
                    }
                }
            } while (!test);
        }
        private static void SaisieFormation(ref string[,] _tabF)
        {
            for (int i = 0; i < _tabF.GetLength(0); i++)
            {
                Console.Write(" Veuillez saisir le nom de la formation numéro  {0} : ", i + 1);
                _tabF[i, 0] = Console.ReadLine();
            }
        }
        private static void SaisieNbreStag(ref string[,] _tabF)
        {
            for (int i = 0; i < _tabF.GetLength(0); i++)
            {
                Console.Write(" Veuillez saisir le nombre de stagiaires pour la formation ( " + _tabF[i, 0] + " ) :");
                _tabF[i, 1] = Console.ReadLine();
            }
        }
    }
}
