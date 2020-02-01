using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrepot_preramplis
{
    class tableau
    {
        public string entrepot;
        public string nom;
        public int colisH;
        public int nrIntrep;

        public void init_tableau(int _nrIntrep,string _entrepot, string _nom, int _colisH)
        {
            this.nrIntrep = _nrIntrep;
            this.entrepot = _entrepot;
            this.nom = _nom;
            this.colisH = _colisH;

        }
        public tableau(int _nrIntrep,string _entrepot, string _nom, int _colisH)
        {
            this.nrIntrep = _nrIntrep;
            this.entrepot = _entrepot;
            this.nom = _nom;
            this.colisH = _colisH;

        }
        public void affichage()
        {
            Console.WriteLine("Dans l'entrepôt : "+nrIntrep + entrepot + " la personne : " + nom + " a trié " + colisH + " colis/heure . ");

        }
        public void affichage2()
        {
            
            Console.WriteLine("Dans l'entrepôt : " + nrIntrep + entrepot + " sont trié " + colisH + " colis/heure . ");

        }

    }
}
