using System;
using System.ComponentModel.DataAnnotations;

namespace TeamE_SacramentPlanner.Models
{
    public class Speaker
    {
        public int ID { get; set; }

        [Required]
        public int MeetingID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Speaker Name")]
        public string SpeakerName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Speaker Type")]
        public string SpeakerType { get; set; }
    }
}
