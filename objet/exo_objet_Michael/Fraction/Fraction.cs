using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction
    {
        private int numerateur = 0;

        private int denominateur = 1;
        
        public int Denominateur
        {
            get
            {
                return denominateur;
            }
        }

        public int Numerateur
        {
            get
            {
                return numerateur;
            }
        }

       
        public Fraction(int _numerateur = 0, int _denominateur = 1)
        {
            numerateur = _numerateur;
            denominateur = _denominateur;
        }

        public void Oppose()
        {
            numerateur = -numerateur;
        }

        public Fraction Inverse()
        {
            if (numerateur==0)
            {
                return this;
            }

            int temp = numerateur;
            numerateur = denominateur;
            denominateur = temp;
            return this;
        }

        protected double Calculer()
        {
            return (double)((double)numerateur / (double)denominateur);
        }

        public Boolean Superieur(Fraction f)
        {
            if (Calculer() > f.Calculer())
            {
                return true;
            }
            return false;
        }

        public Boolean Inferieur(Fraction f)
        {
            return !Superieur(f) && !Egal(f);
            
        }

        /// <summary>
        /// Vérifie l'égalité entre 2 fractions
        /// </summary>
        /// <param name="_f">Une fraction à comparer</param>
        /// <returns>Un nouvelle fraction avec les valeurs calculées</returns>

        public Boolean Egal(Fraction f)
        {
            return (Calculer() == f.Calculer());
        }





        /// <summary>
        /// Réduction de la fraction actuelle
        /// </summary>
        /// <returns>Une nouvelle fraction avec les valeurs calculées</returns>
        public Fraction Reduire()
        {
            return new Fraction((numerateur / GetPgcd()), (denominateur / GetPgcd()));
        }

        /// <summary>
        /// Addition de la fraction par celle envoyée en paramètre
        /// </summary>
        /// <param name="_f">Une fraction</param>
        /// <returns>Une nouvelle fraction avec les valeurs calculées</returns>

        public Fraction Somme(Fraction _f)
        {
            return new Fraction(((this.numerateur * _f.denominateur) + (this.denominateur * _f.numerateur)), (this.denominateur * _f.denominateur));
        }

        /// <summary>
        /// Soustraction de la fraction par celle envoyée en paramètre
        /// </summary>
        /// <param name="_f">Une fraction</param>
        /// <returns>Une nouvelle fraction avec les valeurs calculées</returns>

        public Fraction Difference(Fraction _f)
        {
            return new Fraction(((this.numerateur * _f.denominateur) - (this.denominateur * _f.numerateur)), (this.denominateur * _f.denominateur)) ;
        }

        /// <summary>
        /// Multiplication de la fraction avec celle envoyée en paramètre
        /// </summary>
        /// <param name="_f">Une fraction</param>
        /// <returns>Une nouvelle fraction avec les valeurs calculées</returns>

        public Fraction Produit(Fraction _f)
        {
            return new Fraction((numerateur * _f.denominateur), (denominateur * _f.numerateur));
        }

        /// <summary>
        /// Division de la fraction par celle envoyée en paramètre
        /// </summary>
        /// <param name="_f">Une fraction</param>
        /// <returns>Une nouvelle fraction avec les valeurs calculées</returns>
        public Fraction Quotient(Fraction _f)
        {
            return this.Produit(_f.Inverse());
        }

        /// <summary>
        /// Elévation de la fraction à la puissance donnée
        /// </summary>
        /// <param name="_puissance"></param>
        /// <returns>Une nouvelle fraction avec les nouvelles valeurs calculées</returns>
        public Fraction Puissance(int _puissance)
        {
            return new Fraction((int)Math.Pow(numerateur, _puissance), (int)Math.Pow(denominateur, _puissance)) ;
        }



        /// <summary>
        /// Calcul du PGCD
        /// </summary>
        /// <returns>Le PGCD calculé</returns>
        private int GetPgcd()
        {
            int a = this.Numerateur;

            int b = this.Denominateur;

            int pgcd = -1;

            if (a != 0 && b != 0)
            {
                if (a < 0)
                    a = -a;

                if (b < 0)
                    b = -b;

                while (a != b)
                {
                    if (a < b)
                        b -= a;
                    else
                        a -= b;
                }

                pgcd = a;
            }

            return pgcd;
        }

    }
}
