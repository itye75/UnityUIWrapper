using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using UnityAPI.Pub;
using UnityUIWrapper.BL;

namespace UnityUIWrapper.ViewModel
{
    public class EntitiesListViewModel : ViewModelBase
    {
        private DataState m_state;

        public EntitiesListViewModel()
        {
            m_state = DataState.Instance;
            m_state.EntitiesUpdatedEvent.ObserveOnDispatcher().Subscribe(onEntitiesUpdatedEvent);
        }


        public List<EntityData> EntitiesList => m_state.Entities;

        private void onEntitiesUpdatedEvent(Unit p_unit)
        {
            RaisePropertyChanged(() => EntitiesList);
        }

    }
}
