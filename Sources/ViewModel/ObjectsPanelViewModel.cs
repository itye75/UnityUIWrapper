using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using UnityUIWrapper.BL;
using UnityUIWrapper.Model;

namespace UnityUIWrapper.ViewModel
{
    public class ObjectsPanelViewModel : ViewModelBase
    {
        private DataState m_state;

        public enum SelectedView
        {
            Objects,
            Tactical
        }

        private SelectedView m_selectedView = SelectedView.Objects;

        public ObjectsPanelViewModel()
        {
            m_state = DataState.Instance;
            m_state.InitDummyEntities();
            m_state.PropertyUpdatedEvent.ObserveOnDispatcher().Subscribe(onPropertyUpdate);
        }

        public ICommand SelectObjectsPanelCommand
        {
            get
            {
                return new RelayCommand(onSelectObject, () => true);
            }
        }

        public ICommand SelectTacticalObjectsPanelCommand
        {
            get
            {
                return new RelayCommand(onSelectTacticalObject, () => true);
            }
        }


        public List<EntityObject> ObjectTypeList
        {
            get { return m_state.ObjectTypeList.Where(p_e => p_e.Class == EntityObject.ObjectClass.Ground).ToList(); }
        }

        public List<EntityObject> TacticalObjectTypeList
        {
            get { return m_state.ObjectTypeList.Where(p_e => p_e.Class == EntityObject.ObjectClass.Tactical).ToList(); }
        }

        public bool IsTacticalObjectView
        {
            get { return m_selectedView == SelectedView.Tactical; }
        }

        public bool IsObjectView
        {
            get { return m_selectedView == SelectedView.Objects; }
        }


        private void onPropertyUpdate(Unit p_unit)
        {
            RaisePropertyChanged(() => ObjectTypeList);
            RaisePropertyChanged(() => TacticalObjectTypeList);
        }

        private void onSelectObject()
        {
            m_selectedView = SelectedView.Objects;
            RaisePropertyChanged(() => IsTacticalObjectView);
            RaisePropertyChanged(() => IsObjectView);
        }

        private void onSelectTacticalObject()
        {
            m_selectedView = SelectedView.Tactical;
            RaisePropertyChanged(() => IsTacticalObjectView);
            RaisePropertyChanged(() => IsObjectView);
        }
    }
}
