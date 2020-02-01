using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiloutou
{
    class voiture
    {
        private string marque;
        private string modele;
        private int numSerie;


        public string Marque { get => marque; set => marque = value; }
        public string Modele { get => modele; set => modele = value; }
        public int NumSerie { get => numSerie; set => numSerie = value; }

        public void Init_Voiture(string _marque, string _modele, int _numSerie)
        {
            this.marque = _marque;
            this.modele = _modele;
            this.numSerie = _numSerie;
        }
        public voiture(string _marque, string _modele, int _numSerie)
        {
            this.marque = _marque;
            this.modele = _modele;
            this.numSerie = _numSerie;
        }
        public void Affichage()
        {
            Console.WriteLine("Marque : " + marque + " Modele : " + modele + " Numero serie " + numSerie);
            Console.WriteLine();
        }


    }
}
