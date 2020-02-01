using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiloutou
{
    class voiture2 : vehicule
    {

        public void Init_Voiture(string _marque, string _modele, int _numSerie, DateTime _miseEnCirculation)
        {
            this.Marque = _marque;
            this.Modele = _modele;
            this.NumSerie = _numSerie;
            this.MiseEnCirculation = _miseEnCirculation;
        }
        public voiture2(string _marque, string _modele, int _numSerie,DateTime _miseEnCirculation)
        {
            this.Marque = _marque;
            this.Modele = _modele;
            this.NumSerie = _numSerie;
            this.MiseEnCirculation = _miseEnCirculation;
        }
        public void Affichage2()
        {
            Console.WriteLine("Marque : " + Marque + " Modele : " + Modele + " Numero serie " + NumSerie+ " Date de mise en circulation: "+ MiseEnCirculation.ToString("d"));
            Console.WriteLine();

        }

    }
}
