using BusinessLayer;
using ClassLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class TestOffre
    {
        [TestMethod]
        public void GetOffre_returnAll()
        {
            BusinessManager _manager = BusinessManager.Instance;
            List<Offre> offre = _manager.GetAllOffre();
            Assert.IsNotNull(offre);
        }

        [TestMethod]
        public void AddOffre()
        {
            BusinessManager _manager = BusinessManager.Instance;
            int lenght = _manager.GetAllOffre().Count;
            _manager.AjouterOffre(new Offre { Intitule = "Developpeur .Net", 
                Description = "Recherche d'un développeur web ASP .NET", 
                Date = new DateTime(2021, 5, 24), Salaire = 1250, 
                Responsable = "Rolland", Statut = new Statut { Libelle = "Ouverte" } } );
            Assert.AreEqual(_manager.GetAllOffre().Count, lenght + 1);
        }

        [TestMethod]
        public void GetOffreById_returnOne()
        {
            BusinessManager _manager = BusinessManager.Instance;
            long id = _manager.GetAllOffre().First().Id;
            Assert.IsNotNull(_manager.GetOffreById(id));
        }
    }
}
