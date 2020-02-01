using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interet_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double s;
            int n;
            double i;
            int reponse = 0;
            double valeuraquise;
            bool testnb;


            Console.WriteLine("Combien souhaitez vous placer?");
            s = double.Parse(Console.ReadLine());
            Console.WriteLine("Souhaitez vous placer argent sur un compte bloqué (intérêt compose):1 ou sur un compte rémunéré( intérêt simple):2 ?");
            testnb = int.TryParse(Console.ReadLine(), out reponse);

            if (reponse == 1 && testnb == true)
            {
                Console.Write("Combien d'année de placement?");
                n = int.Parse(Console.ReadLine());
                Console.Write("Quel est le taux de placement? %");
                i = double.Parse(Console.ReadLine());

                valeuraquise = s * Math.Pow((1 + (i / 100)), n);
                double gain = valeuraquise - s;

                valeuraquise = Math.Round(valeuraquise, 2);
                gain = Math.Round(gain, 2);

                Console.WriteLine("La valeure acquise sera " + valeuraquise + "euros. Vous aurez gagné à l'issue de " + n + "années:" + gain + "euros");
                Console.ReadKey();
            }
            else if (reponse == 2 && testnb == true)
            {
                Console.Write("Combien d'année de placement?");
                n = int.Parse(Console.ReadLine());
                Console.Write("Quel est le taux de placement? %");
                i = double.Parse(Console.ReadLine());

                valeuraquise = s * (1 + n * (i / 100));
                double gain = valeuraquise - s;

                valeuraquise = Math.Round(valeuraquise, 2);
                gain = Math.Round(gain, 2);

                Console.WriteLine(" La valeur acquise sera " + valeuraquise + "euros. Vous aurez gagné à l'issue de " + n + "années:" + gain + " euros");
                Console.ReadKey();

            }
            else if (reponse != 1 & reponse != 2 & testnb == true)
            {
                Console.WriteLine(" erreur le nombre saisi doit-être 1 ou 2! ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Veuillez taper un nombre svp !");
                Console.ReadKey();
            }
        }
    }
}
