using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;
using Google.Protobuf;
using MahApps.Metro.Controls;
using NetMQ;
using NetMQ.Sockets;
using UnityUIWrapper.BL;

namespace UnityUIWrapper.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly CommunicationHandler m_commHandler;

        public MainWindow()
        {
            InitializeComponent();
            m_commHandler = CommunicationHandler.Instance;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            m_commHandler.Close();

            base.OnClosing(e);
        }

    }
}
