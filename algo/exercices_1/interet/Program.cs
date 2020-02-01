using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interet
{
    class Program
    {
        static void Main(string[] args)
        {
            double somme_initiale;
            int taux;
            double valeur_acquise;
            double intérêt;


            Console.WriteLine(" Introduisez la somme initiale (en euros): ");
            somme_initiale = double.Parse(Console.ReadLine());
            Console.WriteLine(" Introduisez le taux d'intérêt (ex: 3 pour 3%): ");
            taux = int.Parse(Console.ReadLine());

            intérêt = somme_initiale * taux / 100;
            valeur_acquise = somme_initiale + intérêt;
            Console.WriteLine(" L'intérêt fourni est de " + intérêt + " euros . ");
            Console.WriteLine(" La somme après un an sera de " + valeur_acquise + " euros .");

            Console.ReadKey();
        }
    }
}
