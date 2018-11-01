using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using UnityUIWrapper.BL;

namespace UnityUIWrapper.ViewModel
{
    public class RemoteControllerViewModel : ViewModelBase
    {
        private DataState m_state;
        private APIImplementation m_api;

        public RemoteControllerViewModel()
        {
            m_state = DataState.Instance;
            m_api = APIImplementation.Instance;
        }

        public ICommand PlayCommand
        {
            get
            {
                return new RelayCommand(onPlay, () => true);
            }
        }

        public ICommand StopCommand
        {
            get
            {
                return new RelayCommand(onStop, () => true);
            }
        }

        public ICommand PauseCommand
        {
            get
            {
                return new RelayCommand(onPause, () => true);
            }
        }


        private void onPlay()
        {
            m_api.Play();
        }

        private void onStop()
        {
            m_api.Stop();
        }

        private void onPause()
        {
            m_api.Pause();
        }
    }
}
