using BusinessLayer.Command;
using BusinessLayer.Commands;
using BusinessLayer.Queries;
using ClassLibrary;
using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    /// <summary>
    /// BusinessManager de la BusinessLayer
    /// Cette classe est un singleton est instancie un contexte EF dans son constructeur
    /// </summary>
    public class BusinessManager
    {
        private readonly Contexte contexte;
        private static BusinessManager _businessManager = null;

        /// <summary>
        /// Constructeur, initialisation du contexte EF
        /// </summary>
        private BusinessManager()
        {
            contexte = new Contexte();
        }

        /// <summary>
        /// Récupérer l'instance du pattern Singleton
        /// </summary>
        public static BusinessManager Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BusinessManager();
                return _businessManager;
            }
        }

        #region Employe

        /// <summary>
        /// Récupérer une liste d'employes en base
        /// </summary>
        /// <returns>Liste d'employe</returns>
        public List<Employe> GetAllEmploye()
        {
            EmployeQuery eq = new EmployeQuery(contexte);
            return eq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer un employe en base avec son identifiant
        /// </summary>
        /// <param name="employeID">Identifiant de l'employe à supprimer</param>
        /// <returns>L'employe recherché</returns>
        public Employe GetEmployeById(long employeID)
        {
            EmployeQuery eq = new EmployeQuery(contexte);
            return eq.GetById(employeID);
        }

        /// <summary>
        /// Ajouter un employe en base
        /// </summary>
        /// <param name="e">Employe à ajouter</param>
        /// <returns>Identifiant du nouveau employe</returns>
        public int AjouterEmploye(Employe e)
        {
            // TODO : ajouter des contrôles sur le employe (exemple : vérification de champ, etc.)
            EmployeCommand ec = new EmployeCommand(contexte);
            return ec.Ajouter(e);
        }

        /// <summary>
        /// Modifier un employe en base
        /// </summary>
        /// <param name="e">Employe à modifier</param>
        public void ModifierEmploye(Employe e)
        {
            // TODO : ajouter des contrôles sur le employe (exemple : vérification de champ, etc.)
            EmployeCommand ec = new EmployeCommand(contexte);
            ec.Modifier(e);
        }

        /// <summary>
        /// Supprimer un employe en base
        /// </summary>
        /// <param name="employeID">Identifiant de l'employe à supprimer</param>
        public void SupprimerEmploye(long employeId)
        {
            EmployeCommand ec = new EmployeCommand(contexte);
            ec.Supprimer(employeId);
        }

        /// <summary>
        /// Ajouter une postulation à un employe
        /// </summary>
        /// <param name="employeId">Identifiant de l'employe</param>
        /// <param name="p">Postulation à ajoutée</param>
        public void AjouterPostulationToEmploye(long employeId, Postulation p)
        {
            EmployeCommand ec = new EmployeCommand(contexte);
            ec.AjouterPostulation(employeId, p);
        }

        #endregion

        #region Offre

        /// <summary>
        /// Récupérer une liste d'offres en base
        /// </summary>
        /// <returns>Liste d'offres</returns>
        public List<Offre> GetAllOffre()
        {
            OffreQuery oq = new OffreQuery(contexte);
            return oq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer une offre en base avec son identifiant
        /// </summary>
        /// <param name="offreID">Identifiant de l'offre à supprimer</param>
        /// <returns>L'employe recherché</returns>
        public Offre GetOffreById(long offreID)
        {
            OffreQuery oq = new OffreQuery(contexte);
            return oq.GetById(offreID);
        }

        /// <summary>
        /// Ajouter une offre en base
        /// </summary>
        /// <param name="o">Offre à ajouter</param>
        /// <returns>Identifiant de la nouvelle offre</returns>
        public int AjouterOffre(Offre o)
        {
            // TODO : ajouter des contrôles sur le employe (exemple : vérification de champ, etc.)
            OffreCommand oc = new OffreCommand(contexte);
            return oc.Ajouter(o);
        }

        /// <summary>
        /// Modifier une offre en base
        /// </summary>
        /// <param name="o">Offre à modifier</param>
        public void ModifierOffre(Offre o)
        {
            // TODO : ajouter des contrôles sur le employe (exemple : vérification de champ, etc.)
            OffreCommand oc = new OffreCommand(contexte);
            oc.Modifier(o);
        }

        /// <summary>
        /// Supprimer une offre en base
        /// </summary>
        /// <param name="offreID">Identifiant de l'offre à supprimer</param>
        public void SupprimerOffre(long offreID)
        {
            OffreCommand oc = new OffreCommand(contexte);
            oc.Supprimer(offreID);
        }

        #endregion
    }
}
