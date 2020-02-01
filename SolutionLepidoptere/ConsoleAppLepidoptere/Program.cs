using ClassLibraryLepidoptere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLepidoptere
{
    class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere i = new Lepidoptere("Fly",true);

            i.SeDeplacer();
            i.SeTransformer();
            i.SeDeplacer();
            i.SeTransformer();
            i.SeDeplacer();
            i.SeTransformer();
            Lepidoptere[] copii = i.Accoupler(false);


            Console.ReadKey();
        }
    }
}
