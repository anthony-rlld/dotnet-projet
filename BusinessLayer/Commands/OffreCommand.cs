﻿using ClassLibrary;
using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Command
{
    class OffreCommand
    {
        private readonly Contexte _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public OffreCommand(Contexte contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter l'offre en base à partir du contexte
        /// </summary>
        /// <param name="e">Offre à ajouter</param>
        /// <returns>Identifiant de l'offre ajouté</returns>
        public int Ajouter(Offre o)
        {
            _contexte.Offres.Add(o);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier un offre déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="o">Offre à modifier</param>
        public void Modifier(Offre o)
        {
            Offre upOff = _contexte.Offres.Where(emp => emp.Id == o.Id).FirstOrDefault();
            if (upOff != null)
            {
                upOff.Intitule = o.Intitule;
                upOff.Responsable = o.Responsable;
                upOff.Salaire = o.Salaire;
                upOff.Statut = o.Statut;
                upOff.Date = o.Date;
                upOff.Description = o.Description;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un offre en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="offreId">Identifiant de l'offre à supprimer</param>
        public void Supprimer(long offreId)
        {
            Offre delOff = _contexte.Offres.Where(off => off.Id == offreId).FirstOrDefault();
            if (delOff != null)
            {
                _contexte.Offres.Remove(delOff);
            }
            _contexte.SaveChanges();
        }
    }
}
