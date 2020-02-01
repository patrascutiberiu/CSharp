using System;
using System.Collections.Generic;
using System.Text;


namespace ClassLibraryBouteille.Ecran
{
    public class EcranAffichage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maBouteille"></param>
        public static void Affichage(Bouteille maBouteille)
        {
            Console.WriteLine("Dans ma bouteille le volume actuel est de : " + maBouteille.ContenanceCouranteEnMl
                + " (l) \nLe volume maximum de la bouteille est de : " + maBouteille.ContenanceMaxEnMl + " (l) \nLe bouchon est "
                + (maBouteille.Ouvert ? "ouvert !\n" : "ferme !\n"));

        }
    }
}
