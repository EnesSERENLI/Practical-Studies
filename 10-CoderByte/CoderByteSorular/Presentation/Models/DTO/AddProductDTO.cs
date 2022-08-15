using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Presentation.Models.DTO
{
    public class AddProductDTO
    {
        [Required(ErrorMessage = "ProductName cannot be empty")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "UnitPrice cannot be empty")]
        public decimal UnitPrice { get; set; }
        [Required(ErrorMessage = "UnitsInStock cannot be empty")]
        public short UnitsInStock { get; set; }
        [Required(ErrorMessage = "CategoryName cannot be empty")]
        public Guid CategoryId { get; set; }
        public string Description { get; set; }
    }
}