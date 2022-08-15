using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Presentation.Models.DTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "FirstName is required!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Username is required!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword is required!")]
        [Compare("Password", ErrorMessage = "Passwords are not the same!")]
        public string ConfirmPassword { get; set; }
        [EmailAddress(ErrorMessage = "Email is required!")]
        public string Email { get; set; }
    }
}