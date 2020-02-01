using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanque
{
    public class Compte
    {
        private int numero;
        private string nom;
        private double solde;
        private int decouvertAutorise;

        public string Nom
        {
            get { return nom; }
        }

        public int Numero
        {
            get { return numero; }
        }

        public double Solde
        {
            get { return solde; }
        }

        public int DecouvertAutorise
        {
            get { return decouvertAutorise; }
        }

        public Compte()
        {
            Random aleas = new Random();
            numero = aleas.Next(10000, 100000);
            nom = "Compte Technique";
            solde = 0;
            decouvertAutorise = 0;
        }

        public Compte(int _numero, string _nom, double _solde, int _decouvertAutorise)
        {
            numero = _numero;
            nom = _nom;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }
        
        public Compte(Compte copieCompte)
            :this (copieCompte.numero, copieCompte.nom, copieCompte.solde, copieCompte.decouvertAutorise)
        {

        }

        public override string ToString()
        {
            return "Nom :" + nom + " \tNuméro de compte : " + numero + " \tSolde : " + solde + " \tDecouvert autorise : " + decouvertAutorise;

        }

        public void Crediter(double _montant)
        {
            solde += _montant;
        }

        public bool Debiter(double _montant)
        {
            if (_montant > 0 && (solde - _montant > decouvertAutorise))
            {
                solde -= _montant;
                return true;
            }
            return false;

        }

        public bool Transferer(double _montant, Compte _autreCompte)
        {
            if (Debiter(_montant))
            {
                _autreCompte.Crediter(_montant);
                return true;
            }
            return false;
        }

        public bool Comparer(Compte _autreCompte)
        {
            return (solde > _autreCompte.solde);
        }
    }
}
