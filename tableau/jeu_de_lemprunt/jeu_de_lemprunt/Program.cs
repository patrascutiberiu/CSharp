using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_de_lemprunt
{
    class Program
    {
        static void Main(string[] args)
        {
            int annee;
            double sommeEmprunt, txAnnuel = 0;
            bool test = false;
            //double partInteret, partCapital, restantDu, mensualite;

            Console.WriteLine("Quelle est la somme que voulez-vous emprunter  ?");
            sommeEmprunt = double.Parse(Console.ReadLine());
            Console.WriteLine("Dans combiens d'année voulez-vous rembourser ?");
            annee = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Veuillez saisir le taux en % que nous vous proposons : ");
                try
                {
                    string taux = Console.ReadLine();
                    taux = taux.Replace(".", ",");
                    txAnnuel = double.Parse(taux);
                    test = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\nVeuillez recommencer la saisie.");

                }
            } while (!test);
            //int mois = annee * 12;
            //mensualite = CalculMensualite(sommeEmprunt, txAnnuel, annee);

            //Console.WriteLine("Vous dévez rembourser : {0:#,##0.00} Euros pendant {1} mois", mensualite, mois);
            //Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-------------------Tableau d'ammortissement----------------------");
            Console.WriteLine("Mois n°\tPart Interet\tPart Capital\tRestant du\tMensualité");
            Console.WriteLine(Environment.NewLine);

            double[,] ResultatTabAmort = GenerateurTabAmortissement(sommeEmprunt, txAnnuel, annee);

            for (int i = 0; i < ResultatTabAmort.GetLength(0); i++)
            {
                for (int j = 0; j < ResultatTabAmort.GetLength(1); j++)
                {
                    if (j == 0 || j == (ResultatTabAmort.GetLength(1) - 1))
                    {
                        Console.Write("{0:#,###.}\t", ResultatTabAmort[i, j]);
                    }
                    else
                    {
                        Console.Write("{0:0,000.00}\t", ResultatTabAmort[i, j]);
                    }
                }
                Console.WriteLine(Environment.NewLine);
            }
            Console.ReadKey();

            //double txMensuel = txAnnuel / (12 * 100);
            //restantDu = sommeEmprunt;
            //double coutCredit = 0;

            //for (int i = 1; i <= mois; i++)
            //{
            //    partInteret = restantDu * txMensuel;
            //    coutCredit += partInteret;
            //    partCapital = mensualite - partInteret;
            //    restantDu -= partCapital; //restantDu = restantDu - partCapital; (-=)
            //    Console.WriteLine("{0} \t\t{1:#,##0.00} \t\t{2:#,###.00} \t\t{3:0,000.00} \t{4:#,###} ", i, partInteret, partCapital, restantDu, mensualite);
            //}
            //Console.WriteLine(Environment.NewLine);
            //coutCredit = Math.Round(coutCredit, 2);
            //Console.WriteLine("Coût de credit est : " + coutCredit + " Euros !");
            //Console.WriteLine(Environment.NewLine);
            //double sommeTotale = coutCredit + sommeEmprunt;
            //Console.WriteLine("La somme totale est : "+sommeTotale + " Euros !");
            //Console.ReadKey();
        }

        public static double[,] GenerateurTabAmortissement(double _sommeEmprunt, double _txAnnuel, int _annee)
        {
            double mensualite;
            //double mois = _annee * 12;
            double mois = (double)_annee * 12; // quand _annee est en int déclaré
            double txmensuel = _txAnnuel / (12 * 100);
            int NbMois = Convert.ToInt32(mois);

            double Q = (1 - (Math.Pow(1 + txmensuel, -mois)));
            mensualite = _sommeEmprunt * txmensuel / Q;

            double[,] TabAmortissement = new double[NbMois, 5];
            double partInteret, partCapital, restantDu, coutCredit = 0;
            restantDu = _sommeEmprunt;

            for (int i = 1; i <= NbMois; i++)
            {
                partInteret = restantDu * txmensuel;
                //coutCredit = coutCredit + partInteret;
                coutCredit += partInteret;
                partCapital = mensualite - partInteret;
                restantDu -= partCapital;
                //Console.WriteLine(" {0}  \t\t| {1:#,###.00}   \t| {2:#,###.00}  \t| {3:#,###.00}  \t|  {4:#,###} ", i, partInteret, partCapital, restantDu, mensualite);
                TabAmortissement[i - 1, 0] = i;
                TabAmortissement[i - 1, 1] = Math.Round(partInteret, 2);
                TabAmortissement[i - 1, 2] = Math.Round(partCapital, 2);
                TabAmortissement[i - 1, 3] = Math.Round(restantDu, 2);
                TabAmortissement[i - 1, 4] = Math.Round(mensualite, 2);

            }
            return TabAmortissement;
        }

        //public static double CalculMensualite(double _sommeEmprunt, double _txAnnuel, int _annee)
        //{
        //    double mensualite;
        //    int mois = _annee * 12;
        //    double txMensuel = _txAnnuel / (12 * 100);
        //    double Q = (1 - (Math.Pow(1 + txMensuel, -mois)));
        //    mensualite = _sommeEmprunt * txMensuel / Q;

        //    return mensualite;
        //}
    }
}
