using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_liste_maison
{
    class administration
    {
        private string nom;
        private string prenom;
        private string mail;
        private DateTime dateNaissance;

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

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        public DateTime DateNaissance
        {
            get
            {
                return dateNaissance;
            }

            set
            {
                dateNaissance = value;
            }
        }

        public void admin(string _nom, string _prenom, string _mail, DateTime _dateNaissance)
        {
            this.nom = _nom;
            this.prenom = _prenom;
            this.mail = _mail;
            this.dateNaissance = _dateNaissance;
        }
        public administration(string _nom, string _prenom, string _mail, DateTime _dateNaissance)
        {
            this.nom = _nom;
            this.prenom = _prenom;
            this.mail = _mail;
            this.dateNaissance = _dateNaissance;
        }
        public void affichage()
        {
            Console.WriteLine("Nom : " + nom + " Prenom : " + prenom + " Mail : " + mail + " Date naissance : " + dateNaissance.ToString("d"));
        }
        public administration()
        {

        }


    }
}
