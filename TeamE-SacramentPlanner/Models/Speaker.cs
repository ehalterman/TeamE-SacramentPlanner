using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamE_SacramentPlanner.Models
{
    public class Speaker
    {
        public int ID { get; set; }
        public int MeetingID { get; set; }
        public string SpeakerName { get; set; }
        public string SpeakerType { get; set; }
    }
}
