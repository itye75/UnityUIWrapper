using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using UnityAPI.Pub;
using UnityUIWrapper.BL;
using UnityUIWrapper.Model;

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


        public ObservableCollection<EntityObject> EntitiesList
        {
            get
            {
                m_entityDataList.Clear();
                m_state.Entities.ForEach(entity => m_entityDataList.Add(new EntityObject() { Entity = entity, Name = entity.Name }));
                return m_entityDataList;
            }
        }

        private void onEntitiesUpdatedEvent(Unit p_unit)
        {
            RaisePropertyChanged(() => EntitiesList);
        }

    private ObservableCollection<EntityObject> m_entityDataList = new ObservableCollection<EntityObject>();
    }
}
