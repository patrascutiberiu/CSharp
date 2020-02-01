using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticApp
{
    class Person
    {
        /// <summary>
        /// Liste statique de personnes
        /// Les propriétés statiques sont communes à toutes les instances de la classe.
        /// Si je remplace la liste par une autre, cela impactera toutes les isntances de la classe Person
        /// </summary>
        public static List<Person> ListPerson { get; private set; } = new List<Person>();

        /// <summary>
        /// Dernier identifiant enregistré
        /// </summary>
        static int _lastId = 0;

        /// <summary>
        /// Les méthodes statiques sont communes à TOUTES les instances de la classe
        /// </summary>
        /// <returns></returns>
        static public int getLastId()
        {
            return _lastId;
        }

        /// <summary>
        /// Identifiant unique de la personne
        /// </summary>
        int id; 

        /// <summary>
        /// Prénom
        /// </summary>
        string firstname;

        /// <summary>
        /// Constructeur d'une personne 
        /// </summary>
        /// <param name="_firstname">Prénom</param>
        public Person(string _firstname)
        {
            id = ++_lastId;
            firstname = _firstname;
            ListPerson.Add(this);
        }

        /// <summary>
        /// Affichage de la personne dans la console
        /// </summary>
        public void Affiche()
        {
            Console.WriteLine(_lastId + "/" + id + "/" + firstname + " " + lastname);
        }
    }
}
