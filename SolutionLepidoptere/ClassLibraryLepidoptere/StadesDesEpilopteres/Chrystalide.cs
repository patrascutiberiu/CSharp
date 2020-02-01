using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere.StadesDesEpilopteres
{
    public class Chrystalide : StadeDEvolution
    {
        /// <summary>
        /// constructeur par default
        /// </summary>
        public Chrystalide() : base()
        {

        }
        public override void SeDeplacer()
        {
            Console.WriteLine("Je suis une christalyde, je ne peux pas me deplacer !");

        }

        /// <summary>
        /// methode qui returner un nouveau papillin 
        /// </summary>
        /// <returns></returns>
        public override StadeDEvolution SeTransformer()
        {
            Console.WriteLine("Je me suis transformé dans un papillon !");
            return new Papillon();

        }
    }
}
