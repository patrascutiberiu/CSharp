using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte_bancaire_2
{
    public class Banque
    {
        /// <summary>
        /// compte le nombre de comptes
        /// </summary>
        private int nbComptes;
        /// <summary>
        /// lier la banque à ses comptes
        /// </summary>
        private Compte[] mesComptes;


        public Banque()
        {

            mesComptes = new Compte[8];        //crée le tableau 
            this.nbComptes = 0;                 //initialise à 0 le nombre de comptes
        }

        private void AjouteCompte(Compte unCompte)
        {
            mesComptes[nbComptes++] = unCompte;
        }

        public void Init()
        {
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            this.AjouteCompte(c1);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);
            this.AjouteCompte(c2);
            Compte c3 = new Compte(32345, "dupond", 1500, -1500);
            this.AjouteCompte(c3);
            Compte c4 = new Compte(11633, "durand", 1200, -500);
            this.AjouteCompte(c4);
            Compte c5 = new Compte(2568, "dubois", -200, -500);
            this.AjouteCompte(c5);
            Compte c6 = new Compte(8978, "duval", 7500, -2000);
            this.AjouteCompte(c6);

        }

        public void AfficherComptes()
        {
            foreach (Compte i in mesComptes)
            {
                if (i != null)
                {
                    Console.WriteLine(i);
                }
            }

            //for (int i = 0; i < mesComptes.Length; i++)
            //{
            //    if (mesComptes[i] != null)
            //    {
            //        //return mesComptes[i];
            //        Console.WriteLine(mesComptes[i]);
            //    }
            //}
        }

        public void AjouteCompte(int _n, string _nom, double _solde, int _dec)
        {
            Compte compteNew = new Compte(_n, _nom, _solde, _dec);
            AjouteCompte(compteNew);
        }

        public Compte SortArrayStatic()
        {

            mesComptes = mesComptes.OrderByDescending((a => a.Solde)).ToArray();
            foreach (Compte item in mesComptes)
            {
                return item;
            }
            return null;
        }

        public void CompteSup()
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
            monCompte.ToString();
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





