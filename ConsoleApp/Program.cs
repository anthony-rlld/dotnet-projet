using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary.Entities;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Contexte context = new Contexte();
            System.Console.WriteLine($"Nombre d'employe : {context.Employes.Count()}");

            context.Employes.Add(new Employe { Nom = "Rolland", Prenom = "Anthony", DateNaissance = new DateTime(2020, 4, 4), Anciennete = 1 });
            context.SaveChanges();

            System.Console.WriteLine($"Nombre d'employe : {context.Employes.Count()}");
        }
    }
}
