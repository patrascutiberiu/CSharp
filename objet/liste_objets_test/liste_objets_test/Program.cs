using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_objets_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            List<voiture> listeVoiture = new List<voiture>();
            voiture maVoiture;
            maVoiture = new voiture("Peugeot", "307", 2098);
            listeVoiture.Add(maVoiture);
            maVoiture = new voiture("Renault", "Espace", 1987);
            listeVoiture.Add(maVoiture);
            maVoiture = new voiture("Lancia", "Dadra", 1203);
            listeVoiture.Add(maVoiture);
            maVoiture = new voiture("BMW", "324d", 3049);
            listeVoiture.Add(maVoiture);
            maVoiture = new voiture("Peugeot", "406", 1500);
            listeVoiture.Add(maVoiture);
            maVoiture = new voiture("Ford", "Mondeo", 2500);
            listeVoiture.Add(maVoiture);
        }
    }
}
