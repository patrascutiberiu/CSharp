using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryVoiture
{
    public class Voiture : ICloneable
    {
        private Moteur sonMoteur;
        private Roue[] rouesVoiture;
        private string marque;
        private string modelle;
        private float quantiteActuelle;
        private float quantiteMax;
        private decimal puissanceVoiture;

        public Moteur SonMoteur
        {
            get
            {
                return sonMoteur;
            }
        }

        public Voiture() : this("Peugeot",
             "307",
             60,
             60,
             90,
            new Moteur(50),
            new Roue("Continental", 15, "4 saisons"),
            new Roue("Continental", 15, "4 saisons"),
            new Roue("Continental", 15, "4 saisons"),
            new Roue("Continental", 15, "4 saisons"))
        {
        }

        private Voiture(string _marque,
            string _modelle,
            float _quantiteActuelle,
            float _quantiteMax,
            decimal _puissance,
            Moteur _sonMoteur,
            Roue _roueAvG,
            Roue _roueAvD,
            Roue _roueArG,
            Roue _roueArD)
        {
            marque = _marque;
            modelle = _modelle;
            quantiteActuelle = _quantiteActuelle;
            quantiteMax = _quantiteMax;
            puissanceVoiture = _puissance;
            sonMoteur = _sonMoteur;
            rouesVoiture = new Roue[4];
            rouesVoiture[0] = _roueAvG;
            rouesVoiture[1] = _roueAvD;
            rouesVoiture[2] = _roueArG;
            rouesVoiture[3] = _roueArD;
        }


        public Voiture(string _marque,
            string _modelle,
            float _quantiteActuelle,
            float _quantiteMax,
            decimal _puissance,

            string _marqueRoueAvG,
            int _dimRoueAvG,
            string _saisonRoueAvG,

            string _marqueRoueAvD,
            int _dimRoueAvD,
            string _saisonRoueAvD,

            string _marqueRoueArG,
            int _dimRoueArG,
            string _saisonRoueArG,


            string _marqueRoueArD,
            int _dimRoueArD,
            string _saisonRoueArD
            )
            : this(_marque,
             _modelle,
            _quantiteActuelle,
            _quantiteMax,
             _puissance,
            new Moteur(_puissance),

            new Roue(_marqueRoueAvG,
            _dimRoueAvG,
            _saisonRoueAvG),

            new Roue(_marqueRoueAvD,
             _dimRoueAvD,
             _saisonRoueAvD),

            new Roue(_marqueRoueArG,
             _dimRoueArG,
             _saisonRoueArG
             ),

            new Roue(_marqueRoueArD,
             _dimRoueArD,
             _saisonRoueArD))
        {

        }

        public Voiture(Voiture _voitureACopie)
            : this(_voitureACopie.marque,
                  _voitureACopie.modelle,
                  _voitureACopie.quantiteActuelle,
                  _voitureACopie.quantiteMax,
                  _voitureACopie.puissanceVoiture,
                  new Moteur(_voitureACopie.sonMoteur),
                  new Roue(_voitureACopie.rouesVoiture[0]),
                  new Roue(_voitureACopie.rouesVoiture[1]),
                  new Roue(_voitureACopie.rouesVoiture[2]),
                  new Roue(_voitureACopie.rouesVoiture[3]))
        {

        }

        public object Clone()
        {
            return new Voiture(this);
        }

        public bool ArreterVoiture()
        {
            if (sonMoteur.EnMarche == true)
            {
                rouesVoiture[3].ArreterRoue();
                return false;
            }
            else
            {
                rouesVoiture[3].AvancerRoue();
                return true;
            }

        }

        public bool AvancerVoiture()
        {
            if (sonMoteur.EnMarche == false)
            {
                rouesVoiture[3].ArreterRoue();
                return false;
            }
            else
            {
                rouesVoiture[3].AvancerRoue();
                return true;
            }
        }

        public bool DemarrerVoiture()
        {
            if (quantiteActuelle > 0)
            {
                quantiteActuelle = quantiteActuelle - (float)1 / 10;
                sonMoteur.DemarrerMoteur();
                rouesVoiture[3].ArreterRoue();
                return true;
            }
            return false;
        }

        public bool AjouterLEssence(float _quantite)
        {
            if (quantiteActuelle + _quantite > quantiteMax)
            {
                return false;
            }
            else
            {
                quantiteActuelle += _quantite;
                return true;
            }
        }

        public float FaireLePlain()
        {
            float quantiteAPayer;
            quantiteAPayer = quantiteMax - quantiteActuelle;
            quantiteActuelle = quantiteMax;
            return quantiteAPayer;
        }

        public override string ToString()
        {
            return "Marque " + marque + " \nModelle " + modelle + " \nVolume actuel d'essence " + quantiteActuelle +
                " l \nCapacite maximum reservoir " + quantiteMax + " l \nLa puissance est de " + puissanceVoiture + " KW\n";
        }

        //public void Afficher()
        //{
        //    Console.WriteLine("Marque " + marque + " \nModelle " + modelle + " \nVolume actuel d'essence " + quantiteActuelle +
        //        " l \nCapacite maximum reservoir " + quantiteMax + " l \nLa puissance est de " + puissance + " KW\n");

        //}


    }
}
