using System;

namespace CompteBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'un compte de test au nom de Marc
            CompteBancaire newCompte = new CompteBancaire("1", "Marc");
            
            // On définit le découvert autorisé à -100€
            newCompte.Decouvert = -100;

            //Création d'un compte de test au nom de Gilbert
            CompteBancaire newCompte2 = new CompteBancaire("2", "Gilbert");


            // Affichage des informations des 2 comptes avant opérations
            Console.WriteLine(newCompte.Afficher());
            Console.WriteLine(newCompte2.Afficher());

            // On crédite newCompte de 3000€
            newCompte.Crediter(3000);
            // Affichage de newCompte après l'opération de crédit
            Console.WriteLine(newCompte.Afficher());


            // On débite 500€ de newCompte (le débit devrait être accepté)
            newCompte.Debiter(500);
            // Affichage de newCompte après l'opération de débit
            Console.WriteLine(newCompte.Afficher());


            // On débite 500€ de newCompte (le débit devrait être refusé car il dépasse l'autorisation de découvert)
            newCompte.Debiter(5000);
            // Affichage de newCompte après l'opération de débit
            Console.WriteLine(newCompte.Afficher());


            // On transfère 250€ de newCompte vers newCompte2
            newCompte.Transferer(250, newCompte2);


            // Affichage des informations des comptes après opérations
            Console.WriteLine(newCompte.Afficher());
            Console.WriteLine(newCompte2.Afficher());


            // Le Console.ReadKey()
            Console.ReadKey();
        }
    }
}
