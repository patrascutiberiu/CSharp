using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Point
    {
        /// <summary>
        /// Abcisse
        /// </summary>
        int x;

        /// <summary>
        /// Ordonnée
        /// </summary>
        int y;

        /// <summary>
        /// Accesseur pour l'abcisse
        /// </summary>
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        /// <summary>
        /// Accesseur pour l'ordonnée
        /// </summary>
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }


        /// <summary>
        /// Constructeur par défaut. Le point aura pour coordonnées (0,0)
        /// </summary>
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        /// <summary>
        /// Constructeur paramétré
        /// Construit un point avec les coordonnées renseignées
        /// </summary>
        /// <param name="_x">Abscisse</param>
        /// <param name="_y">Ordonnée</param>
        public Point(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }
        
        /// <summary>
        /// Déplace le point
        /// </summary>
        /// <param name="_x">Valeur à ajouter à l'axe des abcisses</param>
        /// <param name="_y">Valeur à ajouter à l'axe des ordonnées</param>
        public void Deplacer(int _x, int _y)
        {
            this.x += _x;
            this.y += _y;
        }

        /// <summary>
        /// Déplace l'abcisse
        /// </summary>
        /// <param name="_x">la valeur à ajouter à l'abcisse actuelle</param>
        public void Deplacer(int _x)
        {
            this.x += _x;
        }

        /// <summary>
        /// affiche les coordonnées du point.
        /// </summary>
        public void Afficher()
        {
            Console.WriteLine(ToString());
        }

        /// <summary>
        /// Surcharge (override) de la méthode ToString()
        /// </summary>
        /// <returns>Coordonnées actuelles du Point</returns>
        public override string ToString()
        {
            //    Console.WriteLine("X = {0}, et Y = {1}",x,y);
            return string.Format("X = {0}, et Y = {1}", x, y);
        }

        /// <summary>
        /// Symétrie du point par rapport à l'axe des abcisses
        /// </summary>
        /// <returns>Une nouvelle instance de Point avec les nouvelles coordonnées</returns>
        public Point SymX()
        {
            Point monPointSym = new Point(x, -y);
            return monPointSym;
        }

        /// <summary>
        /// Symétrie du point par rapport à l'axe des ordonnées
        /// </summary>
        /// <returns>Une nouvelle instance de Point avec les nouvelles coordonnées</returns>
        public Point SymY()
        {
            Point monPointSym = new Point(-x, y);
            return monPointSym;
        }

        /// <summary>
        /// Symétrie du point par rapport au point d'origine (0,0)
        /// </summary>
        /// <returns>Une nouvelle instance de Point avec les nouvelles coordonnées</returns>
        public Point SymOrigine()
        {
            Point monPointSym = new Point(-x, -y);
            return monPointSym;
        }

        /// <summary>
        /// Permutation des abcisses et des ordonnées
        /// </summary>
        public void PermuteXY()
        {
            Point monPointSym = new Point(x, y);
            this.x = monPointSym.y;
            this.y = monPointSym.x;
        }

    }
}
