using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte_bancaire
{
    class Compte
    {
        private int numero;
        private string nom;
        private double solde=0;
        private int decouvertAutorise;

        public int Numero
        {
            get
            {
                return numero;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }
        }

        public double Solde
        {
            get
            {
                return solde;
            }
        }

        public int DecouvertAutorise
        {
            get
            {
                return decouvertAutorise;
            }
        }



        /// <summary>
        /// Constructeur
        /// </summary>
        public Compte()
        {
            Random aleas = new Random();
            numero = aleas.Next(10000, 100000);
            nom = "Compte Technique";
            solde = 0;
            decouvertAutorise = 0;
            
        }

        /// <summary>
        /// Constructeur parametré
        /// </summary>
        public Compte(int _numero, string _nom, double _solde , int _decouvertAutorise)
        {
            numero = _numero;
            nom = _nom;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;

        }

        public void Afficher()
        {
            
            Console.WriteLine(ToString());
            Console.WriteLine();
        }

        public override string ToString()
        {
            return string.Format("Nom : " + nom + "\tNuméro du compte : " + numero.ToString() + "\tSolde : " + solde.ToString() + "\tDecouvert : " + decouvertAutorise.ToString());
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
            Console.WriteLine();
            Console.WriteLine("le compte 1 est "+(f ? "superieur" : "inferieur"));
        }

    }
}
