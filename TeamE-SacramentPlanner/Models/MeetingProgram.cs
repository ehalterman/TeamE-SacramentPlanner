using System;
using System.ComponentModel.DataAnnotations;

namespace TeamE_SacramentPlanner.Models
{
    public class MeetingProgram
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }
        public string Presiding { get; set; }
        public string Conducting { get; set; }
        public string OpHymnName { get; set; }
        public int OpHymnNumber { get; set; }
        public string Invocation { get; set; }
        public string SHymnName { get; set; }
        public int SHymnNumber { get; set; }
        public string MusicalNumber { get; set; }
        public string ClHymnName { get; set; }
        public int ClHymnNumber { get; set; }
        public string Benediction { get; set; }
    }
}
