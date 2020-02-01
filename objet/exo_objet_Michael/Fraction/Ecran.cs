using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Ecran
    {
        /// <summary>
        /// Affichage d'une Fraction
        /// </summary>
        /// <param name="f"></param>
        public static void Affiche(Fraction f)
        {
            if (f.Denominateur!=1)
            {
                Console.WriteLine(f.Numerateur + "/" + f.Denominateur);
            }
            else
            {
                Console.WriteLine(f.Numerateur);
            }

        }


        /// <summary>
        /// Affichage d'un Booleen au format "human readable"
        /// </summary>
        /// <param name="f"></param>
        public static void Affiche(bool f)
        {
            Console.WriteLine(f ? "vrai" : "faux");
        }

        /// <summary>
        /// Affichage d'une ligne vide (WTF?)
        /// </summary>
        public static void Affiche()
        {
            Console.WriteLine();
        }
    }
}
