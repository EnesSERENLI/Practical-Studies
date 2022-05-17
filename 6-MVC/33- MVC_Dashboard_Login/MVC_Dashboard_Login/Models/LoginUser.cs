using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Dashboard_Login.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez!")]
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

    }
}