﻿using BusinessLayer;
using ClassLibrary.Entities;
using DesktopApp.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.ViewModels
{
    class ListOffreViewModel : BaseViewModel
    {
        private ObservableCollection<DetailOffreViewModel> _offres = null;
        private DetailOffreViewModel _selectedOffres;

        public ListOffreViewModel()
        {
            // on appelle le mock pour initialiser une liste de produits
            _offres = new ObservableCollection<DetailOffreViewModel>();
            foreach (Offre o in BusinessManager.Instance.GetAllOffre())
            {
                _offres.Add(new DetailOffreViewModel(o));
            }

            if (_offres != null && _offres.Count > 0)
                _selectedOffres = _offres.ElementAt(0);
        }

        /// <summary>
        /// Obtient ou définit une collection de DetailOffreViewModel (Observable)
        /// </summary>
        public ObservableCollection<DetailOffreViewModel> Offres
        {
            get { return _offres; }
            set
            {
                _offres = value;
                OnPropertyChanged("Offres");
            }
        }

        /// <summary>
        /// Obtient ou défini l'offre en cours de sélection dans la liste de DetailOffreViewModel
        /// </summary>
        public DetailOffreViewModel SelectedOffres
        {
            get { return _selectedOffres; }
            set
            {
                _selectedOffres = value;
                OnPropertyChanged("SelectedOffres");
            }
        }
    }
}
