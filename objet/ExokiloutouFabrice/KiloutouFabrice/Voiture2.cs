using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiloutouFabrice
{
    class Voiture2 : vehicule
    {
        public Voiture2(int _serie, string _marque, string _modele, DateTime _miseEnCircu)
        {
            this.NumeroSerie = _serie;
            this.Marque = _marque;
            this.Modèle = _modele;
            this.MiseCircul = _miseEnCircu;
        }
        public Voiture2()
        {
        }
    }
}
