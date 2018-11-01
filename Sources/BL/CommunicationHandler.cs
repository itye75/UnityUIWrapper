using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetMQ;
using NetMQ.Sockets;
using UnityAPI.Pub;

namespace UnityUIWrapper.BL
{
    public class CommunicationHandler
    {
        private static CommunicationHandler s_commHandler = null;

        private NetMQContext m_context;
        private PublisherSocket m_pushSocket;
        private SubscriberSocket m_receiverSocket;
        private Poller m_poller;

        public delegate void StatusMessageDelegate(StatusMessage p_statusMessage);

        public event StatusMessageDelegate StatusUpdateEvent;


        private CommunicationHandler()
        {
            m_context = NetMQContext.Create();
            m_pushSocket = m_context.CreatePublisherSocket();
            m_pushSocket.Bind("tcp://127.0.0.1:40000");

            m_receiverSocket = m_context.CreateSubscriberSocket();
            m_poller = new Poller(m_receiverSocket);
            m_receiverSocket.Subscribe("");
            m_receiverSocket.Connect("tcp://127.0.0.1:12346");
            m_receiverSocket.ReceiveReady += onMessageReceived;
            m_poller.PollTillCancelledNonBlocking();
        }

        private void onMessageReceived(object sender, NetMQSocketEventArgs e)
        {
            var msg = StatusMessage.Parser.ParseFrom(e.Socket.Receive());
            StatusUpdateEvent?.Invoke(msg);
        }

        public void Close()
        {
            m_pushSocket.Unbind("tcp://127.0.0.1:40000");
            m_receiverSocket.Disconnect("tcp://127.0.0.1:12346");

        }

        public static CommunicationHandler Instance
        {
            get
            {
                if (s_commHandler == null)
                {
                    s_commHandler = new CommunicationHandler();
                }

                return s_commHandler;
            }
        }

        public void Send(byte[] p_msg)
        {
            m_pushSocket.SendFrame(p_msg);
        }

    
    }
}
