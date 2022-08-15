using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class CartItem
    {
        public CartItem()
        {
            Quantity = 1; //Ürün eklendiğinde adet en az 1 olmalı.
        }
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid? AppUserId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get => Price * Quantity; }
    }
}