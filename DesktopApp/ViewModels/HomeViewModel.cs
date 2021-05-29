using DesktopApp.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        private ListOffreViewModel _listeOffreViewModel = null;

        public HomeViewModel()
        {
            _listeOffreViewModel = new ListOffreViewModel();
        }

        /// <summary>
        /// Obtient ou définit le ListOffreViewModel
        /// </summary>
        public ListOffreViewModel ListOffreViewModel
        {
            get { return _listeOffreViewModel; }
            set { _listeOffreViewModel = value; }
        }

    }
}
