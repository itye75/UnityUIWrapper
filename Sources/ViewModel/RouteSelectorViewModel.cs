﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UnityAPI.Pub;
using UnityUIWrapper.BL;

namespace UnityUIWrapper.ViewModel
{
    public class RouteSelectorViewModel : ViewModelBase
    {
        private DataState m_state;
        private APIImplementation m_api;

        private EntityData m_selectedRoute;

        public RouteSelectorViewModel()
        {
            m_state = DataState.Instance;
            m_api = APIImplementation.Instance;
            m_state.PropertyUpdatedEvent.ObserveOnDispatcher().Subscribe(onPropertyUpdate);
        }

        public EntityData SelectedRoute
        {
            get
            {
                return m_selectedRoute;
            }
            set
            {
                m_selectedRoute = value;
                RaisePropertyChanged(() => SelectedRoute);
                RaisePropertyChanged(() => IsSelectEnabled);
            }
        }


        public List<EntityData> Routes
        {
            get { return m_state.Routes; }
        }

        private void onPropertyUpdate(Unit p_u)
        {
            RaisePropertyChanged(() => Routes);
        }

        public ICommand SelectCommand
        {
            get
            {
                return new RelayCommand(onSelect, () => true);
            }
        }

        public bool IsSelectEnabled
        {
            get
            {
                return SelectedRoute != null;
            }
        }
        

        private void onSelect()
        {
            m_api.AttachRouteToEntity(m_state.SelectedEntity, SelectedRoute);
        }
    }
}
