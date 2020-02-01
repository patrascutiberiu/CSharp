using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryVoiture
{
    public class Moteur
    {
        private bool enMarche;
        private decimal puissance;

        public bool EnMarche
        {
            get
            {
                return enMarche;
            }
        }

        public Moteur() : base()
        {
            enMarche = false;
        }

        public Moteur(decimal _puissance)
        {
            enMarche = false;
            this.puissance = _puissance;
        }

        public Moteur(Moteur _maClone) : this(_maClone.puissance)
        {
            enMarche = false;
        }

        public bool Entrainer(Roue roueMotrice1, Roue roueMotrice2)
        {
            if (!EnMarche)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void DemarrerMoteur()
        {
            enMarche = true;
        }

        public void ArreterMoteur()
        {
            enMarche = false;
        }
    }
}
