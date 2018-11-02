using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using UnityAPI.Sub;
using UnityUIWrapper.BL;
using System.Windows.Forms;

namespace UnityUIWrapper.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private DataState m_state;
        private APIImplementation m_api;
        private CommunicationHandler m_commHandler;

        public List<string> CameraViewTypes { get; set; }

        public MainViewModel()
        {
            m_state = DataState.Instance;
            m_commHandler = CommunicationHandler.Instance;
            m_state.PropertyUpdatedEvent.ObserveOnDispatcher().Subscribe(onPropertyUpdate);
            m_api = APIImplementation.Instance;

            CameraViewTypes = new List<string>() { "Plan View", "Free Look" };
        }

        public string WindowTitle
        {
            get
            {
                if (string.IsNullOrWhiteSpace(m_state.ScenarioPath))
                    return string.Format("UniScene : New Scenario");

                return string.Format("UniScene : Scenario - {0}", m_state.ScenarioPath);
            }
        }

        public bool HighlightEntities
        {
            get { return m_state.HighlightEntities; }
            set { m_state.HighlightEntities = value; }
        }

        public ICommand ExitCommand
        {
            get
            {
                return new RelayCommand(onExit, () => true);
            }
        }

        public ICommand LoadCommand
        {
            get
            {
                return new RelayCommand(onLoad, () => true);
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                return new RelayCommand(onSave, () => true);
            }
        }

        private void onExit()
        {
            m_commHandler.Close();
        }

        private void onLoad()
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Scenario files (*.uscn)|*.uscn";

            if (opd.ShowDialog() == DialogResult.OK)
            {
                m_api.LoadScenario(opd.FileName);
            }
        }

        private void onSave()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Scenario files (*.uscn)|*.uscn";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                m_api.SaveScenario(sfd.FileName);
            }
        }

        private void onPropertyUpdate(Unit p_unit)
        {
            RaisePropertyChanged(() => HighlightEntities);
            RaisePropertyChanged(() => SelectedCameraView);
            RaisePropertyChanged(() => WindowTitle);
        }


        public string SelectedCameraView
        {
            get
            {
                if (m_state.SelectedCameraView == CameraView.FreeLook)
                {
                    return "Free Look";
                }
                else
                {
                    return "Plan View";
                }
            }
            set
            {
                if (value == "Free Look")
                {
                    m_state.SetSelectedCamera(CameraView.FreeLook);
                }
                else
                {
                    m_state.SetSelectedCamera(CameraView.PlanView);
                }

            }
        }

    }
}