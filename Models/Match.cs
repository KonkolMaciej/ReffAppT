using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ReffAppT.Models

{
    public class Match
    {
        public Match()
        {
            this.Referees = new HashSet<Referee>();
        }
        [Key]
        public int MatchId { get; set; }
        public string HostTeam { get; set; }
        public string GuestTeam { get; set; }
        public string GymAddress { get; set; }
        public string Liga { get; set; }
        public Categories Category { get; set; }
        [Display(Name = "Add date: ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        public System.DateTime AddDate { get; set; }

        [Display(Name = "Referee name: ")]
        public string RefId { get; set; }
        //[ForeignKey("Id")]
        public ICollection<Referee> Referees { get; set; }
        //public virtual Category Match { get; set; }

    }
    public enum Categories
    {
        Mlodziczki,
        Kadetki,
        Kadeci,
        Juniorki
    }
    

}