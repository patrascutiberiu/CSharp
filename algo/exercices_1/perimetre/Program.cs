using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perimetre
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, p;   // p=périmètre
            double aire, aire1;

            Console.WriteLine(" Veuillez la valeur du nombre decimal ou non A !");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine(" Veuillez la valeur du nombre decimal ou non B !");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine(" Veuillez la valeur du nombre decimal ou non C !");
            c = float.Parse(Console.ReadLine());
            p = a + b + c;
            aire1 = p / (double)2 * (p / 2 - a) * (p / 2 - b) * (p / 2 - c);
            aire = Math.Sqrt(aire1);
            Console.WriteLine("Le périmètre de triangle est :{0:##,###.00} cm, est son l'aire {1:###.00} cm²", p, aire);
            Console.ReadKey();
        }
    }
}
