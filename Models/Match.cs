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
        [Display(Name = "Drużyna gospodarzy:")]
        [MaxLength(100)]
        [Required]
        public string HostTeam { get; set; }
        [Display(Name = "Drużyna gości:")]
        [MaxLength(100)]
        [Required]
        public string GuestTeam { get; set; }
        [Required]
        [Display(Name = "Adres sali:")]
        public string GymAddress { get; set; }

        [Required]
        public string Liga { get; set; }
        public Categories Category { get; set; }
        [Display(Name = "Add date: ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DateAttribute]
        public System.DateTime AddDate { get; set; }

        [Display(Name = "Referee name: ")]
        public int RefId { get; set; }
        //[ForeignKey("Id")]
        public ICollection<Referee> Referees { get; set; }
    

    }
    public enum Categories
    {
        Mlodziczki,
        Kadetki,
        Kadeci,
        Juniorki
    }
    public class DateAttribute : ValidationAttribute, IClientModelValidator
    {
        

        public DateAttribute()
        {

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Match match = (Match)validationContext.ObjectInstance;

            if (match.AddDate <= DateTime.Now)
            {
                return new ValidationResult("Mecz musi odbyć się w przyszłości!");
            }

            return ValidationResult.Success;
        }

    }
}