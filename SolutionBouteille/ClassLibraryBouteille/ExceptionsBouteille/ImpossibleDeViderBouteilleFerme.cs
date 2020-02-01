using System;
using System.Collections.Generic;
using System.Text;


namespace ClassLibraryBouteille.ExceptionsBouteille
{
    public class ImpossibleDeViderBouteilleFerme : Exception
    {
        public ImpossibleDeViderBouteilleFerme() : base("La bouteille ne peut pas être vidée car elle est fermée !")
        {
        }
    }


    public class ImpossibleDeRemplirBouteilleFerme : Exception
    {
        public ImpossibleDeRemplirBouteilleFerme() : base("La bouteille ne peut pas être remplie car elle est fermée !")
        {
        }
    }

    public class ImpossibleDeRemplirBouteilleMax : Exception
    {
        public ImpossibleDeRemplirBouteilleMax() : base("On ne peut pas remplir la bouteille au-dessous de la capacité maximale !")
        {
        }
    }

    public class ImpossibleDeViderBouteilleMin : Exception
    {
        public ImpossibleDeViderBouteilleMin() : base("On ne peut pas vider la bouteille en-dessous de la capacité minimale !")
        {
        }
    }
}
