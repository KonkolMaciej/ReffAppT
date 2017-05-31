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

        [Key]
        public int RefId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [NotMapped]
        public string FullName
        {
            get { return Name + " " + Surname; }
        }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public bool Active { get; set; }
        //public string LoginErrorMessage { get; set; }
        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]

        //[Required(ErrorMessage = "podaj adres email")]
        //[EmailAddress(ErrorMessage = "niepoprawny adres email")]
        //[IsValid]
       // public string Email { get; set; }
        public virtual Match Match { get; set; }

    }

    public static class MyHelper
    {
        public static string ImportPhoto(string scr)
        {
            return String.Format("<img src =" + scr + "/>");
        }
    }

    
}