using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere.StadesDesEpilopteres
{
    public abstract class StadeDEvolution
    {
        /// <summary>
        /// methode abstracte pour se transformer
        /// </summary>
        /// <returns></returns>
        public abstract StadeDEvolution SeTransformer();

        /// <summary>
        /// metode abstracte pou se deplacer
        /// </summary>
        public abstract void SeDeplacer();
    }
}
