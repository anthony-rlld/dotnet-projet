﻿using ClassLibrary;
using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    class EmployeCommand
    {
        private readonly Contexte _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public EmployeCommand(Contexte contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter l'employe en base à partir du contexte
        /// </summary>
        /// <param name="e">Employe à ajouter</param>
        /// <returns>Identifiant de l'mploye ajouté</returns>
        public int Ajouter(Employe e)
        {
            _contexte.Employes.Add(e);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier un employe déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="e">Employe à modifier</param>
        public void Modifier(Employe e)
        {
            Employe upEmp = _contexte.Employes.Where(emp => emp.Id == e.Id).FirstOrDefault();
            if (upEmp != null)
            {
                upEmp.Nom = e.Nom;
                upEmp.Anciennete = e.Anciennete;
                upEmp.Biographie = e.Biographie;
                upEmp.DateNaissance = e.DateNaissance;
                upEmp.Prenom = e.Prenom;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un employe en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="employeId">Identifiant de l'employe à supprimer</param>
        public void Supprimer(long employeId)
        {
            Employe delEmp = _contexte.Employes.Where(emp => emp.Id == employeId).FirstOrDefault();
            if (delEmp != null)
            {
                _contexte.Employes.Remove(delEmp);
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Ajouter une postulation à un employe
        /// </summary>
        /// <param name="employeId">Identifiant de l'employe</param>
        /// <param name="p">Postulation à ajoutée</param>
        internal void AjouterPostulation(long employeId, Postulation p)
        {
            Employe e = _contexte.Employes.Find(employeId);
            if (e != null)
            {
                e.Postulations.Add(p);
            }
            // TODO : Peut-être jeter une exception
        }
    }
}
