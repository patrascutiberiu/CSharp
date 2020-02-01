using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBanque
{
    class CompteBancaire
    {
        /// <summary>
        /// Numero de compte
        /// </summary>
        string numero;

        /// <summary>
        /// Nom du titulaire du compte
        /// </summary>
        string nom;

        /// <summary>
        /// Solde du compte
        /// </summary>
        double solde;

        /// <summary>
        /// Découvert autorisé sur ce compte
        /// La valeur est la valeur minimum possible du solde du compte
        /// Exemple: Pour un découvert autorisé de 100€, la valeur sera "-100".
        /// </summary>
        int decouvert = 0;

        /// <summary>
        /// Accesseur pour l'attribut "decouvert"
        /// Permet de spécifier l'autorisation de découvert depuis l'extérieur de la classe
        /// </summary>
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

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="_numero">Numéro du compte</param>
        /// <param name="_nom">Nom du titulaire</param>
        /// <param name="_solde">Solde initial</param>
        public CompteBancaire(string _numero, string _nom, double _solde = 0)
        {
            numero = _numero;
            nom = _nom;
            solde = _solde;
        }

        /// <summary>
        /// Informations du compte
        /// </summary>
        /// <returns>Une chaine de caractère représentant les informations du compte</returns>
        public string Afficher()
        {
            return "Nom : " + nom + " Numéro de compte : " + numero + " Solde : " + solde;
        }

        /// <summary>
        /// Crédite le compte d'un certain montant
        /// </summary>
        /// <param name="_montant">Le montant à créditer sur le compte (la valeur doit être positive)</param>
        public void Crediter(double _montant)
        {
            if (_montant > 0)
            {
                solde += _montant;
            }
        }

        /// <summary>
        /// Débiter le compte d'un montant donné
        /// </summary>
        /// <param name="_montant">Montant à débiter</param>
        /// <returns>True si le débit a été accepté ou false si le débit est refusé</returns>
        public bool Debiter(double _montant)
        {
            if (_montant > 0 && (solde - _montant > decouvert))
            {
                solde -= _montant;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Transfère un montant du compte actuel vers le compte spécifié en paramètre
        /// </summary>
        /// <param name="_montant">Le montant à transférer</param>
        /// <param name="_autreCompte">Le compte créditeur du transfert</param>
        /// <returns></returns>
        public bool Transferer(double _montant, CompteBancaire _autreCompte)
        {
            if (this.Debiter(_montant)) // Si le débit du montant du compte actuel est accepté
            {
                _autreCompte.Crediter(_montant); // Alors on crédite le compte destinataire
                return true;
            }
            return false;
        }

        /// <summary>
        /// Compare les soldes du compte acutel avec celui du compte envoyé en paramètre
        /// </summary>
        /// <param name="_autreCompte">Le compte à comparer</param>
        /// <returns>True si le solde du compte acutel est supérieur à _autreCompte. Sinon, False</returns>
        public bool Comparer(CompteBancaire _autreCompte)
        {
            return (solde > _autreCompte.solde);
        }
    }
}
