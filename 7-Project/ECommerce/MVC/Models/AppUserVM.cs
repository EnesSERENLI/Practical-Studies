using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class AppUserVM
    {
        [Required(ErrorMessage ="kullanıcı zorunlu")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "şifre zorunlu")]
        public string Password { get; set; }
        [Required(ErrorMessage = "şifre tekrar zorunlu")]
        [Compare("Password", ErrorMessage ="şifreler aynı değil!")]
        public string ComfirmPassword { get; set; }
        [Required(ErrorMessage = "email zorunlu")]
        public string Email { get; set; }
    }
}