using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanque
{
    public class Banque
    {
        private int nbCompte;
        private Compte[] mesComptes;

        public Banque()
        {
            mesComptes = new Compte[9];
            nbCompte = 0;
        }

        private void AjouteCompte(Compte nouveauCompte)
        {
            mesComptes[nbCompte++] = nouveauCompte;
        }

        public void AjouteCompte(int _numero, string _nom, double _solde, int _decouvertAutorise)
        {
            Compte nouveauCompte = new Compte(_numero, _nom, _solde, _decouvertAutorise);
            AjouteCompte(nouveauCompte);
        }
        public void Init()
        {
            Compte c1 = new Compte(12345, "tati", 2000, -1000);
            AjouteCompte(c1);
            Compte c2 = new Compte(1652, "titu", 20, 0);
            AjouteCompte(c2);
            Compte c3 = new Compte(32345, "dupond", 1500, -1500);
            this.AjouteCompte(c3);
            Compte c4 = new Compte(11633, "durand", 1200, -500);
            this.AjouteCompte(c4);
            Compte c5 = new Compte(2568, "dubois", -200, -500);
            this.AjouteCompte(c5);
            Compte c6 = new Compte(8978, "duval", 7500, -2000);
            this.AjouteCompte(c6);
        }

        public string AfficherComptes()
        {
            string maListe = "";

            //foreach (Compte i in mesComptes)
            //{
            //    if (i != null)
            //    {
            //        maListe += i.ToString() + "\n";
            //    }
            //}
            //return maListe;

            for (int i = 0; i < mesComptes.Length; i++)
            {
                if (mesComptes[i] != null)
                {
                    maListe += mesComptes[i].ToString() + "\n";
                }
            }
            return maListe;
        }

        public Compte SortTableauDesc()
        {
            //mesComptes = mesComptes.OrderByDescending((a => a.Solde)).ToArray();

            Array.Sort<Compte>(mesComptes, new Comparison<Compte>((i1, i2) => i2.Solde.CompareTo(i1.Solde)));

            foreach (Compte item in mesComptes)
            {
                return item;
            }
            return null;
        }

        public Compte CompteSup()
        {
            Compte monCompte = null;
            double max = 0;
            foreach (Compte leCompte in mesComptes)
            {
                if (leCompte != null && leCompte.Solde > max)
                {
                    monCompte = leCompte;
                    max = leCompte.Solde;
                }
            }
            return monCompte;
        }

        public Compte RendCompte(int _numero)
        {
            foreach (Compte item in mesComptes)
            {
                if (item != null && _numero == item.Numero)
                {
                    return item;
                }
            }
            return null;
        }

        public bool Transfer(int nrCompte1, int nrCompte2, double _montant)
        {
            double soldeCompte1 = 0;
            int indexCompte1 = 0;
            bool test = false;

            for (int i = 0; i < mesComptes.Length; i++)
            {
                if (mesComptes[i] != null && mesComptes[i].Numero == nrCompte1)
                {
                    soldeCompte1 = mesComptes[i].Solde;
                    indexCompte1 = i;
                }
            }
            if (soldeCompte1 >= _montant && !test)
            {
                for (int i = 0; i < mesComptes.Length; i++)
                {
                    if (mesComptes[i] != null && mesComptes[i].Numero == nrCompte2)
                    {
                        mesComptes[i].Transferer(_montant, mesComptes[indexCompte1]);
                        test = true;
                    }
                }
                return true;
            }
            return false;
        }

    }
}
