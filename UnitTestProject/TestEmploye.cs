using BusinessLayer;
using ClassLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class TestEmploye
    {
        [TestMethod]
        public void GetEmploye_returnAll()
        {
            BusinessManager _manager = BusinessManager.Instance;
            List<Employe> employes = _manager.GetAllEmploye();
            Assert.IsNotNull(employes);
        }

        [TestMethod]
        public void AddEmploye()
        {
            BusinessManager _manager = BusinessManager.Instance;
            int lenght = _manager.GetAllEmploye().Count;
            _manager.AjouterEmploye(new Employe { Nom = "Rolland", Prenom = "Anthony", DateNaissance = new DateTime(2020, 4, 4), Anciennete = 1 });
            Assert.AreEqual(_manager.GetAllEmploye().Count, lenght + 1);
        }

        [TestMethod]
        public void GetEmployeById_returnOne()
        {
            BusinessManager _manager = BusinessManager.Instance;
            long id = _manager.GetAllEmploye().First().Id;
            Assert.IsNotNull(_manager.GetEmployeById(id));
        }
    }
}
