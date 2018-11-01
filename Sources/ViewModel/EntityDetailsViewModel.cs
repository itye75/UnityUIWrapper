using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityAPI.Pub;
using UnityUIWrapper.BL;
using UnityUIWrapper.Common;

namespace UnityUIWrapper.ViewModel
{
    public class EntityDetailsViewModel : ViewModelBase
    {
        private string m_lastSelectedMessageText;
        private DataState m_state;

        public EntityDetailsViewModel()
        {
            m_state = DataState.Instance;
            Messenger.Default.Register<EntitySelectedMessage>(this, onEntitySelected);
        }

        private void onEntitySelected(EntitySelectedMessage p_selectedEntityMessage)
        {
            m_lastSelectedMessageText = $"Name:\t\t{p_selectedEntityMessage.Entity.Name}" +
                $"\nLat:\t\t{p_selectedEntityMessage.Entity.Location.X}" +
                $"\nLon:\t\t{p_selectedEntityMessage.Entity.Location.Y}" +
                $"\nAlt:\t\t{p_selectedEntityMessage.Entity.Location.Z}";
            RaisePropertyChanged(() => SelectedEntityDetails);
        }

        public string SelectedEntityDetails
        {
            get
            {
                return m_lastSelectedMessageText;
            }
        }
    }
}
