using Digital_NoteBooK.Enities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_NoteBooK.Data_Access_Layer
{
    class EventDataAccess
    {
        DataAccess dataAccess;

        public EventDataAccess()
        {
            dataAccess = new DataAccess();
        }

        public List<Events> GetAllEvents(int userId)
        {
            string sql = "SELECT * FROM UserEvents WHERE id='"+userId+"';";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Events> events = new List<Events>();
            while(reader.Read())
            {
                Events event1 = new Events();
                event1.EventId = (int)reader["EventId"];
                event1.EventName = reader["EventName"].ToString();
                event1.EventDate = reader["EventDate"].ToString();
                event1.EventPriority = reader["EventPriority"].ToString();
                event1.EventDetails = reader["EventDetails"].ToString();
                event1.UserId = (int)reader["id"];
                events.Add(event1);
            }
            
            return events;
        }

        public int CreateEvent(Events events)
        {
            string sql = "INSERT INTO UserEvents(EventName,EventDate,EventPriority,EventDetails,id) VALUES('" + events.EventName + "','" + events.EventDate + "','" + events.EventPriority + "','" + events.EventDetails + "','"+events.UserId+"');";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEvent(Events events,int  eventId)
        {
            string sql = "UPDATE UserEvents SET EventId='"+events.EventId+"',EventName='"+events.EventName+"',EventDate='"+events.EventDate+"',EventPriority='"+events.EventPriority+"',EventDetails='"+events.EventDetails+"' WHERE EventId='"+eventId+";";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int DeleteEvent(int eventId)
        {
            string sql = "DELETE FROM UserEvents WHERE EventId='" + eventId+"';";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
    }
}
