/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:UnityUIWrapper"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace UnityUIWrapper.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<EntitiesListViewModel>();
            SimpleIoc.Default.Register<EntityDetailsViewModel>();
            
            SimpleIoc.Default.Register<RemoteControllerViewModel>();
            SimpleIoc.Default.Register<ObjectsPanelViewModel>();
            SimpleIoc.Default.Register<RouteSelectorViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }


        public EntitiesListViewModel Entities
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EntitiesListViewModel>();
            }
        }

        public EntityDetailsViewModel EntityDetailsViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EntityDetailsViewModel>();
            }
        }

        public RouteSelectorViewModel RouteSelctor
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RouteSelectorViewModel>();
            }
        }


        public RemoteControllerViewModel RemoteController
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RemoteControllerViewModel>();
            }
        }

        public ObjectsPanelViewModel ObjectsPanel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ObjectsPanelViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}