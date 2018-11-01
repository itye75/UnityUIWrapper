using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityAPI.Pub;
using UnityUIWrapper.BL;

namespace UnityUIWrapper.ViewModel
{
    public class RouteSelectorViewModel : ViewModelBase
    {
        private DataState m_state;

        public RouteSelectorViewModel()
        {
            m_state = DataState.Instance;
            m_state.PropertyUpdatedEvent.ObserveOnDispatcher().Subscribe(onPropertyUpdate);
        }

        public List<EntityData> Routes
        {
            get { return m_state.Routes; }
        }

        private void onPropertyUpdate(Unit p_u)
        {
            RaisePropertyChanged(() => Routes);
        }
    }
}
