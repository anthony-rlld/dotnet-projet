using ClassLibrary;
using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    /// <summary>
    /// QUERY pour récupérer des entités de types Employe
    /// </summary>
    class EmployeQuery
    {
        private readonly Contexte _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public EmployeQuery(Contexte contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les employes
        /// </summary>
        /// <returns>IQueryable de Employe</returns>
        public IQueryable<Employe> GetAll()
        {
            return _contexte.Employes;
        }

        /// <summary>
        /// Récupérer un employe par son Id
        /// </summary>
        /// <param name="id">Identifiant de l'employe à récupérer</param>
        /// <returns>IQueryable de Employe</returns>
        public Employe GetById(long id)
        {
            Employe e = _contexte.Employes.Find(id);
            if (e != null)
            {
                return e;
            }
            return null;
        }
    }
}
