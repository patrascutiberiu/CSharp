using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrepots
{
    class Entrepots
    {
        public string entrepot;
        public string nom;
        public int colisH;


        public void  initEntrepots(string _entrepot, string _nom, int _colisH)
        {
            this.entrepot = _entrepot;
            this.nom = _nom;
            this.colisH = _colisH;

        }
        public Entrepots(string _entrepot, string _nom, int _colisH)
        {
            this.entrepot = _entrepot;
            this.nom = _nom;
            this.colisH = _colisH;

        }
        public Entrepots()
        {

        }
        public void affichage()
        {
            Console.WriteLine("Dans l'entrepôt : " + entrepot + " la personne : " + nom + " a trié "+ colisH+ " colis/heure . ");
        }
        public void affichage2()
        {

            Console.WriteLine("Dans l'entrepôt : " + entrepot + " sont trié " + colisH + " colis/heure . ");

        }
    }
}
