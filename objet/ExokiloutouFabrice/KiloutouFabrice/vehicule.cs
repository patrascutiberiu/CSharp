using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiloutouFabrice
{
    abstract class vehicule
    {
        private int numeroSerie;
        private string modèle;
        private string marque;
        private DateTime miseCircul;

        public int NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public string Modèle { get => modèle; set => modèle = value; }
        public string Marque { get => marque; set => marque = value; }
        public DateTime MiseCircul { get => miseCircul; set => miseCircul = value; }

        public void affichage()
        {
            Console.WriteLine("marque : " + this.marque + " modele : " + this.modèle + " numSerie : " + this.numeroSerie + "date de mise en circulation : " + this.miseCircul.ToString("d") );
        }

        public void Init_voiture(int _numSerie, string _marque, string _modele)
        {
        }
       


    }
}
