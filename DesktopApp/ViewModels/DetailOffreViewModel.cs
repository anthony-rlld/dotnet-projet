using ClassLibrary.Entities;
using DesktopApp.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.ViewModels
{
    class DetailOffreViewModel : BaseViewModel
    {

        private string _intitule;
        private DateTime _date;

        /// <summary>
        /// Constructeur par défaut
        /// <param name="o">Offre à transformer en DetailOffreViewModel</param>
        /// </summary>
        public DetailOffreViewModel(Offre o)
        {
            _intitule = o.Intitule;
            _date = o.Date;
        }

        /// <summary>
        /// Intitule de l'offre
        /// </summary>
        public string Intitule
        {
            get { return _intitule; }
            set { _intitule = value; }
        }

        /// <summary>
        /// Date de l'offre
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}
