using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using UnityUIWrapper.BL;

namespace UnityUIWrapper.ViewModel
{
    public class WeatherViewModel : ViewModelBase
    {
        private APIImplementation m_api;
        private DataState m_state;

        public WeatherViewModel()
        {
            m_api = APIImplementation.Instance;
            m_state = DataState.Instance;
        }

        public float Intensity
        {
            get { return m_state.Intensity; }
            set
            {
                m_state.Intensity = value;
                m_api.SetRainIntensity(m_state.Intensity);
                RaisePropertyChanged(() => Intensity);
            }
        }
    }
}
