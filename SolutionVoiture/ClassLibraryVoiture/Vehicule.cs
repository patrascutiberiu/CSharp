using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryVoiture
{
    public abstract class Vehicule
    {
        private string numeroSerie;

        public Vehicule(string _numeroSerie)
        {
            this.numeroSerie = _numeroSerie;
        }

    }
}
