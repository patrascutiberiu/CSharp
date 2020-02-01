using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrepot_preramplis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = false;
            int choix;
          

            List<tableau> listeTableau = new List<tableau>();
            tableau monTableau;
            monTableau = new tableau(1, " Frais", "Francisco", 65);
            listeTableau.Add(monTableau);
            monTableau = new tableau(1, " Frais", "Sebastien", 45);
            listeTableau.Add(monTableau);
            monTableau = new tableau(1, " Frais", "Adrien", 35);
            listeTableau.Add(monTableau);
            monTableau = new tableau(2, " Epicerie", "David", 99);
            listeTableau.Add(monTableau);
            monTableau = new tableau(2, " Epicerie", "Gabriel", 30);
            listeTableau.Add(monTableau);
            monTableau = new tableau(3, " Pondéreaux", "Tiberiu", 121);
            listeTableau.Add(monTableau);
            monTableau = new tableau(3, " Pondéreaux", "François", 61);
            listeTableau.Add(monTableau);
            monTableau = new tableau(3, " Pondéreaux", "Jack", 88);
            listeTableau.Add(monTableau);
            monTableau = new tableau(3, " Pondéreaux", "Pierre", 75);
            listeTableau.Add(monTableau);

            foreach (tableau i in listeTableau)
            {
                i.affichage();
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Dans quel entrepôt voulez-vous calculer la productivité ?");
            Console.WriteLine("[1] pour Frais");
            Console.WriteLine("[2] pour Epicerie");
            Console.WriteLine("[3] pour Pondéreaux");
            do
            {
                
                test = int.TryParse(Console.ReadLine(), out choix);
            } while (!test);

            switch (choix)
            {
                case 1:
                    List<tableau> product = listeTableau.FindAll(monprod => monprod.nrIntrep == 1);
                    break;
                case 2:
                    List<tableau> product2 = listeTableau.FindAll(monprod => monprod.nrIntrep == 2);
                    break;
                case 3:
                    List<tableau> product3 = listeTableau.FindAll(monprod => monprod.nrIntrep == 3);
                    break;
                default:
                    Console.WriteLine("Est-ce que tu as fait tes études ? Ca va dire quoi 1,2 et 3 ?");
                    break;
            }
            Console.WriteLine("--------------------------------------------------------------------------------");

            int nombrePersonne = 0;
            int moyenne = 0;
            foreach (tableau item in listeTableau)
            {
                if (item.nrIntrep == choix)
                {
                    moyenne += item.colisH;
                    nombrePersonne++;
                }
            }
            
            Console.WriteLine("La moyenne de productivité pour votre entrepôt choisit est de : "+moyenne/nombrePersonne);

            Console.ReadKey();
        }
    }
}
