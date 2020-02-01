using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_boucle_michael
{
    class Program
    {
        /// <summary>
        /// Point d'entrée du programme
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Appel de la méthode statique "ExempleNombres"
            ExempleNombres();

            // Appel de la méthode statique "ExempleLettres"
            ExempleLettres();

            Console.ReadLine();
        }

        static void ExempleNombres()
        {
            // Initialisation d'un tableau de 10 entiers (int)
            int[] nombres = new int[10];

            // On boucle sur le tableau
            for (int i = 0; i < nombres.Length; i++)
            {
                // On attribue la valeur à l'entrée courante du tableau
                nombres[i] = i + 1;
            }



            Console.WriteLine(Environment.NewLine + "Nombres - FOR");

            // On boucle sur le tableau
            // A chaque itération, "i" est incrémenté de 1
            // La boucle s'arrête dès que "i" respecte la condition [i < nombres.Length]
            for (int i = 0; i < nombres.Length; i++)
            {
                // Affichage de l'indice (i) et de la valeur associée (nombres[i])
                Console.WriteLine(i + " = " + nombres[i]);
            }



            Console.WriteLine(Environment.NewLine + "Nombres - FOREACH");

            // On boucle sur le tableau sans se soucier de l'indice
            // A chaque itération, la valeur du tableau est stockée dans la variable "chiffre"
            // Cette variable est directement utilisable dans la boucle
            foreach (int chiffre in nombres)
            {
                // Affichage de la valeur de l'entrée courante du tableau 
                // (stockée dans la variable "chiffre")
                Console.WriteLine("Chiffre = " + chiffre);
            }



            Console.WriteLine(Environment.NewLine + "Nombres - WHILE");

            // Initialisation de l'indice pour la boucle while
            int j = 0;

            // On boucle sur le tableau tant que "j" est inférieur à la longueur du tableau.
            // La boucle s'arrête dès que la condition du while n'est plus respectée.
            while (j < nombres.Length)
            {
                // Affichage de l'indice et de la valeur actuelle.
                Console.WriteLine(j + " = " + nombres[j]);
                // Incrémentation de "j"
                j++;
            }
        }


        static void ExempleLettres()
        {

            // Lettre de départ
            char maLettre = 'a';

            // Initialisation d'un tableau de 26 caractères (char)
            char[] alphabet = new char[26];

            // Pour chaque élément du tableau
            for (int i = 0; i < alphabet.Length; i++)
            {
                // on attribue la valeur de "maLettre" à l'entrée actuelle du tableau
                // puis on incrémente maLettre
                // L'incrémentation des caractères fonctionne de la même manière que pour les chiffres
                alphabet[i] = maLettre++;
            }



            /*
             * LES BOUCLES SUIVANTES FONCTIONNENT DE LA MEME MANIERE 
             * QUE L'EXEMPLE DES NOMBRES CI-DESSUS
             */

            Console.WriteLine(Environment.NewLine + "Lettres - FOR");

            for (int i = 0; i < alphabet.Length; i++)
            {
                Console.WriteLine(i + " = " + alphabet[i]);
            }




            Console.WriteLine(Environment.NewLine + "Lettres - FOREACH");

            foreach (char lettre in alphabet)
            {
                Console.WriteLine("Lettre = " + lettre);
            }



            Console.WriteLine(Environment.NewLine + "Lettres - WHILE");

            int j = 0;

            while (j < alphabet.Length)
            {
                Console.WriteLine(j + " = " + alphabet[j]);
                j++;
            }
        }
    }
}
