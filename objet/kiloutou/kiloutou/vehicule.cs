using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiloutou
{
    abstract class vehicule
    {
        private string marque;
        private string modele;
        private int numSerie;
        private DateTime miseEnCirculation;

        public string Marque { get => marque; set => marque = value; }
        public string Modele { get => modele; set => modele = value; }
        public int NumSerie { get => numSerie; set => numSerie = value; }
        public DateTime MiseEnCirculation { get => miseEnCirculation; set => miseEnCirculation = value; }
    }
}
