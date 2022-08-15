using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Presentation.Models.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Kullanıcı Adı boş olamaz!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password boş olamaz!")]
        public string Password { get; set; }    
    }
}