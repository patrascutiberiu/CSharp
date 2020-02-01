using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Today;
            DateTime DateNaissance;
            bool test = false;

            DateTime a = DateTime.Today;
            Console.WriteLine("Aujurd'hui on est le : " + a.ToString("D") + " ! ");
            Console.WriteLine("=================================================");
            do
            {
                Console.WriteLine("Veuillez saisir votre date de naissance en format (jj/mm/aaaa) : ");
                test = DateTime.TryParse( Console.ReadLine(), out DateNaissance);
            } while (!test);

            //int compare = DateTime.Compare(d, DateNaissance.AddYears(18));
            int compare = d.CompareTo(DateNaissance.AddYears(18));

            if (compare == 1)
            {
                Console.WriteLine("Vous êtes majeur !");
            }
            if (compare == 0)
            {
                Console.WriteLine("\t ------ JOYEUX ANNIVERSAIRE !!! ------ ");
            }
            if (compare == -1)
            {
                Console.WriteLine("Vous êtes mineur !");
            }

            Console.WriteLine("Vous êtes né le : " + DateNaissance.ToString("dddd")+" ! ");

            Console.ReadKey();
        }
    }
}
