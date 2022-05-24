using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Sepet.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez!!")]
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password boş geçilemez!!")]
        [Display(Name ="Şifre")]
        public string Password { get; set; }
    }
}