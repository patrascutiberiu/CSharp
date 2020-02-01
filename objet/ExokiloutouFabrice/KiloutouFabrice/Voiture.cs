using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiloutouFabrice
{
    class Voiture
    {
        //public int numSerie;  
        //public  string marque;
        //public  string modele;

        private int numSerie;
        private string marque;
        private string modele;

        public int NumSerie
        {
            get
            {
                return numSerie;
            }

            set
            {
                numSerie = value;
            }
        }

        public string Marque
        {
            get
            {
                return marque;
            }

            set
            {
                marque = value;
            }
        }

        public string Modele
        {
            get
            {
                return modele;
            }

            set
            {
                modele = value;
            }
        }

        public void Init_voiture(int _numSerie, string _marque, string _modele)
        {
           numSerie = _numSerie;
           marque = _marque;
           modele = _modele;
        }
        public void Affichage()
        {
            Console.WriteLine("marque : " + marque + " modele : " + modele + " numSerie :" + numSerie);
        }

        public Voiture(int _numSerie, string _marque, string _modele)
        {
            numSerie = _numSerie;
            marque = _marque;
            modele = _modele;
        }

        public Voiture()
        {

        }
        

    }
}
