using System;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using UnityAPI.Pub;
using UnityUIWrapper.BL;
using UnityUIWrapper.Common;
using UnityUIWrapper.View;

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
        private DataState m_state;

        public EntityObject()
        {
            m_api = APIImplementation.Instance;
            m_state = DataState.Instance;
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

        public ICommand RouteSelectorCommand
        {
            get
            {
                return new RelayCommand(onRouteSelector, () => true);
            }
        }



        private void onRouteSelector()
        {
            m_api.SelectEntity(this.Entity.Id);

            ContextMenu contextMenu = new ContextMenu();
            MenuItem item = new MenuItem();
            item.Header = "Attach To Route";
            item.Command = new RelayCommand(showRoutesMenu);

            MenuItem item2 = new MenuItem();
            item2.Header = "Select";
            item2.Command = new RelayCommand(onEntityClick);

            contextMenu.Items.Add(item2);
            contextMenu.Items.Add(item);
            contextMenu.IsOpen = true;
        }

        private void showRoutesMenu()
        {
            m_state.SelectedEntity = Entity;
            RouteSelectorView view = new RouteSelectorView();
            view.Show();
        }

        private void onEntityClick()
        {
            m_api.SelectEntity(this.Entity.Id);

            Messenger.Default.Send<EntitySelectedMessage>(new EntitySelectedMessage() { Entity = this.Entity });
        }

        private void onCreateEntity()
        {
            m_api.AddEntity(this);
        }
    }
}
