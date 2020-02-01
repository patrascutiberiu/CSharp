using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte_bancaire_test
{
    class Compte
    {
        private string numero;
        private string nom;
        private double solde;
        private int decouvertAutorise;

        public string Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public double Solde
        {
            get
            {
                return solde;
            }

            set
            {
                solde = value;
            }
        }

        public int DecouvertAutorise
        {
            get
            {
                return decouvertAutorise;
            }

            set
            {
                decouvertAutorise = value;
            }
        }



        /// <summary>
        /// Constructeur
        /// </summary>
        public Compte()
        {

        }

        /// <summary>
        /// Constructeur parametré
        /// </summary>
        public Compte(string _numero, string _nom, double _solde, int _decouvertAutorise)
        {
            numero = _numero;
            nom = _nom;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }

        public void Afficher()
        {
            Console.WriteLine();
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return string.Format("Nom : " + nom + "\tNuméro du compte : " + numero.ToString() + "\tSolde : " + solde.ToString() + "\tDecouvert : " + decouvertAutorise);
        }



        public bool Crediter(double _montant)
        {
            if (_montant > 0)
            {
                solde += _montant;
                return true;
            }
            return false;
        }

        public bool Debiter(double _montant)
        {
            if (_montant > 0 && (solde - _montant >= decouvertAutorise))
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

        public bool Superieur(Compte _autreCompte)
        {
            if (solde > _autreCompte.solde)
            {
                return true;
            }
            return false;
        }

        public static void Afficher(bool f)
        {
            Console.WriteLine(f ? "superieur" : "inferieur");
        }


    }
}
