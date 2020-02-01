using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinthe
{
    class Program
    {
        static void Main(string[] args)
        {
            string mur = null;
            string sortie = null;

            Console.WriteLine("Sortie attente (o/n)?");
            sortie = Console.ReadLine();

            while (sortie == "n")
            {
                Console.WriteLine("Tournez à gauche");

                Console.WriteLine("Mur devant (o/n)?");
                mur = Console.ReadLine();

                if (mur == "o")
                    Console.WriteLine("Tournez à droite");
                Console.WriteLine("Mur devant (o/n)?");
                mur = Console.ReadLine();

                if (mur == "o")
                    Console.WriteLine("Tournez à droite");
                Console.WriteLine("Mur devant (o/n)?");
                mur = Console.ReadLine();

                if (mur == "o")
                    Console.WriteLine("tournez à droite");

                Console.WriteLine("Avancer d'une case");

                Console.WriteLine("Sortie atteint (o/n)?");
                sortie = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
