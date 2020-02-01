using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objet_fraction
{
    class Fraction
    {
        private int num;
        private int den = 1;
        private int pgcd;
        private const int eu=0;


        public int Numerateur
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }

        public int Denomerateur
        {
            get
            {
                return den;
            }

            set
            {
                den = value;
            }
        }

        public int Pgcd
        {
            get
            {
                return pgcd;
            }

            set
            {
                pgcd = value;
            }
        }

        /// <summary>
        /// constructor parametré
        /// </summary>
        /// <param name="_numerateur">numerateur</param>
        /// <param name="_denomerateur">denomerateur</param>
        public Fraction(int _numerateur, int _denomerateur)
        {
            this.num = _numerateur;
            this.den = _denomerateur;
        }

        /// <summary>
        /// Constructeur fraction vide
        /// </summary>
        public Fraction()
        {

        }

        /// <summary>
        /// constructeur fraction avec numerateur
        /// </summary>
        /// <param name="_numerateur">numerateur</param>
        public Fraction(int _numerateur)
        {
            this.num = _numerateur;
        }

        public override string ToString()
        {
            //String s = num.ToString() + "/" + den.ToString();

            //return s;

            if (den == 1)
            {
                return num.ToString();
            }
            else
            {
                return string.Format(num.ToString() + "/" + den.ToString());
            }
        }


        /// <summary>
        ///  inverse le signe de la fraction
        /// </summary>
        public void Oppose()
        {
            this.num = num * -1;
        }


        /// <summary>
        /// inverse numérateur et dénominateur
        /// </summary>
        public void inverse()
        {
            int t;
            t = num;
            num = den;
            den = t;
        }


        /// <summary>
        /// opérateurs relationnels
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Sup(Fraction a, Fraction b)
        {
            return (decimal)a.num * b.den > (decimal)b.num * a.den;
        }

        public bool Inf(Fraction a, Fraction b)
        {
            return (decimal)a.num * b.den < (decimal)b.num * a.den;
        }

        public bool Egal(Fraction a, Fraction b)
        {
            return (decimal)a.num * b.den == (decimal)b.num * a.den;
        }


        /// <summary>
        /// Plus Grand Diviseur Commun
        /// </summary>
        /// <returns>pgcd</returns>
        public int GetPgcd()
        {

            int a = this.num;
            int b = this.den;

            int pgcd = 1;

            if (a != 0 && b != 0)
            {
                if (a < 0)
                {
                    a = -a;
                }
                if (b < 0)
                {
                    b = -b;
                }
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                    pgcd = a;
                }
            }
            return pgcd;
        }


        /// <summary>
        /// Réduction et signe de la fraction
        /// </summary>
        public void Reduce()
        {
            if (num < 0 && den < 0)
            {
                num = num * -1;
                den = den * -1;
            }
            else if (den < 0)
            {
                num = num * -1;
                den = den * -1;
            }
            int PGCD = this.GetPgcd();
            num = num / PGCD;
            den = den / PGCD;
        }


        /// <summary>
        /// somme
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public Fraction Addition(Fraction a, Fraction b)
        {
            int r1;
            int r2;
            r1 = a.num * b.den + b.num * a.den;
            r2 = a.den * b.den;
            return new Fraction(r1, r2);
        }


        /// <summary>
        /// difference
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public Fraction Soustraction(Fraction a, Fraction b)
        {
            int r1;
            int r2;
            r1 = a.num * b.den - b.num * a.den;
            r2 = a.den * b.den;
            return new Fraction(r1, r2);
        }


        /// <summary>
        /// produit
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public Fraction Produit(Fraction a, Fraction b)
        {
            int r1;
            int r2;
            r1 = a.num * b.num;
            r2 = a.den * b.den;

            return new Fraction(r1, r2);
        }


        public Fraction Division(Fraction a, Fraction b)
        {
            int r1;
            int r2;

            r1 = a.num * b.den;
            r2 = a.den * b.num;
            if (r2 == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return new Fraction(r1, r2);
            }
        }

    }
}
