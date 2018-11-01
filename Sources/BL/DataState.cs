using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Subjects;
using UnityAPI.Pub;
using UnityAPI.Sub;
using UnityUIWrapper.Model;

namespace UnityUIWrapper.BL
{
    public class DataState
    {
        private static DataState s_state = null;
        private CommunicationHandler m_commHandler;
        private APIImplementation m_api;
        private readonly ISubject<Unit> m_propertyUpdatedEvent = new Subject<Unit>();
        private readonly ISubject<Unit> m_entitiesUpdatedEvent = new Subject<Unit>();
        private bool m_highlightObjects = false;
        private CameraView m_cameraView = CameraView.PlanView;

        private List<EntityData> m_entities = new List<EntityData>();

        private string m_currentScenePath;

        private ScenarioState m_state = ScenarioState.Init;
        private long m_elapsedTime = 0;

        public List<EntityObject> ObjectTypeList { get; set; }

        public bool HighlightEntities
        {
            get { return m_highlightObjects; }
            set
            {
                if (m_highlightObjects == value)
                    return;

                m_highlightObjects = value;
                m_propertyUpdatedEvent.OnNext(new Unit());

                m_api.ToggleEntitiesHighlight(m_highlightObjects);
            }
        }

        public IObservable<Unit> PropertyUpdatedEvent
        {
            get { return m_propertyUpdatedEvent; }
        }

        public IObservable<Unit> EntitiesUpdatedEvent
        {
            get { return m_entitiesUpdatedEvent; }
        }

        public void SetSelectedCamera(CameraView p_camera)
        {
            if (p_camera == m_cameraView)
                return;

            m_cameraView = p_camera;
            m_api.SetCameraView(m_cameraView);
            m_propertyUpdatedEvent.OnNext(new Unit());
        }

        public CameraView SelectedCameraView
        {
            get { return m_cameraView; }
        }

        private DataState()
        {
            m_api = APIImplementation.Instance;
            m_commHandler = CommunicationHandler.Instance;

            m_commHandler.StatusUpdateEvent += updateEntities;

            ObjectTypeList = new List<EntityObject>();

            ObjectTypeList.Add(new EntityObject
            {
                Name = "T-72 Tank",
                TypeId = 1,
                Class = EntityObject.ObjectClass.Ground
            });

            ObjectTypeList.Add(new EntityObject
            {
                Name = "Route",
                TypeId = 2,
                Class = EntityObject.ObjectClass.Tactical
            });
        }

        public long ElapsedTime
        {
            get { return m_elapsedTime; }
            set
            {
                if (m_elapsedTime == value)
                    return;

                m_elapsedTime = value;
                m_propertyUpdatedEvent.OnNext(new Unit());
            }
        }

        private void updateEntities(StatusMessage p_msg)
        {

            foreach (var ent in p_msg.Entities)
            {
                var e = m_entities.FirstOrDefault(et => et.Id == ent.Id);

                if (e == null)
                {
                    m_entities.Add(ent);
                }

                else
                {
                    e.Location = ent.Location;
                    e.Orientation = ent.Orientation;
                    e.Name = ent.Name;
                }
            }

            List<int> toDelete = new List<int>();

            foreach (var ent in m_entities)
            {
                var e = p_msg.Entities.FirstOrDefault(et => et.Id == ent.Id);

                if (e == null)
                    toDelete.Add(ent.Id);
            }

            m_entities.RemoveAll(et => toDelete.Contains(et.Id));

            m_entitiesUpdatedEvent.OnNext(new Unit());
        }

        public static DataState Instance
        {
            get
            {
                if (s_state == null)
                {
                    s_state = new DataState();
                }

                return s_state;
            }
        }

        public List<EntityData> Entities
        {
            get { return m_entities; }
        }
    }
}
