using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryVoiture
{
    public class Roue
    {
        //private string saRueDeSecours;
        private string marqueRoue;
        private int dimRoue;
        private string saisonRoue;
        private bool etatRoue;



        /// <summary>
        ///constructeur paramtré 
        /// </summary>
        /// <param name="_marqueRoue"></param>
        /// <param name="_dimRoue"></param>
        /// <param name="_saisonRoue"></param>
        public Roue(string _marqueRoue, int _dimRoue, string _saisonRoue)
        {
            this.marqueRoue = _marqueRoue;
            this.dimRoue = _dimRoue;
            this.saisonRoue = _saisonRoue;
        }

        /// <summary>
        /// clone constructeur
        /// </summary>
        /// <param name="copieRoue"></param>
        public Roue(Roue copieRoue) : this(copieRoue.marqueRoue, copieRoue.dimRoue, copieRoue.saisonRoue)
        {
        }

        public bool Tourner()
        {
            if (!etatRoue)
            {
              return false;  
            }
            else
            {
              return true;       
            }
        }

        public void AvancerRoue()
        {
            etatRoue = true;
        }

        public void ArreterRoue()
        {
            etatRoue = false;
        }
    }
}
