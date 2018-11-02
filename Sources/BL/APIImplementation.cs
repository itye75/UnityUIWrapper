using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
using UnityAPI.Pub;
using UnityAPI.Sub;
using UnityUIWrapper.Model;

namespace UnityUIWrapper.BL
{
    public class APIImplementation
    {
        private readonly CommunicationHandler m_commHandler;
        private static APIImplementation s_api = null;

        private  APIImplementation()
        {
            m_commHandler = CommunicationHandler.Instance;
        }

        public static APIImplementation Instance
        {
            get
            {
                if (s_api == null)
                {
                    s_api = new APIImplementation();
                }

                return s_api;
            }
        }

        public void ToggleEntitiesHighlight(bool p_enable)
        {
            UnityGlobalCommand command = new UnityGlobalCommand();
            command.OpCode = CommandOpCode.ObjectManagement;

            command.ObjectManagement = new ObjectManagement();
            command.ObjectManagement.Highlight = p_enable;
            command.ObjectManagement.OpCode = ObjectControlOpCode.HighlightObjects;

            m_commHandler.Send(command.ToByteArray());
        }



        public void SelectEntity(int p_entityId)
        {
            UnityGlobalCommand command = new UnityGlobalCommand();
            command.OpCode = CommandOpCode.ObjectManagement;

            command.ObjectManagement = new ObjectManagement();
            command.ObjectManagement.OpCode = ObjectControlOpCode.Select;
            command.ObjectManagement.Id = p_entityId;

            m_commHandler.Send(command.ToByteArray());
        }


        public void AddEntity(EntityObject p_entity)
        {
            UnityGlobalCommand command = new UnityGlobalCommand();


            switch (p_entity.Class)
            {
                case EntityObject.ObjectClass.Ground:
                    command.OpCode = CommandOpCode.ObjectManagement;
                    command.ObjectManagement = new ObjectManagement();
                    command.ObjectManagement.ObjectType = p_entity.TypeId;
                    command.ObjectManagement.OpCode = ObjectControlOpCode.Add;
                    break;
                case EntityObject.ObjectClass.Tactical:
                    command.OpCode = CommandOpCode.TacticalObject;
                    command.TacticalObjectManagement = new TacticalObjectManagement
                        {OpCode = TacticalObjectOpCode.CreateRoute};
                    break;
            }
           
            m_commHandler.Send(command.ToByteArray());

        }

        public void SetCameraView(CameraView p_view)
        {
            var builder = new UnityGlobalCommand();
            builder.OpCode = CommandOpCode.CameraControl;
            builder.CameraView = p_view;

            m_commHandler.Send(builder.ToByteArray());
        }

        public void LoadScenario(string p_path)
        {
            UnityGlobalCommand command = new UnityGlobalCommand();
            command.OpCode = CommandOpCode.RemoteControl;
            command.RemoteControl = new RemoteControlMessage();
            command.RemoteControl.OpCode = SceneManagerCommand.Load;
            command.RemoteControl.Path = p_path;

            m_commHandler.Send(command.ToByteArray());
        }

        public void SaveScenario(string p_path)
        {
            UnityGlobalCommand command = new UnityGlobalCommand();
            command.OpCode = CommandOpCode.RemoteControl;
            command.RemoteControl = new RemoteControlMessage();
            command.RemoteControl.OpCode = SceneManagerCommand.Save;
            command.RemoteControl.Path = p_path;

            m_commHandler.Send(command.ToByteArray());
        }

        public void Play()
        {
            UnityGlobalCommand command = new UnityGlobalCommand();
            command.OpCode = CommandOpCode.RemoteControl;
            command.RemoteControl = new RemoteControlMessage();
            command.RemoteControl.OpCode = SceneManagerCommand.Play;

            m_commHandler.Send(command.ToByteArray());
        }

        public void Stop()
        {
            UnityGlobalCommand command = new UnityGlobalCommand();
            command.OpCode = CommandOpCode.RemoteControl;
            command.RemoteControl = new RemoteControlMessage();
            command.RemoteControl.OpCode = SceneManagerCommand.Stop;

            m_commHandler.Send(command.ToByteArray());
        }

        public void Pause()
        {
            UnityGlobalCommand command = new UnityGlobalCommand();
            command.OpCode = CommandOpCode.RemoteControl;
            command.RemoteControl = new RemoteControlMessage();
            command.RemoteControl.OpCode = SceneManagerCommand.Pause;

            m_commHandler.Send(command.ToByteArray());
        }

        public void AttachRouteToEntity(EntityData p_entity, EntityData p_route)
        {
            UnityGlobalCommand command = new UnityGlobalCommand();
            command.OpCode = CommandOpCode.ObjectManagement;
            command.ObjectManagement = new ObjectManagement();
            command.ObjectManagement.OpCode = ObjectControlOpCode.AttachRoute;
            command.ObjectManagement.RouteId = p_route.Id;
            command.ObjectManagement.Id = p_entity.Id;

            m_commHandler.Send(command.ToByteArray());
        }

        public void HighlightRoute(EntityData p_route)
        {
            UnityGlobalCommand command = new UnityGlobalCommand();
            command.OpCode = CommandOpCode.ObjectManagement;
            command.ObjectManagement = new ObjectManagement();
            command.ObjectManagement.OpCode = ObjectControlOpCode.HighlightObjects;
            command.ObjectManagement.RouteId = p_route.Id;

            m_commHandler.Send(command.ToByteArray());
        }

        public void SetRainIntensity(float p_intensity)
        {
            UnityGlobalCommand command = new UnityGlobalCommand();
            command.OpCode = CommandOpCode.WeatherControl;
            command.WeatherControl = new WeatherControlMessage();
            command.WeatherControl.RainIntensity = p_intensity;

            m_commHandler.Send(command.ToByteArray());
        }
    }
}
