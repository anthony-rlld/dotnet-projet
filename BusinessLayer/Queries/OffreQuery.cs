using ClassLibrary;
using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    class OffreQuery
    {
        private readonly Contexte _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public OffreQuery(Contexte contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les offre
        /// </summary>
        /// <returns>IQueryable de Offre</returns>
        public IQueryable<Offre> GetAll()
        {
            return _contexte.Offres;
        }

        /// <summary>
        /// Récupérer une offre par son Id
        /// </summary>
        /// <param name="id">Identifiant de l'offre à récupérer</param>
        /// <returns>IQueryable d'Offre</returns>
        public Offre GetById(long id)
        {
            Offre o = _contexte.Offres.Find(id);
            if (o != null)
            {
                return o;
            }
            return null;
        }
    }
}
