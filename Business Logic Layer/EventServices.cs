using Digital_NoteBooK.Data_Access_Layer;
using Digital_NoteBooK.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_NoteBooK.Business_Logic_Layer
{
    class EventServices
    {
        EventDataAccess eventDataAccess;

        public EventServices()
        {
            eventDataAccess = new EventDataAccess();
        }

        public int AddnewEvent(string eventName,string eventDate,string eventPriority,string eventDetails,int userId)
        {
            Events events = new Events();
            events.EventName = eventName;
            events.EventDate = eventDate;
            events.EventPriority = eventPriority;
            events.EventDetails = eventDetails;
            events.UserId = userId;
            return this.eventDataAccess.CreateEvent(events);
        }

        public List<Events> GetAllEvents(int userId)
        {
            return this.eventDataAccess.GetAllEvents(userId);
        }

        public int UpdateExistingEvent(string eventName,string eventDate,string eventPriority,string eventDetails, int eventId)
        {
            Events events = new Events();
            events.EventId = eventId;
            events.EventName = eventName;
            events.EventDate = eventDate;
            events.EventPriority = eventPriority;
            events.EventDetails = eventDetails;
            return this.eventDataAccess.UpdateEvent(events, eventId);
        }

        public int DeleteExitingEvent(int eventId)
        {
            return this.eventDataAccess.DeleteEvent(eventId);
        }
    }
}
