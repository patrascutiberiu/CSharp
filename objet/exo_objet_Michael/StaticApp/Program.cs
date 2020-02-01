using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person p = new Person("Mike");
            
            Person p2 = new Person("Paul");
            
            foreach(Person pp in Person.ListPerson)
            {
                pp.Affiche();
            }
            
            Console.ReadLine();
        }
    }
}
