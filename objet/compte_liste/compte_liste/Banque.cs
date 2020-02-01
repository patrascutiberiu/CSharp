 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte_liste
{
    class Banque
    {
        private List<Compte> LesComptes;

        public Banque()
        {
            LesComptes = new List<Compte>();
        }

        public void AjouteCompte(Compte unCompte)
        {
            LesComptes.Add(unCompte);
        }

        public void Init()
        {
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            LesComptes.Add(c1);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);
            LesComptes.Add(c2);
            Compte c3 = new Compte(32345, "dupond", 1500, -1500);
            LesComptes.Add(c3);
            Compte c4 = new Compte(11633, "durand", 1200, -500);
            LesComptes.Add(c4);
            Compte c5 = new Compte(2568, "dubois", -200, -500);
            LesComptes.Add(c5);
            Compte c6 = new Compte(8978, "duval", 7500, -2000);
            LesComptes.Add(c6);
        }

        public void AfficherComptes()
        {
            foreach (Compte item in LesComptes)
            {
                Console.WriteLine(item + "\t");

            }
            Console.WriteLine("---------------------------------------------------------------------------------------------");

        }

        public void AjouteCompte(int _n, string _nom, double _solde, int _dec)
        {
            Compte compteNew = new Compte(_n, _nom, _solde, _dec);
            AjouteCompte(compteNew);
        }

        public void CompteSup()
        {
            LesComptes = LesComptes.OrderByDescending(n => n.Solde).ToList();

            Compte monCompte = null;
            double max = 0;

            foreach (Compte i in LesComptes)
            {
                if (i != null && i.Solde > max)
                {
                    monCompte = i;
                    max = i.Solde;
                }
            }
            Console.WriteLine(monCompte.ToString());
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.WriteLine("Trier par ordre décroissante : ");
            Console.WriteLine();


            foreach (Compte leCompte in LesComptes)
            {
                Console.WriteLine(leCompte);
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------");

        }


        public Compte RendCompte(int _numero)
        {
            LesComptes = LesComptes.FindAll(a => a.Numero == _numero);

            foreach (Compte item in LesComptes)
            {
                if (_numero == item.Numero)
                {
                    Console.WriteLine(item);
                    return item;
                }
            }

            Console.WriteLine("Le compte n'est pas trouvé !");
            return null;
        }

        //public void Transfert(int compt1, int compte2, double _montant)
        //{
        //    double soldeCompte1 = 0;
        //    int index=0;
        //    foreach (Compte a in LesComptes)
        //    {
        //        if (a.Numero == compt1)
        //        {
        //            soldeCompte1 = a.Solde;

        //        }
        //    }
        //    if (soldeCompte1 >= _montant)
        //    {
        //        foreach (Compte item in LesComptes)
        //        {
        //            if (item.Numero == compte2)
        //            {
        //                //item.Transferer(_montant, 
        //                Console.WriteLine("Transfert effectué !");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Transfert impossible");
        //    }
        //}

    }
}
