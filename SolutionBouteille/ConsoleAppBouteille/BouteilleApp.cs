using ClassLibraryBouteille.ExceptionsBouteille;
using ClassLibraryBouteille;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBouteille.Ecran;

namespace ConsoleAppBouteille
{
    class BouteilleApp
    {
        static void Main(string[] args)
        {
            try
            {
                
                Bouteille b;
                b = new Bouteille();
                b.Vider();

            }
            catch (ImpossibleDeViderBouteilleFerme iv)
            {
                Console.WriteLine(iv.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



            try
            { 
                Bouteille c = new Bouteille(1000, 50, true);
                EcranAffichage.Affichage(c);

                c.Remplir(100);
                EcranAffichage.Affichage(c);

                c.Vider();
                EcranAffichage.Affichage(c);

                Bouteille d = new Bouteille(c);
                EcranAffichage.Affichage(c);

                //c.Fermer();
                //c.Vider(10000);
                c.Remplir(1500);
                EcranAffichage.Affichage(c);



            }
            catch (ImpossibleDeRemplirBouteilleFerme iR)
            {
                Console.WriteLine(iR.Message);
            }
            catch (ImpossibleDeRemplirBouteilleMax iRMax)
            {
                Console.WriteLine(iRMax.Message);
            }
            catch (ImpossibleDeViderBouteilleMin iRMin)
            {
                Console.WriteLine(iRMin.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



            Console.ReadKey();

        }
    }
}
