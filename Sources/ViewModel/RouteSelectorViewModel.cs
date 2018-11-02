using GalaSoft.MvvmLight;
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
using MahApps.Metro.Controls;
using UnityAPI.Pub;
using UnityUIWrapper.BL;
using System.Windows.Controls;

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
                return new RelayCommand<MetroWindow>(onSelect);
            }
        }


        public ICommand SelectedRouteChanged
        {
            get
            {
                return new RelayCommand(onSelectedRouteChanged, (() => true));
            }
        }

        public bool IsSelectEnabled
        {
            get
            {
                return SelectedRoute != null;
            }
        }

        public ICommand CloseWindow
        {
            get
            {
                return new RelayCommand<MetroWindow>(onClose);
            }
        }

        private void onSelectedRouteChanged()
        {
            if (SelectedRoute != null)
                m_api.HighlightRoute(SelectedRoute);
        }

        private void onSelect(MetroWindow p_window)
        {
            m_api.AttachRouteToEntity(m_state.SelectedEntity, SelectedRoute);
            p_window.Close();
            SelectedRoute = null;
            m_state.SelectedEntity = null;
        }

        private void onClose(MetroWindow p_window)
        {
            p_window.Close();
            SelectedRoute = null;
            m_state.SelectedEntity = null;
        }
    }
}
