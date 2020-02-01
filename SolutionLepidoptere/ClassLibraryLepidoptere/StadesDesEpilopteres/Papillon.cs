using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere.StadesDesEpilopteres
{
    public class Papillon : StadeDEvolution
    {
        /// <summary>
        /// constructeur par default
        /// </summary>
        public Papillon() : base()
        {

        }
        public override void SeDeplacer()
        {
            Console.WriteLine("Je suis un papillon, je vole !");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>le papillon lui même</returns>
        public override StadeDEvolution SeTransformer()
        {
            Console.WriteLine("DSL je ne peux rien faire, si tu veux je peux faire l'amour !");
            return this;
        }
    }
}
