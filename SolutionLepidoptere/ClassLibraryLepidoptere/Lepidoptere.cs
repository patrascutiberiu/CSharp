using ClassLibraryLepidoptere.StadesDesEpilopteres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Lepidoptere
    {
        private bool sexeFeminin;
        private string nom;
        private StadeDEvolution stadeCourrant;

        /// <summary>
        /// constructeur parametre
        /// </summary>
        /// <param name="_nom"></param>
        /// <param name="_sexeFeminin"></param>
        public Lepidoptere(string _nom, bool _sexeFeminin)
        {
            stadeCourrant = new Chenille();
            this.nom = _nom;
            this.sexeFeminin = _sexeFeminin;
        }

        public Lepidoptere()
        {
        }


        public void SeTransformer()
        {
            stadeCourrant = stadeCourrant.SeTransformer();
        }


        public void SeDeplacer()
        {
            stadeCourrant.SeDeplacer();
        }
        public Lepidoptere[] Accoupler(bool _conjoint)
        {
            if ((!sexeFeminin && _conjoint == true) || (sexeFeminin == true && !_conjoint))
            {
                Random nbOeuf = new Random();
                int i = nbOeuf.Next(1, 5);
                Lepidoptere[] tab;
                tab = new Lepidoptere[i];

                for (int a = 0; a < tab.Length; a++)
                {
                    tab[a] = new Lepidoptere();
                }
                Console.WriteLine("On a pondue : " + i + " oeuf(s) !");
                return tab;
            }
            else
            {
                Console.WriteLine("Impossible de faire des oeufs !");
                return null;
            }

        }
    }
}
