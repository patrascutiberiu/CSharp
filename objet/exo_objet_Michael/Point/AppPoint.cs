using System;

namespace Point
{
    /// <summary>
    /// Exercice de gestion des coordonnées d'un Point.
    /// </summary>
    class AppPoint
    {
        /// <summary>
        /// Point d'entrée du programme
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Décclaration d'un Point
            Point lePoint = new Point();

            // Affichage du point
            lePoint.Afficher();
            // Déplacement du point
            lePoint.Deplacer(10);
            // Affichage du point
            lePoint.Afficher();

            // Déclaration du point2
            Point lePoint2 = new Point(10, 20);
            lePoint2.Afficher();

            // Déplacmeent du point2
            lePoint2.Deplacer(5, 10);
            // Affichage du point2
            lePoint2.Afficher();
            

            // Symétrie du point2 par rapport à l'axe des abcisses
            Point lePointPoint = lePoint2.SymX();
            lePointPoint.Afficher();

            // Symétrie du point2 par rapport à l'axe des abcisses
            Point lePointPoint2 = lePoint2.SymY();
            lePointPoint2.Afficher();

            // Symétrie du point3 par rapport à l'axe des ordonnées
            Point lePointPoint3 = lePoint2.SymOrigine();
            lePointPoint3.Afficher();

            // ON permute Abcisses et ordonnée
            lePoint2.PermuteXY();
            lePoint2.Afficher();

            // Fin du programme
            Console.ReadLine();
        }
    }
}
