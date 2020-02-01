using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = DateTime.Now;
            Console.WriteLine("Aujurd'hui on est le : " + a.ToString("D") + " ! ");
            Console.WriteLine("C'est : " + DateTime.Now.Hour + " h");
            //DateTime dateCourante = DateTime.Now;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                AfichageBonWeekEnd();
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < 9)
            {
                AfichageBonWeekEnd();
            }
            else if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour <= 18)
            {
                AfichageBonjour();
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour >= 18)
            {
                AfichageBonWeekEnd();
            }
            else
            {
                AfichageBonsoir();
            }
        

        Console.ReadKey();
        }
        private static void AfichageBonsoir()
        {
        Console.WriteLine("Bonsoir : " + Environment.UserName + "");
        }

        private static void AfichageBonjour()
        {
            Console.WriteLine("Bonjour :  " + Environment.UserName);
        }

        private static void AfichageBonWeekEnd()
        {
        Console.WriteLine("Bon week-end : " + Environment.UserName);
        }
    }   
}




