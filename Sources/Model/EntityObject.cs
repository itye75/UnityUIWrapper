using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using UnityAPI.Pub;
using UnityUIWrapper.BL;

namespace UnityUIWrapper.Model
{
    public class EntityObject
    {
        public enum ObjectClass
        {
            Ground,
            Sea,
            Tactical
        }

        public string Name { get; set; }
        public int TypeId { get; set; }
        public ObjectClass Class { get; set; }
        public EntityData Entity { get; set; }
        private readonly APIImplementation m_api;

        public EntityObject()
        {
            m_api = APIImplementation.Instance;
        }

        public ICommand CreateEntityCommand
        {
            get
            {
                return new RelayCommand(onCreateEntity, () => true);
            }
        }

        public ICommand EntityClickCommand
        {
            get
            {
                return new RelayCommand(onEntityClick, () => true);
            }
        }

        private void onEntityClick()
        {
            m_api.SelectEntity(this.Entity.Id);
        }

        private void onCreateEntity()
        {
            m_api.AddEntity(this);
        }
    }
}
