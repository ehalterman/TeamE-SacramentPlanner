using System;
using System.ComponentModel.DataAnnotations;

namespace TeamE_SacramentPlanner.Models
{
    public class MeetingProgram
    {
        public int ID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name ="Meeting Date")]
        public DateTime MeetingDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Presiding { get; set; }

        [Required]
        [StringLength(50)]
        public string Conducting { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Opening Hymn")]
        public string OpHymnName { get; set; }

        [Required]
        [Display(Name = "Opening Hymn Number")]
        public int OpHymnNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Invocation { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn")]
        [StringLength(100)]
        public string SHymnName { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn Number")]
        public int SHymnNumber { get; set; }

        [Display(Name = "Musical Number")]
        [StringLength(200)]
        public string MusicalNumber { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Closing Hymn")]
        public string ClHymnName { get; set; }

        [Required]
        [Display(Name = "Closing Hymn Number")]
        public int ClHymnNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Benediction { get; set; }
    }
}
