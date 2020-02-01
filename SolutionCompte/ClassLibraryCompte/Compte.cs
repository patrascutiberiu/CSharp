using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryCompte
{
    public class Compte : ICloneable, IComparable<Compte>, IComparable, IComparer
    {
        private string nom;
        private int numero;
        private double solde;
        private int decouvert;

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
        public string GetNom()
        {
            return nom;
        }
        public void SetNom(string value)
        {
            nom = value;
        }

        public int Numero
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
        public int GetNumero()
        {
            return numero;
        }
        public void SetNumero(int value)
        {
            numero = value;
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
        public double GetSolde()
        {
            return solde;
        }
        public void SetSolde(double value)
        {
            solde = value;
        }

        public int Decouvert
        {
            get
            {
                return decouvert;
            }
            set
            {
                decouvert = value;
            }
        }
        public int GetDecouvert()
        {
            return decouvert;
        }
        public void SetDecouvert(int value)
        {
            decouvert = value;
        }

        public Compte()
        {
            this.nom = "Technique";
            this.numero = 9999;
            this.solde = 0;
            this.decouvert = 0;
        }

        public Compte(string _nom, int _numero, double _solde, int _decouvert)
        {
            this.nom = _nom;
            this.numero = _numero;
            this.solde = _solde;
            this.decouvert = _decouvert;
        }

        public Compte(Compte copieCompte) : this(copieCompte.nom, copieCompte.numero, copieCompte.solde, copieCompte.decouvert)
        {

        }

        public void Crediter(double _montant)
        {
            solde = solde + _montant;
        }

        public bool Debiter(double _montant)
        {
            if (_montant > 0 && (solde - _montant > decouvert))
            {
                solde -= _montant;
                return true;
            }
            return false;
        }

        public bool Transferer(Compte _compteTransfer, double _montant)
        {
            if (Debiter(_montant))
            {
                _compteTransfer.Crediter(_montant);
                return true;
            }
            return false;
        }

        public bool Supperieur(Compte _autreCompte)
        {
            if (solde > _autreCompte.solde)
            {
                return true;
            }
            return false;
        }



        public override string ToString()
        {
            return "Nom proprietaire compte : " + nom + "\nNumero compte : " + numero + "\nSolde : " + solde + "\nDecouvert autorise : " + decouvert + "\n";
        }

        //public void Afficher()
        //{
        //    Console.WriteLine(ToString());
        //}
        //public static void Afficher(bool a)
        //{
        //    Console.WriteLine("Le compte 1 est" + (a ? "superieur" : "inferieur"));
        //}

        public object Clone()
        {
            return new Compte(this);
        }

        public int CompareTo(object obj)
        {
            Compte b = obj as Compte;
            if (b != null)
            {
                return this.Solde.CompareTo(b.Solde);

            }
            else
            {
                throw new ArgumentException();
            }

        }

        public int CompareTo(Compte other)
        {

            return this.Solde.CompareTo(other.Solde);
        }

        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
}
