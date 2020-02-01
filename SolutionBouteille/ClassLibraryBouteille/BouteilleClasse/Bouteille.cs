using ClassLibraryBouteille.ExceptionsBouteille;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        private int contenanceMaxEnMl;
        private int contenanceCouranteEnMl;
        private bool ouvert;

        public int ContenanceMaxEnMl
        {
            get
            {
                return contenanceMaxEnMl;
            }

            //set
            //{
            //    contenanceMaxEnMl = value;
            //}
        }

        public int ContenanceCouranteEnMl
        {
            get
            {
                return contenanceCouranteEnMl;
            }

            //set
            //{
            //    contenanceCouranteEnMl = value;
            //}
        }

        public bool Ouvert
        {
            get
            {
                return ouvert;
            }

            //set
            //{
            //    ouvert = value;
            //}
        }

        //constructeur par default
        public Bouteille()
        {
            contenanceMaxEnMl = 1000;
            contenanceCouranteEnMl = 1000;
            ouvert = false;
        }

        //constructeur parametre ou surcharge
        public Bouteille(int _contenanceMaxEnMl, int _contenanceCouranteEnMl, bool _ouvert)
        {
            this.contenanceMaxEnMl = _contenanceMaxEnMl;
            this.contenanceCouranteEnMl = _contenanceCouranteEnMl;
            this.ouvert = _ouvert;
        }

        //copie constructeur parametre
        public Bouteille(Bouteille bouteilleACopier) : this(bouteilleACopier.ContenanceMaxEnMl, bouteilleACopier.ContenanceCouranteEnMl, bouteilleACopier.Ouvert)
        {

        }
        public void Ouvrir()
        {
            if (!ouvert)
            {
                ouvert = true;
            }
        }
        public void Fermer()
        {
            ouvert = false;
        }
        public bool Vider(int _quantite)
        {
            if (!ouvert)
            {
                throw new ImpossibleDeViderBouteilleFerme();
            }
            else if (ContenanceCouranteEnMl - _quantite <0)
            {
                contenanceCouranteEnMl = 0;
                throw new ImpossibleDeViderBouteilleMin();
            }
            else
            {
                if (contenanceCouranteEnMl < _quantite)
                {
                    contenanceCouranteEnMl -= _quantite;
                    return true;
                }
            }
            return false;
        }
        public void Vider()
        {
            Vider(contenanceCouranteEnMl = 0);
        }
        public bool Remplir(int _quantite)
        {
            if (!ouvert)
            {
                throw new ImpossibleDeRemplirBouteilleFerme();
            }
            else if (contenanceCouranteEnMl+_quantite >contenanceMaxEnMl)
            {
                throw new ImpossibleDeRemplirBouteilleMax();
            }
            else
            {
                if ((contenanceCouranteEnMl + _quantite) <= contenanceMaxEnMl && ouvert)
                {
                    contenanceCouranteEnMl += _quantite;
                    return true;
                }
            }
            return false;
        }
        public void Remplir()
        {
            Remplir(contenanceMaxEnMl);
        }


    }
}
