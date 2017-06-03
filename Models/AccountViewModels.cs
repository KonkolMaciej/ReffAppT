using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ReffAppT.Models
{

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Adres e-mail")]
        [EmailAddress]

        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Display(Name = "Zapamiętać Cię?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Adres e-mail")]
        //[IsValid]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} musi zawierać co najmniej następującą liczbę znaków: {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]

        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Hasło i jego potwierdzenie są niezgodne.")]

        public string ConfirmPassword { get; set; }
        public string RoleName { get; set; }
    }

   

        //    public class IsValid : ValidationAttribute
        //{
        //    public IsValid()
        //    {
        //        ErrorMessage = (" Email jest błędny.");
        //    }

        //    public bool IsValidEmail(string Email)
        //    {
        //        try
        //        {
        //            var addr = new System.Net.Mail.MailAddress(Email);
        //            return addr.Address == Email;
        //        }
        //        catch
        //        {
        //            return false;
        //        }
        //    }
        //}
    }

 
