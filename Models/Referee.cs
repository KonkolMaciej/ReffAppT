using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace ReffAppT.Models




{
    public class Referee
    {

        public Referee()
        {
            Matches = new List<Match>();
        }
        [Key]
        public int RefId { get; set; }
        [Required]
        [Display(Name = "Imie: ")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Naz: ")]
        public string Surname { get; set; }
        [NotMapped]
        public string FullName
        {
            get { return Name + " " + Surname; }
        }
        [Display(Name = "Adres: ")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Miasto: ")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Kod pocztowy: ")]
        [MaxLength(12)]
        public string PostalCode { get; set; }
        [Display(Name = "Aktywny ")]
        public bool Active { get; set; }
        //public virtual Match Match { get; set; }
        public virtual ICollection<Match> Matches { get; set; }
    }




}