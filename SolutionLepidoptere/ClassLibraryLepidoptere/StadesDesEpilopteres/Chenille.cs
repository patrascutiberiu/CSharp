using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere.StadesDesEpilopteres
{
    public class Chenille : StadeDEvolution
    {
        /// <summary>
        /// constructeur par default
        /// </summary>
        public Chenille() : base(){

        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je suis une chenille, je rompe !");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>une nouvelle chrystalide</returns>
        public override StadeDEvolution SeTransformer()
        {
            Console.WriteLine("Je me suis transformé dans une chrystalide !");
            return new Chrystalide();
        }

    }
}
