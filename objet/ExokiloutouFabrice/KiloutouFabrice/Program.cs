using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiloutouFabrice
{
    class Program
    {
        static void Main(string[] args)
        {
            string marqueV;
            string modeleV;
            int numV;
            List<Voiture> listVoitures = new List<Voiture>();
            //List<Voiture2> newListVoiture2 = new List<Voiture2>();
            Voiture myCar1 = new Voiture(1987, "Renault", "Espace");
            Voiture myCar2 = new Voiture(1203, "Lancia", "Dedra");
            Voiture myCar3 = new Voiture(2098, "Peugeot", "307");
            Voiture myCar4 = new Voiture(3049, "BMW", "324D");
            Voiture myCar5 = new Voiture(1500, "Peugeot", "406");
            Voiture myCar6 = new Voiture(2500, "Ford", "Mondeo");
            //Voiture[] tableauVoit = new Voiture[6];

            //tableauVoit[0] = myCar1;
            //tableauVoit[1] = myCar2;
            //tableauVoit[2] = myCar3;
            //tableauVoit[3] = myCar4;
            //tableauVoit[4] = myCar5;
            //tableauVoit[5] = myCar6;
            //camion moncamion = new camion();
            //Voiture2 myNewCar = new Voiture2();
            //myNewCar.NumeroSerie = 1234;
            //myNewCar.Modèle = " F450";
            //myNewCar.Marque = "Ferrari";
            //myNewCar.MiseCircul = DateTime.Now;



           //tableauVoit = tableauVoit.OrderBy(x => x.Marque).ToArray();
           // listVoitures.Sort();

           // foreach (Voiture item in tableauVoit)
           // {
           //     item.Affichage();
           // }
            listVoitures.Add(myCar1);
            listVoitures.Add(myCar2);
            listVoitures.Add(myCar3);
            listVoitures.Add(myCar4);
            listVoitures.Add(myCar5);
            listVoitures.Add(myCar6);

            //listVoitures = listVoitures.OrderBy(n => n.Marque).ToList();

            foreach (Voiture V in listVoitures)
            {
                V.Affichage();
            }


            Console.WriteLine(" ordre de tri : \n[1] marque\n[2] modele \n[3] numero de serie \nquel est votre choix :");
            int choix = int.Parse(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    listVoitures = listVoitures.OrderBy(x => x.Marque).ToList();
                    break;
                case 2:
                    listVoitures = listVoitures.OrderBy(x => x.Modele).ToList();
                    break;
                case 3:
                    listVoitures = listVoitures.OrderBy(x => x.NumSerie).ToList();
                    break;
                default:
                    Console.WriteLine("On t'a dit 1 ,2 ou 3 connard !!!");
                    //Console.ReadKey();
                    break;
            }

            foreach (Voiture V in listVoitures)
            {
                V.Affichage();
            }
            //foreach (Voiture V in listVoitures)
            //{
            //    V.Affichage();
            //    Console.WriteLine("Quel est sa date de mise en circulation : ");
            //    DateTime date = DateTime.Parse(Console.ReadLine());
            //    Voiture2 maVoiture2 = new Voiture2(V.NumSerie, V.Marque, V.Modele, date);
            //    newListVoiture2.Add(maVoiture2);
            //}
            //Console.WriteLine(" ordre de tri : \n[1] marque\n[2] modele \n[3] numero de serie \n[4] date mise en circulation \nquel est votre choix :");
            //choix = int.Parse(Console.ReadLine());

            //switch (choix)
            //{
            //    case 1:
            //        newListVoiture2 = newListVoiture2.OrderBy(x => x.Marque).ToList();
            //        break;
            //    case 2:
            //        newListVoiture2 = newListVoiture2.OrderBy(x => x.Modèle).ToList();
            //        break;
            //    case 3:
            //        newListVoiture2 = newListVoiture2.OrderBy(x => x.NumeroSerie).ToList();
            //        break;
            //    case 4:
            //        newListVoiture2 = newListVoiture2.OrderBy(x => x.MiseCircul).ToList();
            //        break;  
            //    default:
            //        Console.WriteLine("On t'a dit 1 ,2 ,3 ou 4 connard !!!");
            //        break;
            //}

            //foreach (Voiture2 i in newListVoiture2)
            //{
            //    i.affichage();
            //}

            //Console.WriteLine("quel est le modele : ");
            //modeleV = Console.ReadLine();
            //myCar.Marque = modeleV;
            //modeleV = myCar.Marque;
            //Console.WriteLine("quel est la marque : ");
            //marqueV = Console.ReadLine();
            //myCar.Marque = marqueV;
            //Console.WriteLine("quel est le numero de serie : ");
            //numV = int.Parse(Console.ReadLine());
            //myCar.NumSerie = numV;
            //Console.WriteLine("marque : " +marqueV+ " modele : "+modeleV+" numSerie :"+numV);

            //numV = 1000;
            //marqueV = "petit bourin";
            //modeleV = "truite moche";
            //myCar.Init_voiture(numV,marqueV,modeleV);
            //Console.WriteLine("marque : " + marqueV + " modele : " + modeleV + " numSerie :" + numV);


            Console.ReadKey();

        }
    }
}

//2098,"Peugeot",307",
//1987,"Renault","Espace",
//1203,"Lancia", "Dedra",
//3049,"Bmw","324d",
//1500,”Peugeot”,”406”;
//2500,”Ford”,”Mondeo”