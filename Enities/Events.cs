using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_NoteBooK.Enities
{
    class Events
    {
        public int EventId { set; get; }
        public string EventName { set; get; }
        public string EventDate { set; get; }
        public string EventDetails { set; get;}
        public string EventPriority { set; get; }

        public int UserId { set; get; }

    }
}
